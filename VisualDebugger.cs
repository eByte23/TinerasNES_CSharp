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
    public class VisualDebugger : Form
    {
        TinerasNES tinerasNES;
        public VDRender vd;

        public Panel pnlNT2000;
        public Panel pnlNT2400;
        public Panel pnlNT2800;
        public Panel pnlNT2C00;

        // VisualDebugger Class Constructor
        public VisualDebugger(TinerasNES tinerasNESRef)
        {
            tinerasNES = tinerasNESRef;
            vd = new VDRender(tinerasNES, this);

            this.Size = new Size(530, 520);
            this.Show();
        }
    }
}
