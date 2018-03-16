using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpPhysFS;
namespace FATI_beta
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //Filesystem Test
            using (var pfs = new PhysFS("")) {
                pfs.Mount(System.Environment.CurrentDirectory, "",true);
                using (var reader = new System.IO.StreamReader(pfs.OpenRead("/helloworld.txt")))
                {
                    var contents = reader.ReadToEnd();
                    Console.WriteLine(contents);
                }
            }

            //RunWindow();
        }
        static void RunWindow() {
            Application.EnableVisualStyles();
            Application.Run(new TestFormX());
        }
    }
}
