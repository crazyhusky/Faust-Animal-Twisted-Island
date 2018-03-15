using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FATI_beta
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            RunWindow();
        }
        static void RunWindow() {
            Application.EnableVisualStyles();
            Application.Run(new TestFormX());
        }
    }
}
