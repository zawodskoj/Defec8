using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;
using Defec8.Instructions;
using Timer = System.Windows.Forms.Timer;

namespace Defec8
{
    public enum CpuState
    {
        Running,
        Paused,
        Stopped
    }

    public enum CpuRegister
    {
        Ax,
        Bx,
        Cx,

        Ip,

        Si,
        Di,
        Sp,
        Bp
    }

    [Flags]
    public enum CpuFlags
    {
        None = 0,
        Overflow = 1,
        Parity = 2,
        Zero = 4,
        Sign = 8
    }

    public enum CpuInterrupt
    {
        EndOfCode,
        ReadAccessViolation,
        WriteAccessViolation,
        Halted
    }

    public class CpuInterruptEventArgs : EventArgs
    {
        public CpuInterrupt Interrupt { get; set; }
    }

    public class Cpu : INotifyPropertyChanged
    {
        private int _maxOps;

        public const int RamSize = 0x10000;
        public const int RomSize = 0x10000;
        public const int VramSize = 0x20000;

        public const int RamOffset = 0x10000;
        public const int RomOffset = 0;
        public const int VramOffset = 0x40000;

        public int MaxOpsPerSecond
        {
            get => _maxOps;
            set
            {
                _maxOps = value;
                _timer.Interval = _maxOps < 1 ? 1 : Math.Max(1, 1000 / _maxOps);
            }
        }

        public uint RegAx { get; set; }
        public uint RegBx { get; set; }
        public uint RegCx { get; set; }
        public uint RegIp { get; set; }
        public uint RegSi { get; set; }
        public uint RegDi { get; set; }
        public uint RegSp { get; set; }
        public uint RegBp { get; set; }

        public bool FlagCarry { get; set; }
        public bool FlagParity { get; set; }
        public bool FlagZero { get; set; }
        public bool FlagSign { get; set; }

        public uint GetRegister(CpuRegister reg)
        {
            switch (reg)
            {
                case CpuRegister.Ax: return RegAx;
                case CpuRegister.Bx: return RegBx;
                case CpuRegister.Cx: return RegCx;
                case CpuRegister.Ip: return RegIp;
                case CpuRegister.Si: return RegSi;
                case CpuRegister.Di: return RegDi;
                case CpuRegister.Sp: return RegSp;
                case CpuRegister.Bp: return RegBp;
                default: throw new Exception();
            }
        }

        public void SetRegister(CpuRegister reg, uint val)
        {
            switch (reg)
            {
                case CpuRegister.Ax: RegAx = val; break;
                case CpuRegister.Bx: RegBx = val; break;
                case CpuRegister.Cx: RegCx = val; break;
                case CpuRegister.Ip: RegIp = val; break;
                case CpuRegister.Si: RegSi = val; break;
                case CpuRegister.Di: RegDi = val; break;
                case CpuRegister.Sp: RegSp = val; break;
                case CpuRegister.Bp: RegBp = val; break;
                default: throw new Exception();
            }
        }

        public byte GetMemory(uint ptr)
        {
            if (ptr < RamOffset) return Rom[(int) ptr];
            if (ptr < RamOffset + RamSize) return Ram[(int) ptr - RamOffset];
            if (ptr >= VramOffset && ptr < VramOffset + VramSize) return 0;

            Interrupt(CpuInterrupt.ReadAccessViolation);
            return 0;
        }

        public void SetMemory(uint ptr, byte value)
        {
            if (ptr < RamOffset) Interrupt(CpuInterrupt.WriteAccessViolation);
            else if (ptr < RamOffset + RamSize) Ram[(int) ptr - RamOffset] = value;
            else if (ptr >= VramOffset && ptr < VramOffset + VramSize)
            {
                const int baseWidth = 320;
                const int baseHeight = 240;

                const int scale = 2;

                var offs = ptr - VramOffset;
                var x = offs % (baseWidth / scale);
                var y = offs / (baseWidth / scale);
                if (y >= baseHeight / scale) return;

                for (var i = 0; i < scale; i++)
                    for (var j = 0; j < scale; j++)
                        Screen.SetPixel((int) x * scale + i, (int) y * scale + j, Color.FromArgb(value, value, value));
            }

            else Interrupt(CpuInterrupt.WriteAccessViolation);
        }

