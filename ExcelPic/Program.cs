/*
  CLAIM:
  Hello World:
  The source code in this application (ExcelPic) is my creation. 
  You can freely use the code for either personal or commercial purposes.
  I claim no copyright on it and take no obligation of it.
  If you disagree with the above statements, please don't use it.
  
  (Of course, if my name is mentioned anywhere in your good work based on this code, I'll be very happy...)
 
  Best Regards,
  - geek2simon (geek2.info)
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelPic
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(new FrmMain());


        }
    }
}
