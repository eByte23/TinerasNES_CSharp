namespace TinerasNES
{
    partial class TinerasNES
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStartStopROM = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.openROMToolStripOpenRom = new System.Windows.Forms.ToolStripMenuItem();
            this.openROMToolStripQuickOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileCloseROM = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuAutoStartROM = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeTinerasNESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showHideDebugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoSizeOne = new System.Windows.Forms.ToolStripMenuItem();
            this.videoSizeTwo = new System.Windows.Forms.ToolStripMenuItem();
            this.videoSizeThree = new System.Windows.Forms.ToolStripMenuItem();
            this.videoSizeFullScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.speedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFPSLimit = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStartRom = new System.Windows.Forms.Button();
            this.lblregPC = new System.Windows.Forms.Label();
            this.lblregSP = new System.Windows.Forms.Label();
            this.lblregStatus = new System.Windows.Forms.Label();
            this.lblregA = new System.Windows.Forms.Label();
            this.lblregX = new System.Windows.Forms.Label();
            this.lblregY = new System.Windows.Forms.Label();
            this.lblCPUCycles = new System.Windows.Forms.Label();
            this.lblCPUCyclesOffset = new System.Windows.Forms.Label();
            this.lblSign = new System.Windows.Forms.Label();
            this.lblOverflow = new System.Windows.Forms.Label();
            this.lblBitFive = new System.Windows.Forms.Label();
            this.lblBreak = new System.Windows.Forms.Label();
            this.lblDecimal = new System.Windows.Forms.Label();
            this.lblInterrupt = new System.Windows.Forms.Label();
            this.lblZero = new System.Windows.Forms.Label();
            this.lblCarry = new System.Windows.Forms.Label();
            this.lblSignValue = new System.Windows.Forms.Label();
            this.lblOverflowValue = new System.Windows.Forms.Label();
            this.lblBitFiveValue = new System.Windows.Forms.Label();
            this.lblBreakValue = new System.Windows.Forms.Label();
            this.lblDecimalValue = new System.Windows.Forms.Label();
            this.lblInterruptValue = new System.Windows.Forms.Label();
            this.lblZeroValue = new System.Windows.Forms.Label();
            this.lblCarryValue = new System.Windows.Forms.Label();
            this.lblOpCode = new System.Windows.Forms.Label();
            this.lblByteOne = new System.Windows.Forms.Label();
            this.lblByteTwo = new System.Windows.Forms.Label();
            this.tbxOpCode = new System.Windows.Forms.TextBox();
            this.tbxByteOne = new System.Windows.Forms.TextBox();
            this.tbxByteTwo = new System.Windows.Forms.TextBox();
            this.lblregPCValue = new System.Windows.Forms.Label();
            this.lblregSPValue = new System.Windows.Forms.Label();
            this.lblregAValue = new System.Windows.Forms.Label();
            this.lblregStatusValue = new System.Windows.Forms.Label();
            this.lblCPUCyclesValue = new System.Windows.Forms.Label();
            this.lblregXValue = new System.Windows.Forms.Label();
            this.lblregYValue = new System.Windows.Forms.Label();
            this.lblCPUCyclesOffsetValue = new System.Windows.Forms.Label();
            this.lblNumBytes = new System.Windows.Forms.Label();
            this.lblNumBytesValue = new System.Windows.Forms.Label();
            this.btnVBlankToggle = new System.Windows.Forms.Button();
            this.btnBitmapTest = new System.Windows.Forms.Button();
            this.lbxOpCodes = new System.Windows.Forms.ListBox();
            this.lblTotalInstructions = new System.Windows.Forms.Label();
            this.lblTotalInstructionsValue = new System.Windows.Forms.Label();
            this.lblTotalCpuCycles = new System.Windows.Forms.Label();
            this.lblTotalCpuCyclesValue = new System.Windows.Forms.Label();
            this.cbxStep = new System.Windows.Forms.CheckBox();
            this.cbxDetail = new System.Windows.Forms.CheckBox();
            this.dSearch = new System.DirectoryServices.DirectorySearcher();
            this.btnStatus = new System.Windows.Forms.Button();
            this.cbxNesTest = new System.Windows.Forms.CheckBox();
            this.btnSendToFile = new System.Windows.Forms.Button();
            this.tmrFPS = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.videoToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1483, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStartStopROM,
            this.toolStripSeparator3,
            this.openROMToolStripOpenRom,
            this.openROMToolStripQuickOpen,
            this.menuFileCloseROM,
            this.toolStripSeparator2,
            this.menuAutoStartROM,
            this.toolStripSeparator1,
            this.closeTinerasNESToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menuStartStopROM
            // 
            this.menuStartStopROM.Name = "menuStartStopROM";
            this.menuStartStopROM.Size = new System.Drawing.Size(159, 22);
            this.menuStartStopROM.Text = "Start/Stop ROM";
            this.menuStartStopROM.Click += new System.EventHandler(this.menuStartStopROM_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(156, 6);
            // 
            // openROMToolStripOpenRom
            // 
            this.openROMToolStripOpenRom.Name = "openROMToolStripOpenRom";
            this.openROMToolStripOpenRom.Size = new System.Drawing.Size(159, 22);
            this.openROMToolStripOpenRom.Text = "Open ROM";
            this.openROMToolStripOpenRom.Click += new System.EventHandler(this.openROMToolStripMenuOpenRom_Click);
            // 
            // openROMToolStripQuickOpen
            // 
            this.openROMToolStripQuickOpen.Name = "openROMToolStripQuickOpen";
            this.openROMToolStripQuickOpen.Size = new System.Drawing.Size(159, 22);
            this.openROMToolStripQuickOpen.Text = "Quick Open";
            this.openROMToolStripQuickOpen.Click += new System.EventHandler(this.openROMToolStripQuickOpen_Click);
            // 
            // menuFileCloseROM
            // 
            this.menuFileCloseROM.Name = "menuFileCloseROM";
            this.menuFileCloseROM.Size = new System.Drawing.Size(159, 22);
            this.menuFileCloseROM.Text = "Close ROM";
            this.menuFileCloseROM.Click += new System.EventHandler(this.menuFileCloseROM_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(156, 6);
            // 
            // menuAutoStartROM
            // 
            this.menuAutoStartROM.Checked = true;
            this.menuAutoStartROM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuAutoStartROM.Name = "menuAutoStartROM";
            this.menuAutoStartROM.Size = new System.Drawing.Size(159, 22);
            this.menuAutoStartROM.Text = "Auto-Start ROM";
            this.menuAutoStartROM.Click += new System.EventHandler(this.menuAutoStartROM_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(156, 6);
            // 
            // closeTinerasNESToolStripMenuItem
            // 
            this.closeTinerasNESToolStripMenuItem.Name = "closeTinerasNESToolStripMenuItem";
            this.closeTinerasNESToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.closeTinerasNESToolStripMenuItem.Text = "Exit";
            this.closeTinerasNESToolStripMenuItem.Click += new System.EventHandler(this.closeTinerasNESToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.showHideDebugToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // showHideDebugToolStripMenuItem
            // 
            this.showHideDebugToolStripMenuItem.Name = "showHideDebugToolStripMenuItem";
            this.showHideDebugToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.showHideDebugToolStripMenuItem.Text = "Show/Hide Debug";
            this.showHideDebugToolStripMenuItem.Click += new System.EventHandler(this.showHideDebugToolStripMenuItem_Click);
            // 
            // videoToolStripMenuItem
            // 
            this.videoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sizeToolStripMenuItem,
            this.speedToolStripMenuItem});
            this.videoToolStripMenuItem.Name = "videoToolStripMenuItem";
            this.videoToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.videoToolStripMenuItem.Text = "Video";
            // 
            // sizeToolStripMenuItem
            // 
            this.sizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.videoSizeOne,
            this.videoSizeTwo,
            this.videoSizeThree,
            this.videoSizeFullScreen});
            this.sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
            this.sizeToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.sizeToolStripMenuItem.Text = "Size";
            // 
            // videoSizeOne
            // 
            this.videoSizeOne.Name = "videoSizeOne";
            this.videoSizeOne.Size = new System.Drawing.Size(131, 22);
            this.videoSizeOne.Text = "1";
            this.videoSizeOne.Click += new System.EventHandler(this.videoSizeOne_Click);
            // 
            // videoSizeTwo
            // 
            this.videoSizeTwo.Name = "videoSizeTwo";
            this.videoSizeTwo.Size = new System.Drawing.Size(131, 22);
            this.videoSizeTwo.Text = "2";
            this.videoSizeTwo.Click += new System.EventHandler(this.videoSizeTwo_Click);
            // 
            // videoSizeThree
            // 
            this.videoSizeThree.Name = "videoSizeThree";
            this.videoSizeThree.Size = new System.Drawing.Size(131, 22);
            this.videoSizeThree.Text = "3";
            this.videoSizeThree.Click += new System.EventHandler(this.videoSizeThree_Click);
            // 
            // videoSizeFullScreen
            // 
            this.videoSizeFullScreen.Name = "videoSizeFullScreen";
            this.videoSizeFullScreen.Size = new System.Drawing.Size(131, 22);
            this.videoSizeFullScreen.Text = "Full Screen";
            this.videoSizeFullScreen.Click += new System.EventHandler(this.videoSizeFullScreen_Click);
            // 
            // speedToolStripMenuItem
            // 
            this.speedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFPSLimit});
            this.speedToolStripMenuItem.Name = "speedToolStripMenuItem";
            this.speedToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.speedToolStripMenuItem.Text = "Speed";
            // 
            // menuFPSLimit
            // 
            this.menuFPSLimit.Checked = true;
            this.menuFPSLimit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuFPSLimit.Name = "menuFPSLimit";
            this.menuFPSLimit.Size = new System.Drawing.Size(123, 22);
            this.menuFPSLimit.Text = "FPS Limit";
            this.menuFPSLimit.Click += new System.EventHandler(this.menuFPSLimit_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // btnStartRom
            // 
            this.btnStartRom.Enabled = false;
            this.btnStartRom.Location = new System.Drawing.Point(823, 384);
            this.btnStartRom.Name = "btnStartRom";
            this.btnStartRom.Size = new System.Drawing.Size(89, 23);
            this.btnStartRom.TabIndex = 1;
            this.btnStartRom.Text = "Start Rom";
            this.btnStartRom.UseVisualStyleBackColor = true;
            this.btnStartRom.Visible = false;
            this.btnStartRom.Click += new System.EventHandler(this.btnStartRom_Click);
            // 
            // lblregPC
            // 
            this.lblregPC.AutoSize = true;
            this.lblregPC.Location = new System.Drawing.Point(583, 49);
            this.lblregPC.Name = "lblregPC";
            this.lblregPC.Size = new System.Drawing.Size(86, 13);
            this.lblregPC.TabIndex = 2;
            this.lblregPC.Text = "Program Counter";
            this.lblregPC.Visible = false;
            // 
            // lblregSP
            // 
            this.lblregSP.AutoSize = true;
            this.lblregSP.Location = new System.Drawing.Point(598, 71);
            this.lblregSP.Name = "lblregSP";
            this.lblregSP.Size = new System.Drawing.Size(71, 13);
            this.lblregSP.TabIndex = 2;
            this.lblregSP.Text = "Stack Pointer";
            this.lblregSP.Visible = false;
            // 
            // lblregStatus
            // 
            this.lblregStatus.AutoSize = true;
            this.lblregStatus.Location = new System.Drawing.Point(590, 94);
            this.lblregStatus.Name = "lblregStatus";
            this.lblregStatus.Size = new System.Drawing.Size(79, 13);
            this.lblregStatus.TabIndex = 2;
            this.lblregStatus.Text = "Status Register";
            this.lblregStatus.Visible = false;
            // 
            // lblregA
            // 
            this.lblregA.AutoSize = true;
            this.lblregA.Location = new System.Drawing.Point(603, 117);
            this.lblregA.Name = "lblregA";
            this.lblregA.Size = new System.Drawing.Size(66, 13);
            this.lblregA.TabIndex = 2;
            this.lblregA.Text = "Accumulator";
            this.lblregA.Visible = false;
            // 
            // lblregX
            // 
            this.lblregX.AutoSize = true;
            this.lblregX.Location = new System.Drawing.Point(613, 139);
            this.lblregX.Name = "lblregX";
            this.lblregX.Size = new System.Drawing.Size(56, 13);
            this.lblregX.TabIndex = 2;
            this.lblregX.Text = "X Register";
            this.lblregX.Visible = false;
            // 
            // lblregY
            // 
            this.lblregY.AutoSize = true;
            this.lblregY.Location = new System.Drawing.Point(613, 162);
            this.lblregY.Name = "lblregY";
            this.lblregY.Size = new System.Drawing.Size(56, 13);
            this.lblregY.TabIndex = 2;
            this.lblregY.Text = "Y Register";
            this.lblregY.Visible = false;
            // 
            // lblCPUCycles
            // 
            this.lblCPUCycles.AutoSize = true;
            this.lblCPUCycles.Location = new System.Drawing.Point(564, 186);
            this.lblCPUCycles.Name = "lblCPUCycles";
            this.lblCPUCycles.Size = new System.Drawing.Size(105, 13);
            this.lblCPUCycles.TabIndex = 2;
            this.lblCPUCycles.Text = "OpCode CPU Cycles";
            this.lblCPUCycles.Visible = false;
            // 
            // lblCPUCyclesOffset
            // 
            this.lblCPUCyclesOffset.AutoSize = true;
            this.lblCPUCyclesOffset.Location = new System.Drawing.Point(575, 208);
            this.lblCPUCyclesOffset.Name = "lblCPUCyclesOffset";
            this.lblCPUCyclesOffset.Size = new System.Drawing.Size(94, 13);
            this.lblCPUCyclesOffset.TabIndex = 2;
            this.lblCPUCyclesOffset.Text = "CPU Cycles Offset";
            this.lblCPUCyclesOffset.Visible = false;
            // 
            // lblSign
            // 
            this.lblSign.AutoSize = true;
            this.lblSign.Location = new System.Drawing.Point(946, 486);
            this.lblSign.Name = "lblSign";
            this.lblSign.Size = new System.Drawing.Size(28, 13);
            this.lblSign.TabIndex = 2;
            this.lblSign.Text = "Sign";
            this.lblSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSign.Visible = false;
            // 
            // lblOverflow
            // 
            this.lblOverflow.AutoSize = true;
            this.lblOverflow.Location = new System.Drawing.Point(996, 486);
            this.lblOverflow.Name = "lblOverflow";
            this.lblOverflow.Size = new System.Drawing.Size(49, 13);
            this.lblOverflow.TabIndex = 2;
            this.lblOverflow.Text = "Overflow";
            this.lblOverflow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOverflow.Visible = false;
            // 
            // lblBitFive
            // 
            this.lblBitFive.AutoSize = true;
            this.lblBitFive.Location = new System.Drawing.Point(1054, 486);
            this.lblBitFive.Name = "lblBitFive";
            this.lblBitFive.Size = new System.Drawing.Size(39, 13);
            this.lblBitFive.TabIndex = 2;
            this.lblBitFive.Text = "BitFive";
            this.lblBitFive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBitFive.Visible = false;
            // 
            // lblBreak
            // 
            this.lblBreak.AutoSize = true;
            this.lblBreak.Location = new System.Drawing.Point(1109, 486);
            this.lblBreak.Name = "lblBreak";
            this.lblBreak.Size = new System.Drawing.Size(35, 13);
            this.lblBreak.TabIndex = 2;
            this.lblBreak.Text = "Break";
            this.lblBreak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBreak.Visible = false;
            // 
            // lblDecimal
            // 
            this.lblDecimal.AutoSize = true;
            this.lblDecimal.Location = new System.Drawing.Point(1165, 485);
            this.lblDecimal.Name = "lblDecimal";
            this.lblDecimal.Size = new System.Drawing.Size(45, 13);
            this.lblDecimal.TabIndex = 2;
            this.lblDecimal.Text = "Decimal";
            this.lblDecimal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDecimal.Visible = false;
            // 
            // lblInterrupt
            // 
            this.lblInterrupt.AutoSize = true;
            this.lblInterrupt.Location = new System.Drawing.Point(1227, 486);
            this.lblInterrupt.Name = "lblInterrupt";
            this.lblInterrupt.Size = new System.Drawing.Size(46, 13);
            this.lblInterrupt.TabIndex = 2;
            this.lblInterrupt.Text = "Interrupt";
            this.lblInterrupt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInterrupt.Visible = false;
            // 
            // lblZero
            // 
            this.lblZero.AutoSize = true;
            this.lblZero.Location = new System.Drawing.Point(1292, 486);
            this.lblZero.Name = "lblZero";
            this.lblZero.Size = new System.Drawing.Size(29, 13);
            this.lblZero.TabIndex = 2;
            this.lblZero.Text = "Zero";
            this.lblZero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblZero.Visible = false;
            // 
            // lblCarry
            // 
            this.lblCarry.AutoSize = true;
            this.lblCarry.Location = new System.Drawing.Point(1349, 486);
            this.lblCarry.Name = "lblCarry";
            this.lblCarry.Size = new System.Drawing.Size(31, 13);
            this.lblCarry.TabIndex = 2;
            this.lblCarry.Text = "Carry";
            this.lblCarry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCarry.Visible = false;
            // 
            // lblSignValue
            // 
            this.lblSignValue.AutoSize = true;
            this.lblSignValue.Location = new System.Drawing.Point(946, 514);
            this.lblSignValue.Name = "lblSignValue";
            this.lblSignValue.Size = new System.Drawing.Size(29, 13);
            this.lblSignValue.TabIndex = 2;
            this.lblSignValue.Text = "false";
            this.lblSignValue.Visible = false;
            // 
            // lblOverflowValue
            // 
            this.lblOverflowValue.AutoSize = true;
            this.lblOverflowValue.Location = new System.Drawing.Point(1004, 514);
            this.lblOverflowValue.Name = "lblOverflowValue";
            this.lblOverflowValue.Size = new System.Drawing.Size(29, 13);
            this.lblOverflowValue.TabIndex = 2;
            this.lblOverflowValue.Text = "false";
            this.lblOverflowValue.Visible = false;
            // 
            // lblBitFiveValue
            // 
            this.lblBitFiveValue.AutoSize = true;
            this.lblBitFiveValue.Location = new System.Drawing.Point(1058, 514);
            this.lblBitFiveValue.Name = "lblBitFiveValue";
            this.lblBitFiveValue.Size = new System.Drawing.Size(29, 13);
            this.lblBitFiveValue.TabIndex = 2;
            this.lblBitFiveValue.Text = "false";
            this.lblBitFiveValue.Visible = false;
            // 
            // lblBreakValue
            // 
            this.lblBreakValue.AutoSize = true;
            this.lblBreakValue.Location = new System.Drawing.Point(1112, 514);
            this.lblBreakValue.Name = "lblBreakValue";
            this.lblBreakValue.Size = new System.Drawing.Size(29, 13);
            this.lblBreakValue.TabIndex = 2;
            this.lblBreakValue.Text = "false";
            this.lblBreakValue.Visible = false;
            // 
            // lblDecimalValue
            // 
            this.lblDecimalValue.AutoSize = true;
            this.lblDecimalValue.Location = new System.Drawing.Point(1173, 514);
            this.lblDecimalValue.Name = "lblDecimalValue";
            this.lblDecimalValue.Size = new System.Drawing.Size(29, 13);
            this.lblDecimalValue.TabIndex = 2;
            this.lblDecimalValue.Text = "false";
            this.lblDecimalValue.Visible = false;
            // 
            // lblInterruptValue
            // 
            this.lblInterruptValue.AutoSize = true;
            this.lblInterruptValue.Location = new System.Drawing.Point(1234, 514);
            this.lblInterruptValue.Name = "lblInterruptValue";
            this.lblInterruptValue.Size = new System.Drawing.Size(29, 13);
            this.lblInterruptValue.TabIndex = 2;
            this.lblInterruptValue.Text = "false";
            this.lblInterruptValue.Visible = false;
            // 
            // lblZeroValue
            // 
            this.lblZeroValue.AutoSize = true;
            this.lblZeroValue.Location = new System.Drawing.Point(1292, 514);
            this.lblZeroValue.Name = "lblZeroValue";
            this.lblZeroValue.Size = new System.Drawing.Size(29, 13);
            this.lblZeroValue.TabIndex = 2;
            this.lblZeroValue.Text = "false";
            this.lblZeroValue.Visible = false;
            // 
            // lblCarryValue
            // 
            this.lblCarryValue.AutoSize = true;
            this.lblCarryValue.Location = new System.Drawing.Point(1349, 514);
            this.lblCarryValue.Name = "lblCarryValue";
            this.lblCarryValue.Size = new System.Drawing.Size(29, 13);
            this.lblCarryValue.TabIndex = 2;
            this.lblCarryValue.Text = "false";
            this.lblCarryValue.Visible = false;
            // 
            // lblOpCode
            // 
            this.lblOpCode.AutoSize = true;
            this.lblOpCode.Location = new System.Drawing.Point(1398, 486);
            this.lblOpCode.Name = "lblOpCode";
            this.lblOpCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblOpCode.Size = new System.Drawing.Size(46, 13);
            this.lblOpCode.TabIndex = 2;
            this.lblOpCode.Text = "OpCode";
            this.lblOpCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblOpCode.Visible = false;
            // 
            // lblByteOne
            // 
            this.lblByteOne.AutoSize = true;
            this.lblByteOne.Location = new System.Drawing.Point(1397, 508);
            this.lblByteOne.Name = "lblByteOne";
            this.lblByteOne.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblByteOne.Size = new System.Drawing.Size(48, 13);
            this.lblByteOne.TabIndex = 2;
            this.lblByteOne.Text = "ByteOne";
            this.lblByteOne.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblByteOne.Visible = false;
            // 
            // lblByteTwo
            // 
            this.lblByteTwo.AutoSize = true;
            this.lblByteTwo.Location = new System.Drawing.Point(1397, 531);
            this.lblByteTwo.Name = "lblByteTwo";
            this.lblByteTwo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblByteTwo.Size = new System.Drawing.Size(49, 13);
            this.lblByteTwo.TabIndex = 2;
            this.lblByteTwo.Text = "ByteTwo";
            this.lblByteTwo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblByteTwo.Visible = false;
            // 
            // tbxOpCode
            // 
            this.tbxOpCode.Enabled = false;
            this.tbxOpCode.Location = new System.Drawing.Point(1451, 483);
            this.tbxOpCode.Name = "tbxOpCode";
            this.tbxOpCode.Size = new System.Drawing.Size(100, 20);
            this.tbxOpCode.TabIndex = 3;
            this.tbxOpCode.Text = "38";
            this.tbxOpCode.Visible = false;
            // 
            // tbxByteOne
            // 
            this.tbxByteOne.Enabled = false;
            this.tbxByteOne.Location = new System.Drawing.Point(1451, 505);
            this.tbxByteOne.Name = "tbxByteOne";
            this.tbxByteOne.Size = new System.Drawing.Size(100, 20);
            this.tbxByteOne.TabIndex = 3;
            this.tbxByteOne.Text = "0";
            this.tbxByteOne.Visible = false;
            // 
            // tbxByteTwo
            // 
            this.tbxByteTwo.Enabled = false;
            this.tbxByteTwo.Location = new System.Drawing.Point(1451, 528);
            this.tbxByteTwo.Name = "tbxByteTwo";
            this.tbxByteTwo.Size = new System.Drawing.Size(100, 20);
            this.tbxByteTwo.TabIndex = 3;
            this.tbxByteTwo.Text = "0";
            this.tbxByteTwo.Visible = false;
            // 
            // lblregPCValue
            // 
            this.lblregPCValue.AutoSize = true;
            this.lblregPCValue.Location = new System.Drawing.Point(724, 49);
            this.lblregPCValue.Name = "lblregPCValue";
            this.lblregPCValue.Size = new System.Drawing.Size(55, 13);
            this.lblregPCValue.TabIndex = 2;
            this.lblregPCValue.Text = "00000000";
            this.lblregPCValue.Visible = false;
            // 
            // lblregSPValue
            // 
            this.lblregSPValue.AutoSize = true;
            this.lblregSPValue.Location = new System.Drawing.Point(724, 71);
            this.lblregSPValue.Name = "lblregSPValue";
            this.lblregSPValue.Size = new System.Drawing.Size(55, 13);
            this.lblregSPValue.TabIndex = 2;
            this.lblregSPValue.Text = "00000000";
            this.lblregSPValue.Visible = false;
            // 
            // lblregAValue
            // 
            this.lblregAValue.AutoSize = true;
            this.lblregAValue.Location = new System.Drawing.Point(724, 117);
            this.lblregAValue.Name = "lblregAValue";
            this.lblregAValue.Size = new System.Drawing.Size(55, 13);
            this.lblregAValue.TabIndex = 2;
            this.lblregAValue.Text = "00000000";
            this.lblregAValue.Visible = false;
            // 
            // lblregStatusValue
            // 
            this.lblregStatusValue.AutoSize = true;
            this.lblregStatusValue.Location = new System.Drawing.Point(724, 94);
            this.lblregStatusValue.Name = "lblregStatusValue";
            this.lblregStatusValue.Size = new System.Drawing.Size(55, 13);
            this.lblregStatusValue.TabIndex = 2;
            this.lblregStatusValue.Text = "00000000";
            this.lblregStatusValue.Visible = false;
            // 
            // lblCPUCyclesValue
            // 
            this.lblCPUCyclesValue.AutoSize = true;
            this.lblCPUCyclesValue.Location = new System.Drawing.Point(724, 186);
            this.lblCPUCyclesValue.Name = "lblCPUCyclesValue";
            this.lblCPUCyclesValue.Size = new System.Drawing.Size(55, 13);
            this.lblCPUCyclesValue.TabIndex = 2;
            this.lblCPUCyclesValue.Text = "00000000";
            this.lblCPUCyclesValue.Visible = false;
            // 
            // lblregXValue
            // 
            this.lblregXValue.AutoSize = true;
            this.lblregXValue.Location = new System.Drawing.Point(724, 139);
            this.lblregXValue.Name = "lblregXValue";
            this.lblregXValue.Size = new System.Drawing.Size(55, 13);
            this.lblregXValue.TabIndex = 2;
            this.lblregXValue.Text = "00000000";
            this.lblregXValue.Visible = false;
            // 
            // lblregYValue
            // 
            this.lblregYValue.AutoSize = true;
            this.lblregYValue.Location = new System.Drawing.Point(724, 162);
            this.lblregYValue.Name = "lblregYValue";
            this.lblregYValue.Size = new System.Drawing.Size(55, 13);
            this.lblregYValue.TabIndex = 2;
            this.lblregYValue.Text = "00000000";
            this.lblregYValue.Visible = false;
            // 
            // lblCPUCyclesOffsetValue
            // 
            this.lblCPUCyclesOffsetValue.AutoSize = true;
            this.lblCPUCyclesOffsetValue.Location = new System.Drawing.Point(724, 208);
            this.lblCPUCyclesOffsetValue.Name = "lblCPUCyclesOffsetValue";
            this.lblCPUCyclesOffsetValue.Size = new System.Drawing.Size(55, 13);
            this.lblCPUCyclesOffsetValue.TabIndex = 2;
            this.lblCPUCyclesOffsetValue.Text = "00000000";
            this.lblCPUCyclesOffsetValue.Visible = false;
            // 
            // lblNumBytes
            // 
            this.lblNumBytes.AutoSize = true;
            this.lblNumBytes.Location = new System.Drawing.Point(542, 251);
            this.lblNumBytes.Name = "lblNumBytes";
            this.lblNumBytes.Size = new System.Drawing.Size(126, 13);
            this.lblNumBytes.TabIndex = 2;
            this.lblNumBytes.Text = "Total OpCodes Executed";
            this.lblNumBytes.Visible = false;
            // 
            // lblNumBytesValue
            // 
            this.lblNumBytesValue.AutoSize = true;
            this.lblNumBytesValue.Location = new System.Drawing.Point(724, 251);
            this.lblNumBytesValue.Name = "lblNumBytesValue";
            this.lblNumBytesValue.Size = new System.Drawing.Size(55, 13);
            this.lblNumBytesValue.TabIndex = 2;
            this.lblNumBytesValue.Text = "00000000";
            this.lblNumBytesValue.Visible = false;
            // 
            // btnVBlankToggle
            // 
            this.btnVBlankToggle.Location = new System.Drawing.Point(823, 413);
            this.btnVBlankToggle.Name = "btnVBlankToggle";
            this.btnVBlankToggle.Size = new System.Drawing.Size(89, 23);
            this.btnVBlankToggle.TabIndex = 5;
            this.btnVBlankToggle.Text = "VBLANK";
            this.btnVBlankToggle.UseVisualStyleBackColor = true;
            this.btnVBlankToggle.Visible = false;
            this.btnVBlankToggle.Click += new System.EventHandler(this.btnVBlankToggle_Click);
            // 
            // btnBitmapTest
            // 
            this.btnBitmapTest.Location = new System.Drawing.Point(823, 355);
            this.btnBitmapTest.Name = "btnBitmapTest";
            this.btnBitmapTest.Size = new System.Drawing.Size(89, 23);
            this.btnBitmapTest.TabIndex = 6;
            this.btnBitmapTest.Text = "BMP Test";
            this.btnBitmapTest.UseVisualStyleBackColor = true;
            this.btnBitmapTest.Visible = false;
            this.btnBitmapTest.Click += new System.EventHandler(this.btnBitmapTest_Click);
            // 
            // lbxOpCodes
            // 
            this.lbxOpCodes.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxOpCodes.FormattingEnabled = true;
            this.lbxOpCodes.ItemHeight = 12;
            this.lbxOpCodes.Location = new System.Drawing.Point(934, 34);
            this.lbxOpCodes.Name = "lbxOpCodes";
            this.lbxOpCodes.Size = new System.Drawing.Size(537, 844);
            this.lbxOpCodes.TabIndex = 7;
            this.lbxOpCodes.Visible = false;
            // 
            // lblTotalInstructions
            // 
            this.lblTotalInstructions.AutoSize = true;
            this.lblTotalInstructions.Location = new System.Drawing.Point(824, 450);
            this.lblTotalInstructions.Name = "lblTotalInstructions";
            this.lblTotalInstructions.Size = new System.Drawing.Size(88, 13);
            this.lblTotalInstructions.TabIndex = 8;
            this.lblTotalInstructions.Text = "Total Instructions";
            this.lblTotalInstructions.Visible = false;
            // 
            // lblTotalInstructionsValue
            // 
            this.lblTotalInstructionsValue.AutoSize = true;
            this.lblTotalInstructionsValue.Location = new System.Drawing.Point(824, 473);
            this.lblTotalInstructionsValue.Name = "lblTotalInstructionsValue";
            this.lblTotalInstructionsValue.Size = new System.Drawing.Size(13, 13);
            this.lblTotalInstructionsValue.TabIndex = 8;
            this.lblTotalInstructionsValue.Text = "0";
            this.lblTotalInstructionsValue.Visible = false;
            // 
            // lblTotalCpuCycles
            // 
            this.lblTotalCpuCycles.AutoSize = true;
            this.lblTotalCpuCycles.Location = new System.Drawing.Point(579, 230);
            this.lblTotalCpuCycles.Name = "lblTotalCpuCycles";
            this.lblTotalCpuCycles.Size = new System.Drawing.Size(90, 13);
            this.lblTotalCpuCycles.TabIndex = 2;
            this.lblTotalCpuCycles.Text = "Total CPU Cycles";
            this.lblTotalCpuCycles.Visible = false;
            // 
            // lblTotalCpuCyclesValue
            // 
            this.lblTotalCpuCyclesValue.AutoSize = true;
            this.lblTotalCpuCyclesValue.Location = new System.Drawing.Point(724, 230);
            this.lblTotalCpuCyclesValue.Name = "lblTotalCpuCyclesValue";
            this.lblTotalCpuCyclesValue.Size = new System.Drawing.Size(55, 13);
            this.lblTotalCpuCyclesValue.TabIndex = 2;
            this.lblTotalCpuCyclesValue.Text = "00000000";
            this.lblTotalCpuCyclesValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblTotalCpuCyclesValue.Visible = false;
            // 
            // cbxStep
            // 
            this.cbxStep.AutoSize = true;
            this.cbxStep.Location = new System.Drawing.Point(827, 502);
            this.cbxStep.Name = "cbxStep";
            this.cbxStep.Size = new System.Drawing.Size(100, 17);
            this.cbxStep.TabIndex = 9;
            this.cbxStep.Text = "Enable Logging";
            this.cbxStep.UseVisualStyleBackColor = true;
            this.cbxStep.Visible = false;
            // 
            // cbxDetail
            // 
            this.cbxDetail.AutoSize = true;
            this.cbxDetail.Location = new System.Drawing.Point(827, 526);
            this.cbxDetail.Name = "cbxDetail";
            this.cbxDetail.Size = new System.Drawing.Size(89, 17);
            this.cbxDetail.TabIndex = 10;
            this.cbxDetail.Text = "Enable Detail";
            this.cbxDetail.UseVisualStyleBackColor = true;
            this.cbxDetail.Visible = false;
            // 
            // dSearch
            // 
            this.dSearch.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.dSearch.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.dSearch.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // btnStatus
            // 
            this.btnStatus.BackColor = System.Drawing.Color.Red;
            this.btnStatus.Enabled = false;
            this.btnStatus.Location = new System.Drawing.Point(795, 384);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(22, 23);
            this.btnStatus.TabIndex = 11;
            this.btnStatus.UseVisualStyleBackColor = false;
            this.btnStatus.Visible = false;
            // 
            // cbxNesTest
            // 
            this.cbxNesTest.AutoSize = true;
            this.cbxNesTest.Location = new System.Drawing.Point(827, 550);
            this.cbxNesTest.Name = "cbxNesTest";
            this.cbxNesTest.Size = new System.Drawing.Size(102, 17);
            this.cbxNesTest.TabIndex = 12;
            this.cbxNesTest.Text = "Enable NesTest";
            this.cbxNesTest.UseVisualStyleBackColor = true;
            this.cbxNesTest.Visible = false;
            // 
            // btnSendToFile
            // 
            this.btnSendToFile.Location = new System.Drawing.Point(823, 305);
            this.btnSendToFile.Name = "btnSendToFile";
            this.btnSendToFile.Size = new System.Drawing.Size(89, 23);
            this.btnSendToFile.TabIndex = 13;
            this.btnSendToFile.Text = "Send To File";
            this.btnSendToFile.UseVisualStyleBackColor = true;
            this.btnSendToFile.Visible = false;
            this.btnSendToFile.Click += new System.EventHandler(this.btnSendToFile_Click);
            // 
            // tmrFPS
            // 
            this.tmrFPS.Enabled = true;
            this.tmrFPS.Interval = 1000;
            this.tmrFPS.Tick += new System.EventHandler(this.tmrFPS_Tick);
            // 
            // TinerasNES
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 899);
            this.Controls.Add(this.btnSendToFile);
            this.Controls.Add(this.cbxNesTest);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.cbxDetail);
            this.Controls.Add(this.cbxStep);
            this.Controls.Add(this.lblTotalInstructionsValue);
            this.Controls.Add(this.lblTotalInstructions);
            this.Controls.Add(this.lbxOpCodes);
            this.Controls.Add(this.btnBitmapTest);
            this.Controls.Add(this.btnVBlankToggle);
            this.Controls.Add(this.tbxByteTwo);
            this.Controls.Add(this.tbxByteOne);
            this.Controls.Add(this.tbxOpCode);
            this.Controls.Add(this.lblCarryValue);
            this.Controls.Add(this.lblZeroValue);
            this.Controls.Add(this.lblCarry);
            this.Controls.Add(this.lblInterruptValue);
            this.Controls.Add(this.lblZero);
            this.Controls.Add(this.lblDecimalValue);
            this.Controls.Add(this.lblInterrupt);
            this.Controls.Add(this.lblBreakValue);
            this.Controls.Add(this.lblDecimal);
            this.Controls.Add(this.lblBitFiveValue);
            this.Controls.Add(this.lblBreak);
            this.Controls.Add(this.lblOverflowValue);
            this.Controls.Add(this.lblBitFive);
            this.Controls.Add(this.lblSignValue);
            this.Controls.Add(this.lblOverflow);
            this.Controls.Add(this.lblSign);
            this.Controls.Add(this.lblTotalCpuCyclesValue);
            this.Controls.Add(this.lblNumBytesValue);
            this.Controls.Add(this.lblCPUCyclesOffsetValue);
            this.Controls.Add(this.lblTotalCpuCycles);
            this.Controls.Add(this.lblregYValue);
            this.Controls.Add(this.lblNumBytes);
            this.Controls.Add(this.lblCPUCyclesOffset);
            this.Controls.Add(this.lblregXValue);
            this.Controls.Add(this.lblregY);
            this.Controls.Add(this.lblCPUCyclesValue);
            this.Controls.Add(this.lblregX);
            this.Controls.Add(this.lblCPUCycles);
            this.Controls.Add(this.lblregStatusValue);
            this.Controls.Add(this.lblByteTwo);
            this.Controls.Add(this.lblregStatus);
            this.Controls.Add(this.lblregAValue);
            this.Controls.Add(this.lblByteOne);
            this.Controls.Add(this.lblregA);
            this.Controls.Add(this.lblregSPValue);
            this.Controls.Add(this.lblOpCode);
            this.Controls.Add(this.lblregPCValue);
            this.Controls.Add(this.lblregSP);
            this.Controls.Add(this.lblregPC);
            this.Controls.Add(this.btnStartRom);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TinerasNES";
            this.Text = "TinerasNES";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragToOpenFile);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnterEvent);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TinerasNES_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TinerasNES_KeyUp);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TinerasNES_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openROMToolStripQuickOpen;
        private System.Windows.Forms.ToolStripMenuItem closeTinerasNESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.Button btnStartRom;
        private System.Windows.Forms.Label lblregPC;
        private System.Windows.Forms.Label lblregSP;
        private System.Windows.Forms.Label lblregStatus;
        private System.Windows.Forms.Label lblregA;
        private System.Windows.Forms.Label lblregX;
        private System.Windows.Forms.Label lblregY;
        private System.Windows.Forms.Label lblCPUCycles;
        private System.Windows.Forms.Label lblCPUCyclesOffset;
        private System.Windows.Forms.Label lblSign;
        private System.Windows.Forms.Label lblOverflow;
        private System.Windows.Forms.Label lblBitFive;
        private System.Windows.Forms.Label lblBreak;
        private System.Windows.Forms.Label lblDecimal;
        private System.Windows.Forms.Label lblInterrupt;
        private System.Windows.Forms.Label lblZero;
        private System.Windows.Forms.Label lblCarry;
        private System.Windows.Forms.Label lblSignValue;
        private System.Windows.Forms.Label lblOverflowValue;
        private System.Windows.Forms.Label lblBitFiveValue;
        private System.Windows.Forms.Label lblBreakValue;
        private System.Windows.Forms.Label lblDecimalValue;
        private System.Windows.Forms.Label lblInterruptValue;
        private System.Windows.Forms.Label lblZeroValue;
        private System.Windows.Forms.Label lblCarryValue;
        private System.Windows.Forms.Label lblOpCode;
        private System.Windows.Forms.Label lblByteOne;
        private System.Windows.Forms.Label lblByteTwo;
        private System.Windows.Forms.TextBox tbxOpCode;
        private System.Windows.Forms.TextBox tbxByteOne;
        private System.Windows.Forms.TextBox tbxByteTwo;
        private System.Windows.Forms.Label lblregPCValue;
        private System.Windows.Forms.Label lblregSPValue;
        private System.Windows.Forms.Label lblregAValue;
        private System.Windows.Forms.Label lblregStatusValue;
        private System.Windows.Forms.Label lblCPUCyclesValue;
        private System.Windows.Forms.Label lblregXValue;
        private System.Windows.Forms.Label lblregYValue;
        private System.Windows.Forms.Label lblCPUCyclesOffsetValue;
        private System.Windows.Forms.Label lblNumBytes;
        private System.Windows.Forms.Label lblNumBytesValue;
        private System.Windows.Forms.ToolStripMenuItem showHideDebugToolStripMenuItem;
        private System.Windows.Forms.Button btnVBlankToggle;
        private System.Windows.Forms.Button btnBitmapTest;
        private System.Windows.Forms.ListBox lbxOpCodes;
        private System.Windows.Forms.Label lblTotalInstructions;
        private System.Windows.Forms.Label lblTotalInstructionsValue;
        private System.Windows.Forms.Label lblTotalCpuCycles;
        private System.Windows.Forms.Label lblTotalCpuCyclesValue;
        private System.Windows.Forms.CheckBox cbxStep;
        private System.Windows.Forms.CheckBox cbxDetail;
        private System.DirectoryServices.DirectorySearcher dSearch;
        private System.Windows.Forms.ToolStripMenuItem openROMToolStripOpenRom;
        private System.Windows.Forms.ToolStripMenuItem videoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem videoSizeOne;
        private System.Windows.Forms.ToolStripMenuItem videoSizeTwo;
        private System.Windows.Forms.ToolStripMenuItem videoSizeThree;
        private System.Windows.Forms.ToolStripMenuItem videoSizeFullScreen;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.CheckBox cbxNesTest;
        private System.Windows.Forms.Button btnSendToFile;
        public System.Windows.Forms.Timer tmrFPS;
        private System.Windows.Forms.ToolStripMenuItem speedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuFPSLimit;
        private System.Windows.Forms.ToolStripMenuItem menuFileCloseROM;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuAutoStartROM;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuStartStopROM;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

