using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FATI_beta.UI;
using SharpPhysFS;

namespace FATI_beta
{
    class Program
    {
        protected static CoreEngine.MainGameController MainGame;
        [STAThread]
        static void Main(string[] args)
        {
            GameInit();
            RealUI.test2();
            //RunWindow();
            GameDeInit();
        }

        static void GameInit()
        {
            MainGame = new CoreEngine.MainGameController();
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
