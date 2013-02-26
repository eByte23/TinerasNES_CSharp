using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TinerasNES
{
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            

            using (TinerasNES tinerasNES = new TinerasNES())
            {
                Application.EnableVisualStyles();

                tinerasNES.Show();

                while (tinerasNES.Created)
                {
                    int updateForm = 0;

                    Application.DoEvents();

                    while (tinerasNES.bolRunGame)
                    {
                        tinerasNES.runGame();

                        if (updateForm++ >= 1000)
                        {
                            Application.DoEvents();
                            updateForm = 0;
                        }
                    }
                }
            }
        }
    }
}