        public CpuFlags GetFlags() =>
            (FlagSign ? CpuFlags.Sign : CpuFlags.None) |
            (FlagCarry ? CpuFlags.Overflow : CpuFlags.None) |
            (FlagZero ? CpuFlags.Zero : CpuFlags.None) |
            (FlagParity ? CpuFlags.Parity : CpuFlags.None);

        public void SetFlags(CpuFlags flags)
        {
            FlagSign = flags.HasFlag(CpuFlags.Sign);
            FlagCarry = flags.HasFlag(CpuFlags.Overflow);
            FlagZero = flags.HasFlag(CpuFlags.Zero);
            FlagParity = flags.HasFlag(CpuFlags.Parity);
        }

        public List<byte> Ram { get; } = new byte[RamSize].ToList();
        public List<byte> Rom { get; } = new byte[RomSize].ToList();

        public Bitmap Screen { get; } = new Bitmap(320, 240, PixelFormat.Format24bppRgb);

        public List<Instruction> Code { get; set; }

        private readonly Timer _timer;
        public CpuState State { get; private set; } = CpuState.Stopped;

        public Cpu()
        {
            _timer = new Timer {Interval = 1};
            _timer.Tick += Step;
        }

        private bool _deferEvents;

        private void Step(object source, EventArgs e)
        {
            const int maxIpc = 10000;
            var ipc = _maxOps < 1 ? maxIpc : Math.Min(Math.Max(1, _maxOps / 1000), maxIpc);

            _deferEvents = true;

            for (var i = 0; i < ipc - 1; i++)
            {
                if (State == CpuState.Running)
                    Step();
                else
                    break;
            }

            _deferEvents = false;

            if (State == CpuState.Running)
                Step();
        }

        public void Reset()
        {
            Ram.Clear();
            Ram.AddRange(new byte[RamSize]);
            RegAx = RegBx = RegCx = RegIp = RegSp = RegBp = RegSi = RegDi = 0;
            FlagCarry = FlagParity = FlagZero = FlagSign = false;
            
            using (var g = Graphics.FromImage(Screen)) g.Clear(Color.Black);
        }

        public void Start()
        {
            if (State == CpuState.Stopped) Reset();

            _timer.Start();
            State = CpuState.Running;
        }

        public void Stop()
        {
            _timer.Stop();
            State = CpuState.Stopped;
        }

        public void Pause()
        {
            _timer.Stop();
            State = CpuState.Paused;
        }

        public void Interrupt(CpuInterrupt interrupt)
        {
            Stop();
            InterruptRaised?.Invoke(this, new CpuInterruptEventArgs {Interrupt = interrupt});
        }

        public void Step()
        {
            switch (State)
            {
                case CpuState.Paused:
                case CpuState.Running:
                    break;
                case CpuState.Stopped:
                    Reset();
                    State = CpuState.Paused;
                    break;
            }

            if (RegIp >= Code.Count)
            {
                Interrupt(CpuInterrupt.EndOfCode);
                return;
            }

            var instruction = Code[(int) RegIp];
            instruction.Execute(this);
            if (State != CpuState.Stopped)
                RegIp++;

            if (!_deferEvents)
                StepPassed?.Invoke(this, EventArgs.Empty);
        }
        
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (!_deferEvents)
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler StepPassed;
        public event EventHandler<CpuInterruptEventArgs> InterruptRaised;

        public void SetRom(byte[] kbytes, int len)
        {
            Rom.Clear();
            Rom.AddRange(kbytes.Concat(Enumerable.Repeat<byte>(0, Cpu.RamSize - len)));
        }
    }
}
