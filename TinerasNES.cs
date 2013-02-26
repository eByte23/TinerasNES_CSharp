using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Build.Tasks;

namespace TinerasNES
{
    public partial class TinerasNES : Form
    {
        #region Create new classes and Panel Game Object
        FileStream fsOpenRom;
        Registers registers;
        MemoryMap memory;
        Mappers mappers;
        CPU cpu;
        GameRender gameRender;
        Input input;
        PPU ppu;
        public Panel pnlGame;

        VisualDebugger vdb;

        Size sizeBorderOffset;
        #endregion

        #region Global/Local Variables
        string strFileLocation;
        public bool bolRunGame;
        int intTotalInstrucions;
        //bool bolEnableDebugStepping;
        public bool bolStartFrame, bolReset = true;
        string strDebug;
        string[] strDebugFull;
        int intFPS = 0;
        int intCurrentSize = 2;
        int intMaxCPUCycles = 29780 * 15;// 29780
        public int tsMaster;
        public int tsCpuNTSC;
        public int tsCpuPAL;
        public int tsPpu;
        public int cntScanline = -2;
        public int cntScanlineCycle;
        public int VBlankTime = 20 * 341 * 5; // 20 Scanlines, 340 Pixels Per Scanline, 5 PPU Timestamp Cycles
        public byte MapperNumber;
        public bool rendering = false;

        int debugLinesToWrite = 0;
        int debugLinesMax = 25000;

        //Gets Program Counter Value before executing next OpCode
        //int intPreviousPCValue;
        #endregion

        public void runGame()
        {
            // Main Program Loop
            if (bolRunGame && !cpu.badOpCode)
            {   
                // Execute OpCodes Here and Store Previous OpCode
                if (cpu.intTotalCpuCycles < intMaxCPUCycles) // Approx. 29780
                {
                    // Print DEBUG info to the listbox
                    showDebug();
                    
                    // Increment 
                    // intTotalInstrucions++;

                    // Execute Opcode
                    cpu.execOpCode();

                    // Render Pixels
                    ppu.RunPPU(cpu.intTotalCpuCycles);

                    //if(registers.re
                }

                // Stuff to do after each frame has been rendered
                if (/* cpu.intTotalCpuCycles >= intMaxCPUCycles || */ ppu.bolReadyToRender)
                {
                    // Draw Frame
                    gameRender.WriteBitmap(ppu.byteBGFrame, ppu.BGColor);

                    // Reset ReadyToRender flag
                    ppu.bolReadyToRender = false;

                    // Render nametable when in debug mode
                    if (ppu.bolDrawNameTable && (ppu.NTDebugOffset % 10 == 0))
                    {
                        vdb.vd.WriteBitmap(ppu.byteNT0, ppu.byteNT1, ppu.byteNT2, ppu.byteNT3, ppu.BGColor);
                    }

                    // Reset the TotalCpuCycles and PPU cycle counter
                    cpu.intTotalCpuCycles = 0;
                    tsPpu = 0;

                    // Increment FPS Counter on each rendered frame for evaluation in tmrFPS_Tick()
                    intFPS++;
                }
            }
            else
            {
                // btnStatus.BackColor = Color.Red;
            }            
        }

