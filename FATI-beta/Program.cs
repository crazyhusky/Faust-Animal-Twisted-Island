using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpPhysFS;
namespace FATI_beta
{
    class Program
    {
        protected static Mechanics.MainGameController MainGame;
        [STAThread]
        static void Main(string[] args)
        {
            //FileSystemTests();
            GameInit();
            RunWindow();
            Console.WriteLine("\n");
            GameDeInit();
        }

        private static void FileSystemTests()
        {
            //Filesystem Test
            using (var pfs = new PhysFS(""))
            {
                pfs.Mount(Environment.CurrentDirectory, "", true);
                using (var reader = new StreamReader(pfs.OpenRead("/helloworld.txt")))
                {
                    var contents = reader.ReadToEnd();
                    Console.WriteLine(contents);
                }
            }
        }

        static void GameInit()
        {
            MainGame = new Mechanics.MainGameController();
        }

        static void GameDeInit()
        {
            MainGame.Dispose();
        }
        static void RunWindow()
        {
            Application.EnableVisualStyles();
            Application.Run(new TestFormX());
        }
    }
}
