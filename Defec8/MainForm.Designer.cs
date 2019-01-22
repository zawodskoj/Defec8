namespace Defec8
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Icon = Properties.Resources.cpu;
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gbCode = new System.Windows.Forms.GroupBox();
            this.fctbCode = new FastColoredTextBoxNS.FastColoredTextBox();
            this.gbScreen = new System.Windows.Forms.GroupBox();
            this.gbRegisters = new System.Windows.Forms.GroupBox();
            this.tbMaxOpsPerSecond = new System.Windows.Forms.TextBox();
            this.lMaxOpsPerSecond = new System.Windows.Forms.Label();
            this.cbGpuMode = new System.Windows.Forms.ComboBox();
            this.lGpuMode = new System.Windows.Forms.Label();
            this.cbSignFlag = new System.Windows.Forms.CheckBox();
            this.cbZeroFlag = new System.Windows.Forms.CheckBox();
            this.cbParityFlag = new System.Windows.Forms.CheckBox();
            this.cbCarryFlag = new System.Windows.Forms.CheckBox();
            this.lRegBp = new System.Windows.Forms.Label();
            this.lRegSp = new System.Windows.Forms.Label();
            this.lRegDi = new System.Windows.Forms.Label();
            this.tbRegDi = new System.Windows.Forms.TextBox();
            this.tbRegSp = new System.Windows.Forms.TextBox();
            this.tbRegBp = new System.Windows.Forms.TextBox();
            this.lRegSi = new System.Windows.Forms.Label();
            this.tbRegSi = new System.Windows.Forms.TextBox();
            this.lRegIp = new System.Windows.Forms.Label();
            this.lRegCx = new System.Windows.Forms.Label();
            this.lRegBx = new System.Windows.Forms.Label();
            this.tbRegBx = new System.Windows.Forms.TextBox();
            this.tbRegCx = new System.Windows.Forms.TextBox();
            this.tbRegIp = new System.Windows.Forms.TextBox();
            this.lRegAx = new System.Windows.Forms.Label();
            this.tbRegAx = new System.Windows.Forms.TextBox();
            this.tlpMemory = new System.Windows.Forms.TableLayoutPanel();
            this.gbRom = new System.Windows.Forms.GroupBox();
            this.hbRom = new Be.Windows.Forms.HexBox();
            this.gbRam = new System.Windows.Forms.GroupBox();
            this.hbRam = new Be.Windows.Forms.HexBox();
            this.tbHints = new System.Windows.Forms.TextBox();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpenAsm = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveAsm = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiOpenRom = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveRom = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbUndo = new System.Windows.Forms.ToolStripButton();
            this.tsbRedo = new System.Windows.Forms.ToolStripButton();
            this.tsbStart = new System.Windows.Forms.ToolStripButton();
            this.tsbPause = new System.Windows.Forms.ToolStripButton();
            this.tsbStop = new System.Windows.Forms.ToolStripButton();
            this.tsbStep = new System.Windows.Forms.ToolStripButton();
            this.pbScreen = new System.Windows.Forms.PictureBox();
            this.gbCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctbCode)).BeginInit();
            this.gbScreen.SuspendLayout();
            this.gbRegisters.SuspendLayout();
            this.tlpMemory.SuspendLayout();
            this.gbRom.SuspendLayout();
            this.gbRam.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.msMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCode
            // 
            this.gbCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCode.Controls.Add(this.fctbCode);
            this.gbCode.Location = new System.Drawing.Point(12, 52);
            this.gbCode.Name = "gbCode";
            this.gbCode.Size = new System.Drawing.Size(843, 259);
            this.gbCode.TabIndex = 2;
            this.gbCode.TabStop = false;
            this.gbCode.Text = "Код";
            // 
            // fctbCode
            // 
            this.fctbCode.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fctbCode.AutoScrollMinSize = new System.Drawing.Size(251, 742);
            this.fctbCode.BackBrush = null;
            this.fctbCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fctbCode.CharHeight = 14;
            this.fctbCode.CharWidth = 8;
            this.fctbCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctbCode.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctbCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctbCode.IsReplaceMode = false;
            this.fctbCode.Location = new System.Drawing.Point(3, 16);
            this.fctbCode.Name = "fctbCode";
            this.fctbCode.Paddings = new System.Windows.Forms.Padding(0);
            this.fctbCode.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctbCode.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctbCode.ServiceColors")));
            this.fctbCode.Size = new System.Drawing.Size(837, 240);
            this.fctbCode.TabIndex = 0;
            this.fctbCode.Text = resources.GetString("fctbCode.Text");
            this.fctbCode.Zoom = 100;
            // 
            // gbScreen
            // 
            this.gbScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbScreen.Controls.Add(this.pbScreen);
            this.gbScreen.Location = new System.Drawing.Point(12, 317);
            this.gbScreen.Name = "gbScreen";
            this.gbScreen.Size = new System.Drawing.Size(326, 259);
            this.gbScreen.TabIndex = 2;
            this.gbScreen.TabStop = false;
            this.gbScreen.Text = "Экран";
            // 
            // gbRegisters
            // 
            this.gbRegisters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbRegisters.Controls.Add(this.tbMaxOpsPerSecond);
            this.gbRegisters.Controls.Add(this.lMaxOpsPerSecond);
            this.gbRegisters.Controls.Add(this.cbGpuMode);
            this.gbRegisters.Controls.Add(this.lGpuMode);
            this.gbRegisters.Controls.Add(this.cbSignFlag);
            this.gbRegisters.Controls.Add(this.cbZeroFlag);
            this.gbRegisters.Controls.Add(this.cbParityFlag);
            this.gbRegisters.Controls.Add(this.cbCarryFlag);
            this.gbRegisters.Controls.Add(this.lRegBp);
            this.gbRegisters.Controls.Add(this.lRegSp);
            this.gbRegisters.Controls.Add(this.lRegDi);
            this.gbRegisters.Controls.Add(this.tbRegDi);
            this.gbRegisters.Controls.Add(this.tbRegSp);
            this.gbRegisters.Controls.Add(this.tbRegBp);
            this.gbRegisters.Controls.Add(this.lRegSi);
            this.gbRegisters.Controls.Add(this.tbRegSi);
            this.gbRegisters.Controls.Add(this.lRegIp);
            this.gbRegisters.Controls.Add(this.lRegCx);
            this.gbRegisters.Controls.Add(this.lRegBx);
            this.gbRegisters.Controls.Add(this.tbRegBx);
            this.gbRegisters.Controls.Add(this.tbRegCx);
            this.gbRegisters.Controls.Add(this.tbRegIp);
            this.gbRegisters.Controls.Add(this.lRegAx);
            this.gbRegisters.Controls.Add(this.tbRegAx);
            this.gbRegisters.Location = new System.Drawing.Point(344, 317);
            this.gbRegisters.Name = "gbRegisters";
            this.gbRegisters.Size = new System.Drawing.Size(328, 259);
            this.gbRegisters.TabIndex = 2;
            this.gbRegisters.TabStop = false;
            this.gbRegisters.Text = "Регистры";
            // 
            // tbMaxOpsPerSecond
            // 
            this.tbMaxOpsPerSecond.Location = new System.Drawing.Point(173, 164);
            this.tbMaxOpsPerSecond.Name = "tbMaxOpsPerSecond";
            this.tbMaxOpsPerSecond.Size = new System.Drawing.Size(149, 20);
            this.tbMaxOpsPerSecond.TabIndex = 25;
            // 
            // lMaxOpsPerSecond
            // 
            this.lMaxOpsPerSecond.AutoSize = true;
            this.lMaxOpsPerSecond.Location = new System.Drawing.Point(170, 141);
            this.lMaxOpsPerSecond.Name = "lMaxOpsPerSecond";
            this.lMaxOpsPerSecond.Size = new System.Drawing.Size(96, 13);
            this.lMaxOpsPerSecond.TabIndex = 24;
            this.lMaxOpsPerSecond.Text = "Макс. оп/с (0 - ∞):";
            // 
            // cbGpuMode
            // 
            this.cbGpuMode.FormattingEnabled = true;
            this.cbGpuMode.Location = new System.Drawing.Point(173, 216);
            this.cbGpuMode.Name = "cbGpuMode";
            this.cbGpuMode.Size = new System.Drawing.Size(149, 21);
            this.cbGpuMode.TabIndex = 23;
            // 
            // lGpuMode
            // 
            this.lGpuMode.AutoSize = true;
            this.lGpuMode.Location = new System.Drawing.Point(170, 193);
            this.lGpuMode.Name = "lGpuMode";
            this.lGpuMode.Size = new System.Drawing.Size(75, 13);
            this.lGpuMode.TabIndex = 22;
            this.lGpuMode.Text = "Видеорежим:";
            // 
            // cbSignFlag
            // 
            this.cbSignFlag.AutoSize = true;
            this.cbSignFlag.Location = new System.Drawing.Point(173, 111);
            this.cbSignFlag.Name = "cbSignFlag";
            this.cbSignFlag.Size = new System.Drawing.Size(106, 17);
            this.cbSignFlag.TabIndex = 21;
            this.cbSignFlag.Text = "SF - флаг знака";
            this.cbSignFlag.UseVisualStyleBackColor = true;
            // 
            // cbZeroFlag
            // 
            this.cbZeroFlag.AutoSize = true;
            this.cbZeroFlag.Location = new System.Drawing.Point(173, 85);
            this.cbZeroFlag.Name = "cbZeroFlag";
            this.cbZeroFlag.Size = new System.Drawing.Size(100, 17);
            this.cbZeroFlag.TabIndex = 20;
            this.cbZeroFlag.Text = "ZF - флаг ноля";
            this.cbZeroFlag.UseVisualStyleBackColor = true;
            // 
            // cbParityFlag
            // 
            this.cbParityFlag.AutoSize = true;
            this.cbParityFlag.Location = new System.Drawing.Point(173, 59);
            this.cbParityFlag.Name = "cbParityFlag";
            this.cbParityFlag.Size = new System.Drawing.Size(121, 17);
            this.cbParityFlag.TabIndex = 19;
            this.cbParityFlag.Text = "PF - флаг четности";
            this.cbParityFlag.UseVisualStyleBackColor = true;
            // 
            // cbCarryFlag
            // 
            this.cbCarryFlag.AutoSize = true;
            this.cbCarryFlag.Location = new System.Drawing.Point(173, 33);
            this.cbCarryFlag.Name = "cbCarryFlag";
            this.cbCarryFlag.Size = new System.Drawing.Size(124, 17);
            this.cbCarryFlag.TabIndex = 18;
            this.cbCarryFlag.Text = "CF - флаг переноса";
            this.cbCarryFlag.UseVisualStyleBackColor = true;
            // 
            // lRegBp
            // 
            this.lRegBp.AutoSize = true;
            this.lRegBp.Location = new System.Drawing.Point(16, 219);
            this.lRegBp.Name = "lRegBp";
            this.lRegBp.Size = new System.Drawing.Size(21, 13);
            this.lRegBp.TabIndex = 17;
            this.lRegBp.Text = "BP";
            // 
            // lRegSp
            // 
            this.lRegSp.AutoSize = true;
            this.lRegSp.Location = new System.Drawing.Point(17, 193);
            this.lRegSp.Name = "lRegSp";
            this.lRegSp.Size = new System.Drawing.Size(21, 13);
            this.lRegSp.TabIndex = 16;
            this.lRegSp.Text = "SP";
            // 
            // lRegDi
            // 
            this.lRegDi.AutoSize = true;
            this.lRegDi.Location = new System.Drawing.Point(17, 167);
            this.lRegDi.Name = "lRegDi";
            this.lRegDi.Size = new System.Drawing.Size(18, 13);
            this.lRegDi.TabIndex = 15;
            this.lRegDi.Text = "DI";
            // 
            // tbRegDi
            // 
            this.tbRegDi.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRegDi.Location = new System.Drawing.Point(43, 163);
            this.tbRegDi.Name = "tbRegDi";
            this.tbRegDi.Size = new System.Drawing.Size(100, 23);
            this.tbRegDi.TabIndex = 14;
            this.tbRegDi.Text = "DEADBABE";
            // 
            // tbRegSp
            // 
            this.tbRegSp.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRegSp.Location = new System.Drawing.Point(43, 189);
            this.tbRegSp.Name = "tbRegSp";
            this.tbRegSp.Size = new System.Drawing.Size(100, 23);
            this.tbRegSp.TabIndex = 13;
            this.tbRegSp.Text = "DEADBABE";
            // 
            // tbRegBp
            // 
            this.tbRegBp.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRegBp.Location = new System.Drawing.Point(43, 215);
            this.tbRegBp.Name = "tbRegBp";
            this.tbRegBp.Size = new System.Drawing.Size(100, 23);
            this.tbRegBp.TabIndex = 12;
            this.tbRegBp.Text = "DEADBABE";
            // 
            // lRegSi
            // 
            this.lRegSi.AutoSize = true;
            this.lRegSi.Location = new System.Drawing.Point(17, 141);
            this.lRegSi.Name = "lRegSi";
            this.lRegSi.Size = new System.Drawing.Size(17, 13);
            this.lRegSi.TabIndex = 11;
            this.lRegSi.Text = "SI";
            // 
            // tbRegSi
            // 
            this.tbRegSi.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRegSi.Location = new System.Drawing.Point(43, 137);
            this.tbRegSi.Name = "tbRegSi";
            this.tbRegSi.Size = new System.Drawing.Size(100, 23);
            this.tbRegSi.TabIndex = 10;
            this.tbRegSi.Text = "DEADBABE";
            // 
            // lRegIp
            // 
            this.lRegIp.AutoSize = true;
            this.lRegIp.Location = new System.Drawing.Point(15, 112);
            this.lRegIp.Name = "lRegIp";
            this.lRegIp.Size = new System.Drawing.Size(17, 13);
            this.lRegIp.TabIndex = 9;
            this.lRegIp.Text = "IP";
            // 
            // lRegCx
            // 
            this.lRegCx.AutoSize = true;
            this.lRegCx.Location = new System.Drawing.Point(16, 86);
            this.lRegCx.Name = "lRegCx";
            this.lRegCx.Size = new System.Drawing.Size(21, 13);
            this.lRegCx.TabIndex = 8;
            this.lRegCx.Text = "CX";
            // 
            // lRegBx
            // 
            this.lRegBx.AutoSize = true;
            this.lRegBx.Location = new System.Drawing.Point(16, 60);
            this.lRegBx.Name = "lRegBx";
            this.lRegBx.Size = new System.Drawing.Size(21, 13);
            this.lRegBx.TabIndex = 7;
            this.lRegBx.Text = "BX";
            // 
            // tbRegBx
            // 
            this.tbRegBx.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRegBx.Location = new System.Drawing.Point(43, 56);
            this.tbRegBx.Name = "tbRegBx";
            this.tbRegBx.Size = new System.Drawing.Size(100, 23);
            this.tbRegBx.TabIndex = 5;
            this.tbRegBx.Text = "DEADBABE";
            // 
            // tbRegCx
            // 
            this.tbRegCx.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRegCx.Location = new System.Drawing.Point(43, 82);
            this.tbRegCx.Name = "tbRegCx";
            this.tbRegCx.Size = new System.Drawing.Size(100, 23);
            this.tbRegCx.TabIndex = 4;
            this.tbRegCx.Text = "DEADBABE";
            // 
            // tbRegIp
            // 
            this.tbRegIp.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRegIp.Location = new System.Drawing.Point(43, 108);
            this.tbRegIp.Name = "tbRegIp";
            this.tbRegIp.Size = new System.Drawing.Size(100, 23);
            this.tbRegIp.TabIndex = 3;
            this.tbRegIp.Text = "DEADBABE";
            // 
            // lRegAx
            // 
            this.lRegAx.AutoSize = true;
            this.lRegAx.Location = new System.Drawing.Point(16, 34);
            this.lRegAx.Name = "lRegAx";
            this.lRegAx.Size = new System.Drawing.Size(21, 13);
            this.lRegAx.TabIndex = 1;
            this.lRegAx.Text = "AX";
            // 
            // tbRegAx
            // 
            this.tbRegAx.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRegAx.Location = new System.Drawing.Point(43, 30);
            this.tbRegAx.Name = "tbRegAx";
            this.tbRegAx.Size = new System.Drawing.Size(100, 23);
            this.tbRegAx.TabIndex = 0;
            this.tbRegAx.Text = "DEADBABE";
            // 
            // tlpMemory
            // 
            this.tlpMemory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMemory.ColumnCount = 1;
            this.tlpMemory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMemory.Controls.Add(this.gbRom, 0, 1);
            this.tlpMemory.Controls.Add(this.gbRam, 0, 0);
            this.tlpMemory.Location = new System.Drawing.Point(861, 52);
            this.tlpMemory.Name = "tlpMemory";
            this.tlpMemory.RowCount = 2;
            this.tlpMemory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMemory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMemory.Size = new System.Drawing.Size(358, 524);
            this.tlpMemory.TabIndex = 3;
            // 
            // gbRom
            // 
            this.gbRom.Controls.Add(this.hbRom);
            this.gbRom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbRom.Location = new System.Drawing.Point(3, 265);
            this.gbRom.Name = "gbRom";
            this.gbRom.Size = new System.Drawing.Size(352, 256);
            this.gbRom.TabIndex = 3;
            this.gbRom.TabStop = false;
            this.gbRom.Text = "ПЗУ";
            // 
            // hbRom
            // 
            this.hbRom.BytesPerLine = 8;
            this.hbRom.ColumnInfoVisible = true;
            this.hbRom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hbRom.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hbRom.GroupSeparatorVisible = true;
            this.hbRom.LineInfoVisible = true;
            this.hbRom.Location = new System.Drawing.Point(3, 16);
            this.hbRom.Name = "hbRom";
            this.hbRom.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hbRom.Size = new System.Drawing.Size(346, 237);
            this.hbRom.StringViewVisible = true;
            this.hbRom.TabIndex = 1;
            this.hbRom.UseFixedBytesPerLine = true;
            this.hbRom.VScrollBarVisible = true;
            // 
            // gbRam
            // 
            this.gbRam.Controls.Add(this.hbRam);
            this.gbRam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbRam.Location = new System.Drawing.Point(3, 3);
            this.gbRam.Name = "gbRam";
            this.gbRam.Size = new System.Drawing.Size(352, 256);
            this.gbRam.TabIndex = 2;
            this.gbRam.TabStop = false;
            this.gbRam.Text = "ОЗУ";
            // 
            // hbRam
            // 
            this.hbRam.BytesPerLine = 8;
            this.hbRam.ColumnInfoVisible = true;
            this.hbRam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hbRam.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hbRam.GroupSeparatorVisible = true;
            this.hbRam.LineInfoVisible = true;
            this.hbRam.Location = new System.Drawing.Point(3, 16);
            this.hbRam.Name = "hbRam";
            this.hbRam.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hbRam.Size = new System.Drawing.Size(346, 237);
            this.hbRam.StringViewVisible = true;
            this.hbRam.TabIndex = 1;
            this.hbRam.UseFixedBytesPerLine = true;
            this.hbRam.VScrollBarVisible = true;
            // 
            // tbHints
            // 
            this.tbHints.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHints.Enabled = false;
            this.tbHints.Location = new System.Drawing.Point(678, 323);
            this.tbHints.Multiline = true;
            this.tbHints.Name = "tbHints";
            this.tbHints.ReadOnly = true;
            this.tbHints.Size = new System.Drawing.Size(174, 253);
            this.tbHints.TabIndex = 4;
            this.tbHints.Text = resources.GetString("tbHints.Text");
            // 
            // tsMain
            // 
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbUndo,
            this.tsbRedo,
            this.toolStripSeparator1,
            this.tsbStart,
            this.tsbPause,
            this.tsbStop,
            this.toolStripSeparator2,
            this.tsbStep});
            this.tsMain.Location = new System.Drawing.Point(0, 24);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(1231, 25);
            this.tsMain.TabIndex = 6;
            this.tsMain.Text = "Панель быстрого доступа";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(1231, 24);
            this.msMain.TabIndex = 7;
            this.msMain.Text = "Главное меню";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpenAsm,
            this.tsmiSaveAsm,
            this.toolStripSeparator3,
            this.tsmiOpenRom,
            this.tsmiSaveRom,
            this.toolStripSeparator4,
            this.tsmiExit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "&Файл";
            // 
            // tsmiOpenAsm
            // 
            this.tsmiOpenAsm.Name = "tsmiOpenAsm";
            this.tsmiOpenAsm.Size = new System.Drawing.Size(228, 22);
            this.tsmiOpenAsm.Text = "&Открыть";
            this.tsmiOpenAsm.Click += new System.EventHandler(this.tsmiOpenAsm_Click);
            // 
            // tsmiSaveAsm
            // 
            this.tsmiSaveAsm.Name = "tsmiSaveAsm";
            this.tsmiSaveAsm.Size = new System.Drawing.Size(228, 22);
            this.tsmiSaveAsm.Text = "&Сохранить";
            this.tsmiSaveAsm.Click += new System.EventHandler(this.tsmiSaveAsm_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(225, 6);
            // 
            // tsmiOpenRom
            // 
            this.tsmiOpenRom.Name = "tsmiOpenRom";
            this.tsmiOpenRom.Size = new System.Drawing.Size(228, 22);
            this.tsmiOpenRom.Text = "&Импортировать образ ROM";
            this.tsmiOpenRom.Click += new System.EventHandler(this.tsmiOpenRam_Click);
            // 
            // tsmiSaveRom
            // 
            this.tsmiSaveRom.Name = "tsmiSaveRom";
            this.tsmiSaveRom.Size = new System.Drawing.Size(228, 22);
            this.tsmiSaveRom.Text = "&Экспортировать образ ROM";
            this.tsmiSaveRom.Click += new System.EventHandler(this.tsmiSaveRom_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(225, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(228, 22);
            this.tsmiExit.Text = "&Выход";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "&Справка";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(152, 22);
            this.tsmiAbout.Text = "&О программе";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // tsbUndo
            // 
            this.tsbUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUndo.Image = global::Defec8.Properties.Resources.Undo_16x;
            this.tsbUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUndo.Name = "tsbUndo";
            this.tsbUndo.Size = new System.Drawing.Size(23, 22);
            this.tsbUndo.Text = "Отменить";
            // 
            // tsbRedo
            // 
            this.tsbRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRedo.Image = global::Defec8.Properties.Resources.Redo_16x;
            this.tsbRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRedo.Name = "tsbRedo";
            this.tsbRedo.Size = new System.Drawing.Size(23, 22);
            this.tsbRedo.Text = "Вернуть";
            // 
            // tsbStart
            // 
            this.tsbStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbStart.Image = global::Defec8.Properties.Resources.Run_16x;
            this.tsbStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStart.Name = "tsbStart";
            this.tsbStart.Size = new System.Drawing.Size(23, 22);
            this.tsbStart.Text = "Запустить";
            // 
            // tsbPause
            // 
            this.tsbPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPause.Image = global::Defec8.Properties.Resources.Pause_16x;
            this.tsbPause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPause.Name = "tsbPause";
            this.tsbPause.Size = new System.Drawing.Size(23, 22);
            this.tsbPause.Text = "Прервать";
            // 
            // tsbStop
            // 
            this.tsbStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbStop.Image = global::Defec8.Properties.Resources.Stop_16x;
            this.tsbStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStop.Name = "tsbStop";
            this.tsbStop.Size = new System.Drawing.Size(23, 22);
            this.tsbStop.Text = "Остановить";
            // 
            // tsbStep
            // 
            this.tsbStep.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbStep.Image = global::Defec8.Properties.Resources.StepForward_16x;
            this.tsbStep.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStep.Name = "tsbStep";
            this.tsbStep.Size = new System.Drawing.Size(23, 22);
            this.tsbStep.Text = "Шаг";
            // 
            // pbScreen
            // 
            this.pbScreen.BackColor = System.Drawing.Color.Black;
            this.pbScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbScreen.Location = new System.Drawing.Point(3, 16);
            this.pbScreen.MaximumSize = new System.Drawing.Size(320, 240);
            this.pbScreen.MinimumSize = new System.Drawing.Size(320, 240);
            this.pbScreen.Name = "pbScreen";
            this.pbScreen.Size = new System.Drawing.Size(320, 240);
            this.pbScreen.TabIndex = 5;
            this.pbScreen.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 588);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.msMain);
            this.Controls.Add(this.tbHints);
            this.Controls.Add(this.gbScreen);
            this.Controls.Add(this.tlpMemory);
            this.Controls.Add(this.gbRegisters);
            this.Controls.Add(this.gbCode);
            this.MainMenuStrip = this.msMain;
            this.MinimumSize = new System.Drawing.Size(1247, 627);
            this.Name = "MainForm";
            this.Text = "DEFEC8";
            this.gbCode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctbCode)).EndInit();
            this.gbScreen.ResumeLayout(false);
            this.gbRegisters.ResumeLayout(false);
            this.gbRegisters.PerformLayout();
            this.tlpMemory.ResumeLayout(false);
            this.gbRom.ResumeLayout(false);
            this.gbRam.ResumeLayout(false);
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCode;
        private System.Windows.Forms.GroupBox gbScreen;
        private System.Windows.Forms.PictureBox pbScreen;
        private System.Windows.Forms.GroupBox gbRegisters;
        private System.Windows.Forms.TableLayoutPanel tlpMemory;
        private System.Windows.Forms.GroupBox gbRom;
        private Be.Windows.Forms.HexBox hbRom;
        private System.Windows.Forms.GroupBox gbRam;
        private Be.Windows.Forms.HexBox hbRam;
        private FastColoredTextBoxNS.FastColoredTextBox fctbCode;
        private System.Windows.Forms.TextBox tbRegBx;
        private System.Windows.Forms.TextBox tbRegCx;
        private System.Windows.Forms.TextBox tbRegIp;
        private System.Windows.Forms.Label lRegAx;
        private System.Windows.Forms.TextBox tbRegAx;
        private System.Windows.Forms.CheckBox cbSignFlag;
        private System.Windows.Forms.CheckBox cbZeroFlag;
        private System.Windows.Forms.CheckBox cbParityFlag;
        private System.Windows.Forms.CheckBox cbCarryFlag;
        private System.Windows.Forms.Label lRegBp;
        private System.Windows.Forms.Label lRegSp;
        private System.Windows.Forms.Label lRegDi;
        private System.Windows.Forms.TextBox tbRegDi;
        private System.Windows.Forms.TextBox tbRegSp;
        private System.Windows.Forms.TextBox tbRegBp;
        private System.Windows.Forms.Label lRegSi;
        private System.Windows.Forms.TextBox tbRegSi;
        private System.Windows.Forms.Label lRegIp;
        private System.Windows.Forms.Label lRegCx;
        private System.Windows.Forms.Label lRegBx;
        private System.Windows.Forms.ComboBox cbGpuMode;
        private System.Windows.Forms.Label lGpuMode;
        private System.Windows.Forms.TextBox tbHints;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton tsbUndo;
        private System.Windows.Forms.ToolStripButton tsbRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbStart;
        private System.Windows.Forms.ToolStripButton tsbPause;
        private System.Windows.Forms.ToolStripButton tsbStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbStep;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.TextBox tbMaxOpsPerSecond;
        private System.Windows.Forms.Label lMaxOpsPerSecond;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenAsm;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveAsm;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenRom;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveRom;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
    }
}