        public void showDebug()
        {
            // Show individual stepping
            if (cbxStep.CheckState == CheckState.Checked)
            {
                // NesTest Format to compare to gold log
                strDebug = String.Format("{0:x4}", registers.regPC).ToUpper() + "  " +
                     String.Format("{0:x2}", memory.memCPU[registers.regPC]).ToUpper() + /*"  " +
                     String.Format("{0:x2}", memory.memCPU[registers.regPC + 1]).ToUpper() + "  " +
                     String.Format("{0:x2}", memory.memCPU[registers.regPC + 2]).ToUpper() + */"     A:" +
                     String.Format("{0:x2}", Convert.ToInt16(registers.regA)).ToUpper() + "   X:" +
                     String.Format("{0:x2}", Convert.ToInt16(registers.regX)).ToUpper() + "   Y:" +
                     String.Format("{0:x2}", Convert.ToInt16(registers.regY)).ToUpper() + "   P:" +
                     String.Format("{0:x2}", registers.regStatus).ToUpper() + "   SP:" +
                     String.Format("{0:x2}", registers.regSP).ToUpper();



                //char[] p = new char[8];

                //p[0] = registers.statusCarry ? 'C' : 'c';
                //p[1] = registers.statusZero ? 'Z' : 'z';
                //p[2] = registers.statusInterrupt ? 'I' : 'i';
                //p[3] = registers.statusDecimal ? 'D' : 'd';
                //p[4] = registers.statusBreak ? 'B' : 'b';
                //p[5] = registers.statusBitFive ? 'U' : 'u';
                //p[6] = registers.statusOverflow ? 'V' : 'v';
                //p[7] = registers.statusNegative ? 'N' : 'n';

                //// FCEUX Format
                //strDebug = "$" + String.Format("{0:x4}", registers.regPC).ToUpper() + ":" +
                //     String.Format("{0:x2}", memory.memCPU[registers.regPC]).ToUpper() +
                //     //String.Format("{0:x2}", memory.memCPU[registers.regPC + 1]).ToUpper() + "  " +
                //     /*String.Format("{0:x2}", memory.memCPU[registers.regPC + 2]).ToUpper() + */" A:" +
                //     String.Format("{0:x2}", Convert.ToInt16(registers.regA)).ToUpper() + " X:" +
                //     String.Format("{0:x2}", Convert.ToInt16(registers.regX)).ToUpper() + " Y:" +
                //     String.Format("{0:x2}", Convert.ToInt16(registers.regY)).ToUpper() + /*"   P:" +
                //     String.Format("{0:x2}", registers.regStatus).ToUpper() + */" S:" +
                //     String.Format("{0:x2}", registers.regSP).ToUpper() + " P:" +
                //     p[7] + p[6] + p[5] + p[4] + p[3] + p[2] + p[1] + p[0];

                lbxOpCodes.Items.Add(strDebug);
                if (debugLinesToWrite++ < debugLinesMax)
                {
                    strDebugFull[intTotalInstrucions] += strDebug + "\n";
                }
                else
                {
                    debugLinesToWrite = debugLinesMax + 1;

                    cbxStep.CheckState = CheckState.Unchecked;
                }
            }

            // Show debug detail (registers, flags, etc.)
            if (cbxDetail.CheckState == CheckState.Checked)
            {
                // Write Hex, Bin, Dec value to screen for debugging
                lblregPCValue.Text = "Hex: " + String.Format("{0:x4}", registers.regPC) + /*"  |  Bin: " + returnBinaryString(registers.regPC) +*/ "  |  Dec: " + String.Format("{0:00}", registers.regPC);
                lblregSPValue.Text = "Hex: " + String.Format("{0:x4}", registers.regSP) + /*"  |  Bin: " + returnBinaryString(registers.regSP) +*/ "  |  Dec: " + String.Format("{0:00}", registers.regSP);
                lblregStatusValue.Text = "Hex: " + String.Format("{0:x2}", registers.regStatus) + "  |  Bin: " + returnBinaryString(registers.regStatus) + "  |  Dec: " + String.Format("{0:00}", registers.regStatus);
                lblregAValue.Text = "Hex: " + String.Format("{0:x2}", Convert.ToInt16(registers.regA)) + "  |  Bin: " + returnBinaryString(Convert.ToInt16(registers.regA)) + "  |  Dec: " + String.Format("{0:00}", Convert.ToInt16(registers.regA));
                lblregXValue.Text = "Hex: " + String.Format("{0:x2}", Convert.ToInt16(registers.regX)) + "  |  Bin: " + returnBinaryString(Convert.ToInt16(registers.regX)) + "  |  Dec: " + String.Format("{0:00}", Convert.ToInt16(registers.regX));
                lblregYValue.Text = "Hex: " + String.Format("{0:x2}", Convert.ToInt16(registers.regY)) + "  |  Bin: " + returnBinaryString(Convert.ToInt16(registers.regY)) + "  |  Dec: " + String.Format("{0:00}", Convert.ToInt16(registers.regY));
                lblCPUCyclesValue.Text = Convert.ToString(cpu.intCpuCycles, 10);

                //lblCPUCyclesOffsetValue.Text = Convert.ToString(opcodes.intCpuCyclesOffset, 10);
                //lblTotalCpuCyclesValue.Text = Convert.ToString(opcodes.intTotalCpuCycles, 10);
                lblNumBytesValue.Text = Convert.ToString(intTotalInstrucions);//Convert.ToString((registers.regPC - intPreviousPCValue), 10);

                // Write Status Bit Registers (T/F) to screen for debugging
                lblCarryValue.Text = Convert.ToString(registers.statusCarry);
                lblZeroValue.Text = Convert.ToString(registers.statusZero);
                lblInterruptValue.Text = Convert.ToString(registers.statusInterrupt);
                lblDecimalValue.Text = Convert.ToString(registers.statusDecimal);
                lblBreakValue.Text = Convert.ToString(registers.statusBreak);
                lblBitFiveValue.Text = Convert.ToString(registers.statusBitFive);
                lblOverflowValue.Text = Convert.ToString(registers.statusOverflow);
                lblSignValue.Text = Convert.ToString(registers.statusNegative);

                tbxOpCode.Text = String.Format("{0:x4}", memory.memCPU[registers.regPC]);
                tbxByteOne.Text = String.Format("{0:x4}", memory.memCPU[registers.regPC + 1]);
                tbxByteTwo.Text = String.Format("{0:x4}", memory.memCPU[registers.regPC + 2]);


                btnVBlankToggle.Text = "VBlank:" + Convert.ToString(memory.bolVBlank);
            }
        }

