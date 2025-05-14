using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*  Adı Soyadı : Abdulhadi KRIMESH
 *  ÖĞRENCİ NO : G231210577
 *          2.A
 */

namespace _2.odevi
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Application.ApplicationExit += new EventHandler(OnAppExit);
        }

        static void OnAppExit(object sender, EventArgs e)
        {
            
            MessageBox.Show("Uygulama kapanıyor...");
        }
    }
}
