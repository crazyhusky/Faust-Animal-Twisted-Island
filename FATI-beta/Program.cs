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
        protected static PhysFS filesystemLink;
        [STAThread]
        static void Main(string[] args)
        {
            //FileSystemTests();
            GameInit();
            //RunWindow();
            Console.WriteLine("\n");
            Console.WriteLine(string.Join("\n",filesystemLink.EnumerateFiles("/")));
            GameDeInit();
        }

        private static void FileSystemTests()
        {
            //Filesystem Test
            using (var pfs = new PhysFS(""))
            {
                pfs.Mount(System.Environment.CurrentDirectory, "", true);
                using (var reader = new StreamReader(pfs.OpenRead("/helloworld.txt")))
                {
                    var contents = reader.ReadToEnd();
                    Console.WriteLine(contents);
                }
            }
        }

        static void GameInit()
        {
            filesystemLink = new PhysFS("");
            SetupFileSystems();
        }

        static void GameDeInit()
        {
            filesystemLink.Deinit();
        }

        static void SetupFileSystems()
        {
            var seporator = filesystemLink.GetDirSeparator();
            var BaseDataDir = Environment.CurrentDirectory + seporator + "GameData";
            var UnPackedData = BaseDataDir + seporator + "Unpacked";
            var Packed = BaseDataDir + seporator + "Packed";
            var saveData = BaseDataDir + seporator + "SaveData";
            filesystemLink.PermitSymbolicLinks(true);
            Directory.CreateDirectory(saveData);
            filesystemLink.SetWriteDir(saveData);
            filesystemLink.Mount(UnPackedData, "", true);
            SetupPackedData(Packed);

        }

        static void SetupPackedData(string baseDir)
        {
            //get all files in alphabetic order
            var sorted = Directory.GetFiles(baseDir).OrderBy(f => f);
            foreach (var file in sorted)
            {
                try
                {
                    filesystemLink.Mount(file, "", false);
                }
                catch (PhysFS.PhysFSException){}
            }
        }
        static void RunWindow()
        {
            Application.EnableVisualStyles();
            Application.Run(new TestFormX());
        }
    }
}
