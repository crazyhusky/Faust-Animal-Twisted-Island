using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Avalonia;
using Avalonia.Logging.Serilog;

namespace FATIbeta
{
    class Program
    {
        public static CoreEngine.MainGameController MainGame;

        [STAThread]
        static void Main(string[] args)
        {
            GameInit();
            RunWindow();
            //RunAlavlonUI();
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
            TestFormX window = new TestFormX();
            System.Windows.Forms.Application.EnableVisualStyles();
            MainGame.gameUI = window.winformInterface;
            System.Windows.Forms.Application.Run(window);
        }

        public static AppBuilder BuildAvaloniaApp()
        {
            return AppBuilder.Configure<src.UI.App>().LogToDebug().UsePlatformDetect();
        }

        static void RunAlavlonUI()
        {
            BuildAvaloniaApp().Start<src.UI.MainWindow>();

        }
    }
}