        #region Button Clicks
        private void btnStartRom_Click(object sender, EventArgs e)
        {
            bolRunGame = !bolRunGame;
        }

        private void btnBitmapTest_Click(object sender, EventArgs e)
        {

            //gameRender.WriteBitmap();
            //bolEnableDebugStepping = !bolEnableDebugStepping;
        }
        
        private void btnSendToFile_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllLines(@"C:\text.txt", strDebugFull);
        }

        private void btnVBlankToggle_Click(object sender, EventArgs e)
        {
            //bolSetVBlank = true;
            memory.setVblank(!memory.bolVBlank);
            btnVBlankToggle.Text = "VBlank:" + Convert.ToString(memory.bolVBlank);
        }        

        #endregion

        #region Menu Items
        private void menuStartStopROM_Click(object sender, EventArgs e)
        {
            bolRunGame = !bolRunGame;
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TinerasNES\n" +
                            "Version: 000\n" +
                            "Author: Aaron Wiginton\n" +
                            "Created: 06/12/2010",
                            "About TinerasNES");
        }

        private void closeTinerasNESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Close File if its open
            try
            { fsOpenRom.Close(); }
            catch { }

            this.Close();
        }

        public void showHideDebugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                c.Visible = !c.Visible;
            }

            if (btnStartRom.Visible)
            {
                this.MinimumSize = new Size(0, 0);
                this.MaximumSize = new Size(0, 0);
            }
            else
            {
                setVideoSize(intCurrentSize);
            }

            menuStrip1.Visible = true;
            pnlGame.Visible = true;

            vdb = new VisualDebugger(this);
            ppu.bolDrawNameTable = true;
        }

        private void videoSizeOne_Click(object sender, EventArgs e)
        {
            intCurrentSize = Convert.ToInt16(videoSizeOne.Text);
            setVideoSize(intCurrentSize);
        }

        private void videoSizeTwo_Click(object sender, EventArgs e)
        {
            intCurrentSize = Convert.ToInt16(videoSizeTwo.Text);
            setVideoSize(intCurrentSize);
        }

        private void videoSizeThree_Click(object sender, EventArgs e)
        {
            intCurrentSize = Convert.ToInt16(videoSizeThree.Text);
            setVideoSize(intCurrentSize);
        }

        private void videoSizeFullScreen_Click(object sender, EventArgs e)
        {

        }

        private void menuFPSLimit_Click(object sender, EventArgs e)
        {
            // Set/Clear FPS Limit (60 or Unlimited)
            if (menuFPSLimit.Checked)
            {
                gameRender.pp.PresentationInterval = Microsoft.Xna.Framework.Graphics.PresentInterval.Immediate;
                menuFPSLimit.CheckState = CheckState.Unchecked;
            }
            else if (!menuFPSLimit.Checked)
            {
                gameRender.pp.PresentationInterval = Microsoft.Xna.Framework.Graphics.PresentInterval.Default;
                menuFPSLimit.CheckState = CheckState.Checked;
            }
            gameRender.device.Reset(gameRender.pp);
        }

        private void menuFileCloseROM_Click(object sender, EventArgs e)
        {
            closeGame();
            btnStartRom.Enabled = false;
        }

        private void openROMToolStripQuickOpen_Click(object sender, EventArgs e)
        {
            // ***** Temp file location with nes rom *****
            // strFileLocation = @"C:\Emulators\TestRoms\sprite0test.nes";
            // strFileLocation = @"C:\Emulators\TestRoms\colorbars.nes";
            // strFileLocation = @"C:\Emulators\TestRoms\rgbdemo.nes";
            // strFileLocation = @"C:\Emulators\TestRoms\smb.nes";
             strFileLocation = @"C:\Emulators\TestRoms\balloonfight.nes";
            // strFileLocation = @"C:\Emulators\TestRoms\mariobros.nes";
            //strFileLocation = @"C:\Emulators\TestRoms\nestest.nes";
            // strFileLocation = @"C:\Emulators\TestRoms\official_only.nes";

            openROM(strFileLocation);
        }
        
        private void openROMToolStripMenuOpenRom_Click(object sender, EventArgs e)
        {
            OpenFileDialog fDialog = new OpenFileDialog();
            fDialog.Title = "TinerasNES - Select a .NES file";
            fDialog.InitialDirectory = @"c:\Emulators\TestRoms";
            fDialog.Filter = "All files (*.*)|*.*|All files (*.*|*.*";
            fDialog.FilterIndex = 2;
            fDialog.RestoreDirectory = true;

            if (fDialog.ShowDialog() == DialogResult.OK)
            {
                strFileLocation = fDialog.FileName;
                openROM(strFileLocation);
            }
        }        
        
        private void menuAutoStartROM_Click(object sender, EventArgs e)
        {
            // Set/Clear Auto-Start Rom
            if (menuAutoStartROM.Checked)
            {
                menuAutoStartROM.CheckState = CheckState.Unchecked;
            }
            else if (!menuAutoStartROM.Checked)
            {
                menuAutoStartROM.CheckState = CheckState.Checked;
            }
        }
        #endregion

        public void openROM(string strFileLoc)
        {
            //------------------------------------------------------------------------------
            // Courtesy of NEStreme Emu
            // Name: LoadROMToMem()
            // Desc: Loads the ROM into memory for use. The .NES file is 
            //       structure as follow (copied from Yoshi's nes doc.
            //
            //    +--------+------+------------------------------------------+
            //    | Offset | Size | Content(s)                               |
            //    +--------+------+------------------------------------------+
            //    |   0    |  3   | 'NES'                                    |
            //    |   3    |  1   | $1A                                      |
            //    |   4    |  1   | 16K PRG-ROM page count                   |
            //    |   5    |  1   | 8K CHR-ROM page count                    |
            //    |   6    |  1   | ROM Control Byte #1                      |
            //    |        |      |   %####vTsM                              |
            //    |        |      |    |  ||||+- 0=Horizontal mirroring      |
            //    |        |      |    |  ||||   1=Vertical mirroring        |
            //    |        |      |    |  |||+-- 1=SRAM enabled              |
            //    |        |      |    |  ||+--- 1=512-byte trainer present  |
            //    |        |      |    |  |+---- 1=Four-screen mirroring     |
            //    |        |      |    |  |                                  |
            //    |        |      |    +--+----- Mapper # (lower 4-bits)     |
            //    |   7    |  1   | ROM Control Byte #2                      |
            //    |        |      |   %####0000                              |
            //    |        |      |    |  |                                  |
            //    |        |      |    +--+----- Mapper # (upper 4-bits)     |
            //    |  8-15  |  8   | $00                                      |
            //    | 16-..  |      | Actual 16K PRG-ROM pages (in linear      |
            //    |  ...   |      | order). If a trainer exists, it precedes |
            //    |  ...   |      | the first PRG-ROM page.                  |
            //    | ..-EOF |      | CHR-ROM pages (in ascending order).      |
            //    +--------+------+------------------------------------------+
            //
            //------------------------------------------------------------------------------

            if (btnStartRom.Enabled)
            {
                // Close the game if there is one already open
                closeGame();
            }

            // Close File if its open
            try
            { fsOpenRom.Close(); }
            catch { }

            // Open file
            fsOpenRom = new FileStream(strFileLoc, FileMode.Open);
            byte[] temp = new byte[16];
            // Copy to memory
            //fsOpenRom.Read(memory.memCart, 0, Convert.ToInt16(fsOpenRom.Length));

            // Get Mirroring type from cartridge header
            fsOpenRom.Read(temp, 0, temp.Length);
            memory.byteMirror = (byte)(temp[6] & 0x01);

            // Get mapper number
            mappers.MapperNumber = (byte)((temp[6] >> 0x04) | (temp[7] & 0xF0));
            memory.MapperNumber = mappers.MapperNumber;

            byte byteNumPRGBanks = temp[4];
            byte byteNumCHRBanks = temp[5];

            if (MapperNumber != 0)
            {
                // MessageBox.Show("Mapper Number: " + Convert.ToString(MapperNumber));
            }

            // Read in CPU data (PRG-ROM)
            memory.memPRG = new byte[byteNumPRGBanks][];    // Create Banks for PRG Memory
            if (byteNumPRGBanks == 0x01)
            {
                fsOpenRom.Read(memory.memCPU, 0xC000, 0x4000);

                for (int i = 0x0000; i < 0x4000; i++)
                {
                    memory.memCPU[0x8000 + i] = memory.memCPU[0xC000 + i];
                }
            }
            else
            {
                for (int j = 0; j < memory.memPRG.Length; j++)
                {
                    memory.memPRG[j] = new byte[0x4000];
                }

                for (int k = 0; k < memory.memPRG.Length; k++)
                {
                    fsOpenRom.Read(memory.memPRG[k], 0, 0x4000);
                }

                for (int l = 0; l < 0x4000; l++)
                {
                    memory.memCPU[l + 0x8000] = memory.memPRG[0][l];
                    memory.memCPU[l + 0xC000] = memory.memPRG[memory.memPRG.Length - 1][l];
                }

                //fsOpenRom.Read(memory.memCPU, 0x8000, 0x8000);
            }
            //else
            //{
            //    MessageBox.Show("TinerasNES: OpenROM() - File read error.  Wrong # of PRG Banks", "Not a NES ROM!");
            //}

            if (byteNumCHRBanks != 0)
            {
                memory.memCHR = new byte[byteNumCHRBanks][];    // Create Banks for CHR Memory


                for (int x = 0; x < memory.memCHR.Length; x++)
                {
                    memory.memCHR[x] = new byte[0x2000];
                }

                // Read in PPU data (CHR-ROM)
                for (int y = 0; y < memory.memCHR.Length; y++)
                {
                    fsOpenRom.Read(memory.memCHR[y], 0, 0x2000);
                }

                // Read in PPU data (CHR-ROM)
                for (int z = 0; z < 0x2000; z++)
                {
                    memory.memPPU[z] = memory.memCHR[0][z];
                }
            }


            // registers.regPC = 0xFFFC; <--- THIS ONE IS CORRECT, NEED TO UPDATE TO MAKE STARTING ADDRESS
            /* This location FFFC points to the starting address of the Interrupt Handler(likely FF11) (requires 7 cycles to start FYI) */

            //registers.regPC = 0xFF11; // Temporary, make FFFC the perm one, requires some extra code.  Run it to see what I mean.
            //registers.regPC = 0xFFFC;
            if (cbxNesTest.CheckState == CheckState.Checked)
            {
                registers.regPC = 0xC000;
            }
            else
            {
                registers.regPC = memory.memCPU[0xFFFC] + memory.memCPU[0xFFFD] * 16 * 16;
            }

            //MessageBox.Show("I'm done");
            btnStartRom.Enabled = true;

            memory.memCPU[0x4016] = 0x40;
            memory.memCPU[0x4017] = 0x40;
            //char b1 = Convert.ToChar(memory.memCart[0]),
            //     b2 = Convert.ToChar(memory.memCart[1]),
            //     b3 = Convert.ToChar(memory.memCart[2]);

            //MessageBox.Show("" + b1 + b2 + b3);

            if (menuAutoStartROM.Checked)
            {
                bolRunGame = true;
            }
        }

        public void resetGame()
        {
            registers = new Registers();
            input = new Input();
            mappers = new Mappers();
            memory = new MemoryMap(registers, input, this, mappers);
            ppu = new PPU(memory, this);
            cpu = new CPU(memory, input, ppu, registers);


            strDebugFull = new string[debugLinesMax];

            //pnlGame = new Panel();
            gameRender = new GameRender(this);
            
            intTotalInstrucions = 0;
            //bolEnableDebugStepping = true;
            bolStartFrame = true;
            bolReset = true;

            setVideoSize(intCurrentSize);
            
            // Reset debugger if it exists
            if (vdb != null)
            {
                vdb.Close();

                vdb = new VisualDebugger(this);
                ppu.bolDrawNameTable = true;
            }
        }

        public void closeGame()
        {
            bolRunGame = false;
            gameRender.device.Dispose();
            this.pnlGame.Dispose();

            resetGame();
        }

        public int strToHex(string strToConvert)
        {
            // Converts a two byte hex string into a hex int and returns it

            if (strToConvert == "0" || strToConvert == "")
            {
                return 0;
            }

            int hexValue = 0, intCount = 0;
            char[] charValue = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

            // Handle Low Byte
            for (intCount = 0; intCount < (charValue.Length + 1); intCount++)
            {
                if (strToConvert[1] == charValue[intCount])
                {
                    hexValue = intCount;
                    break;
                }
            }

            // Handle High Byte
            for (intCount = 0; intCount < (charValue.Length + 1); intCount++)
            {
                if (strToConvert[0] == charValue[intCount])
                {
                    hexValue += intCount * 16;
                    break;
                }
            }

            return hexValue;
        }

        public string returnBinaryString(int intToConvert)
        {
            // Converts an integer to a binary string and returns that string.  Written by Aaron W.

            int intCount = 0;
            string strMyString = "";
            char[] chrBinary = new char[8] { '0', '0', '0', '0', '0', '0', '0', '0' };

            // Write binary into a char array
            for (intCount = 0; intCount < 8; intCount++)
            {
                if ((intToConvert & Convert.ToInt16(Math.Pow(2, intCount))) == Convert.ToInt16(Math.Pow(2, intCount)))
                {
                    chrBinary[intCount] = '1';
                }
            }

            // Convert the char array into a string
            for (intCount = 7; intCount > -1; intCount--)
            {
                strMyString += Convert.ToString(chrBinary[intCount]);
            }

            return strMyString;
        }

        public void setVideoSize(int size)
        {
            // Must reset max and min size to allow windows to be resized below
            this.MinimumSize = new Size(0, 0);
            this.MaximumSize = new Size(0, 0);

            // Get Old Presentation Interval before resetting Presentation Parameters
            Microsoft.Xna.Framework.Graphics.PresentInterval pi = gameRender.pp.PresentationInterval;

            // this.size is calculated to include the borders and menu, so we must add an offset
            sizeBorderOffset = new Size(16, this.menuStrip1.Height + 38);

            this.Size = new Size(256 * size, 240 * size) + sizeBorderOffset;
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            pnlGame.Size = new Size(256 * size, 240 * size);
            gameRender.setPresentationParameters();
            gameRender.pp.PresentationInterval = pi;
            gameRender.device.Reset(gameRender.pp);
        }

        #region Keyboard Input
        public void TinerasNES_KeyDown(object sender, KeyEventArgs e)
        {
            char c = (char)(e.KeyCode);

            if (c == 'J')        // A
            {
                input.joypadOne |= 0x01;
            }
            else if (c == 'H')   // B
            {
                input.joypadOne |= 0x02;
            }
            else if (c == 'F')   // Select
            {
                input.joypadOne |= 0x04;
            }
            else if (c == 'G')   // Start
            {
                input.joypadOne |= 0x08;
            }
            else if (c == 'W')   // Up
            {
                input.joypadOne |= 0x10;
            }
            else if (c == 'S')   // Down
            {
                input.joypadOne |= 0x20;
            }
            else if (c == 'A')   // Left
            {
                input.joypadOne |= 0x40;
            }
            else if (c == 'D')   // Right
            {
                input.joypadOne |= 0x80;
            }

            // ****** DEBUGGING ******

            else if (c == 'P')   // Right
            {
                if (intMaxCPUCycles >= 10000)
                {
                    intMaxCPUCycles -= 2000;
                }
            }
            else if (c == 'O')   // Right
            {
                if (intMaxCPUCycles <= 200000)
                {
                    intMaxCPUCycles += 2000;
                }
            }
            else if (c == 'Q')   // Up
            {

            }
            else if (c == 'E')   // Down
            {

            }

            else if (c == 'L')   // Dump CPU Mem to file
            {
                // Open file for reading
                System.IO.FileStream _FileStream = new System.IO.FileStream(@"C:\cpudump.bin", System.IO.FileMode.Create, System.IO.FileAccess.Write);

                // Writes a block of bytes to this stream using data from a byte array.
                _FileStream.Write(memory.memCPU, 0, memory.memCPU.Length);

                // close file stream
                _FileStream.Close();
            }
        }

        private void TinerasNES_KeyUp(object sender, KeyEventArgs e)
        {
            Keys c = e.KeyCode;

            if (c == Keys.J)        // A
            {
                input.joypadOne &= 0xFE;
            }
            else if (c == Keys.H)   // B
            {
                input.joypadOne &= 0xFD;
            }
            else if (c == Keys.F)   // Select
            {
                input.joypadOne &= 0xFB;
            }
            else if (c == Keys.G)   // Start
            {
                input.joypadOne &= 0xF7;
            }
            else if (c == Keys.W)   // Up
            {
                input.joypadOne &= 0xEF;
            }
            else if (c == Keys.S)   // Down
            {
                input.joypadOne &= 0xDF;
            }
            else if (c == Keys.A)   // Left
            {
                input.joypadOne &= 0xBF;
            }
            else if (c == Keys.D)   // Right
            {
                input.joypadOne &= 0x7F;
            }
        }

        private void TinerasNES_KeyPress(object sender, KeyPressEventArgs e)
        {
            //char c = e.KeyChar;

            //if (c == 'j')        // A
            //{
            //    input.joypadOne = 0x01;
            //}
            //else if (c == 'h')   // B
            //{
            //    input.joypadOne = 0x02;
            //}
            //else if (c == 'f')   // Select
            //{
            //    input.joypadOne = 0x04;
            //}
            //else if (c == 'g')   // Start
            //{
            //    input.joypadOne = 0x08;
            //}
            //else if (c == 'w')   // Up
            //{
            //    input.joypadOne = 0x10;
            //}
            //else if (c == 's')   // Down
            //{
            //    input.joypadOne = 0x20;
            //}
            //else if (c == 'a')   // Left
            //{
            //    input.joypadOne = 0x40;
            //}
            //else if (c == 'd')   // Right
            //{
            //    input.joypadOne = 0x80;
            //}
        } 
        #endregion

        private void tmrFPS_Tick(object sender, EventArgs e)
        {
            this.Text = ("TinerasNES - FPS: ") + Convert.ToString(intFPS) + "  NameTable: " + String.Format("{0:x4}", ppu.nameTable) + "  Mapper #: " + Convert.ToString(MapperNumber)
                        + ", Bank: " + Convert.ToString(memory.MapperBank);
            intFPS = 0;
        }

        private void DragToOpenFile(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            openROM(files[0]);
        }

        private void DragEnterEvent(object sender, DragEventArgs e)
        {
            // Must be enabled to allow DragDrop Event
            if (e.Data.GetDataPresent(DataFormats.FileDrop/*, false) == true*/))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;  
            }
        }

        public void NMIHandler()
        {
            cpu.NMIHandler(memory);
        }

        public void AddCPUCycles(int cycles)
        {
            cpu.intTotalCpuCycles += cycles * 15;
        }

        protected override void OnClosing(CancelEventArgs args)
        {
            bolRunGame = false;
        }

        public TinerasNES()
        {
            InitializeComponent();
            resetGame();
        }
    }
}
