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
            GameInit();
            RunWindow();
            GameDeInit();
        }

        static void GameInit()
        {
            MainGame = new Mechanics.MainGameController();
            MainGame.SetupFileSystems();
            MainGame.LoadAssets();
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
