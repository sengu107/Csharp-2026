using System;
using System.Windows.Forms;
using HRM.BUS;
using HRM.DAL;
namespace HRM.GUI
{
    internal static class Program
    {
            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                
                Application.Run(new MainForm());
            }
        }
    }
