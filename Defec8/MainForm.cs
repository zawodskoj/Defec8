using Be.Windows.Forms;
using Defec8.Instructions;
using FastColoredTextBoxNS;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Defec8
{
    public partial class MainForm : Form
    {
        private readonly Cpu _cpu = new Cpu();

        public MainForm()
        {
            InitializeComponent();

            hbRam.ByteProvider = new DynamicByteProvider(_cpu.Ram);
            hbRom.ByteProvider = new DynamicByteProvider(_cpu.Rom);
            hbRam.LostFocus += (o, e) => hbRam.ByteProvider.ApplyChanges();
            hbRom.LostFocus += (o, e) => hbRom.ByteProvider.ApplyChanges();

            cbCarryFlag.DataBindings.Add("Checked", _cpu, "FlagCarry");
            cbParityFlag.DataBindings.Add("Checked", _cpu, "FlagParity");
            cbZeroFlag.DataBindings.Add("Checked", _cpu, "FlagZero");
            cbSignFlag.DataBindings.Add("Checked", _cpu, "FlagSign");

            tbRegAx.DataBindings.Add("Text", _cpu, "RegAx");
            tbRegBx.DataBindings.Add("Text", _cpu, "RegBx");
            tbRegCx.DataBindings.Add("Text", _cpu, "RegCx");
            tbRegIp.DataBindings.Add("Text", _cpu, "RegIp");
            tbRegSp.DataBindings.Add("Text", _cpu, "RegSp");
            tbRegBp.DataBindings.Add("Text", _cpu, "RegBp");
            tbRegSi.DataBindings.Add("Text", _cpu, "RegSi");
            tbRegDi.DataBindings.Add("Text", _cpu, "RegDi");

            tbMaxOpsPerSecond.DataBindings.Add("Text", _cpu, "MaxOpsPerSecond");

            fctbCode.Language = Language.Custom;
            var opcodeStyle = new TextStyle(Brushes.DarkBlue, Brushes.Transparent, FontStyle.Regular);
            var registerStyle = new TextStyle(Brushes.DarkViolet, Brushes.Transparent, FontStyle.Bold);
            var regPointerStyle = new TextStyle(Brushes.DarkRed, Brushes.Transparent, FontStyle.Bold);
            var nwCharsStyle = new TextStyle(Brushes.Black, Brushes.Transparent, FontStyle.Regular);
            fctbCode.TextChangedDelayed += (o, e) =>
            {
                var range = e.ChangedRange;
                
                range.ClearStyle(opcodeStyle, registerStyle, nwCharsStyle);

                range.SetStyle(regPointerStyle, "(?:\\W|^)\\[(ax|bx|cx|ip|sp|bp|si|di)\\](?:\\W|$)", RegexOptions.IgnoreCase | RegexOptions.Multiline);
                range.SetStyle(nwCharsStyle, "\\W", RegexOptions.IgnoreCase | RegexOptions.Multiline);
                range.SetStyle(opcodeStyle, "^\\s*(" + string.Join("|", Instruction.Opcodes) + ")\\s+", RegexOptions.IgnoreCase | RegexOptions.Multiline);
                range.SetStyle(registerStyle, "(?:\\W|^)(?!\\[)(ax|bx|cx|ip|sp|bp|si|di)(?!\\])(?:\\W|$)", RegexOptions.IgnoreCase | RegexOptions.Multiline);
            };

            CodeParsingResult code = null;
            var afterInterrupt = false;

            var curBrush = new SolidBrush(Color.FromArgb(0xff, 0xff, 0x80));
            var excepBrush = new SolidBrush(Color.FromArgb(0xff, 0xa0, 0xa0));
            fctbCode.PaintLine += (o, e) =>
            {
                if (code == null) return;

                if (code.Success)
                {
                    if ((_cpu.State == CpuState.Paused || _cpu.State == CpuState.Running) &&
                        code.Code[(int) _cpu.RegIp].Item1 == e.LineIndex)
                        e.Graphics.FillRectangle(curBrush, e.LineRect);

                    if (afterInterrupt && code.Code[(int)_cpu.RegIp].Item1 == e.LineIndex)
                        e.Graphics.FillRectangle(excepBrush, e.LineRect);
                }

                else
                {
                    if (code.LineNumber == e.LineIndex)
                        e.Graphics.FillRectangle(excepBrush, e.LineRect);
                }
            };

            tsbUndo.Click += (o, e) => fctbCode.Undo();
            tsbRedo.Click += (o, e) => fctbCode.Redo();

            tsbStart.Click += (o, e) =>
            {
                afterInterrupt = false;
                code = Instruction.Parse(fctbCode.Text);
                if (!code.Success)
                {
                    fctbCode.Navigate(code.LineNumber);
                    fctbCode.Refresh();
                    MessageBox.Show(code.Reason);
                    return;
                }
                _cpu.Code = code.Code.Select(x => x.Item2).ToList();
                _cpu.Start();
                fctbCode.ReadOnly = true;
            };
            tsbStop.Click += (o, e) =>
            {
                _cpu.Stop();
                fctbCode.ReadOnly = false;
            };
            tsbPause.Click += (o, e) =>
            {
                _cpu.Pause();
            };
            tsbStep.Click += (o, e) =>
            {
                if (_cpu.State == CpuState.Stopped)
                {
                    afterInterrupt = false;
                    code = Instruction.Parse(fctbCode.Text);
                    if (!code.Success)
                    {
                        fctbCode.Navigate(code.LineNumber);
                        fctbCode.Refresh();
                        MessageBox.Show(code.Reason);
                        return;
                    }

                    _cpu.Code = code.Code.Select(x => x.Item2).ToList();
                    fctbCode.ReadOnly = true;
                }
                _cpu.Step();
            };

            pbScreen.Image = _cpu.Screen;

            _cpu.StepPassed += (o, e) =>
            {
                hbRam.Invalidate();
                pbScreen.Refresh();
                fctbCode.Refresh();
            };
            _cpu.InterruptRaised += (o, e) =>
            {
                afterInterrupt = true;
                hbRam.Invalidate();
                pbScreen.Refresh();
                fctbCode.Navigate(code.Code[(int)_cpu.RegIp].Item1);
                fctbCode.Refresh();
                MessageBox.Show("Прерывание процессора: " + e.Interrupt);
            };
        }

        private void tsmiExit_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void tsmiOpenRam_Click(object sender, System.EventArgs e)
        {
            using (var ofd = new OpenFileDialog
            {
                Filter = "Двоичный файл (*.bin)|*.bin",
                Title = "Выберите файл ROM",
            })
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (var file = ofd.OpenFile())
                    {
                        var kbytes = new byte[Cpu.RamSize];
                        var read = file.Read(kbytes, 0, kbytes.Length);
                        _cpu.SetRom(kbytes, read);
                        hbRom.Refresh();
                    }
                }
        }

        private void tsmiSaveRom_Click(object sender, System.EventArgs e)
        {
            using (var sfd = new SaveFileDialog
            {
                Filter = "Двоичный файл (*.bin)|*.bin",
                Title = "Выберите файл ROM",
            })
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (var file = sfd.OpenFile())
                    {
                        var kbytes = _cpu.Rom.ToArray();
                        file.Write(kbytes, 0, kbytes.Length);
                    }
                }
        }

        private void tsmiOpenAsm_Click(object sender, System.EventArgs e)
        {
            using (var ofd = new OpenFileDialog
            {
                Filter = "Двоичный файл (*.bin)|*.bin",
                Title = "Выберите файл ROM",
            })
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    fctbCode.OpenFile(ofd.FileName);
                }
        }

        private void tsmiSaveAsm_Click(object sender, System.EventArgs e)
        {
            using (var sfd = new SaveFileDialog
            {
                Filter = "Двоичный файл (*.bin)|*.bin",
                Title = "Выберите файл ROM",
            })
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    fctbCode.SaveToFile(sfd.FileName, Encoding.UTF8);
                }
        }

        private void tsmiAbout_Click(object sender, System.EventArgs e)
        {
            using (var form = new AboutForm())
                form.ShowDialog();
        }
    }
}
