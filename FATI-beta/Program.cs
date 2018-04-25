﻿using System;
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
        protected static CoreEngine.MainGameController MainGame;

        [STAThread]
        static void Main(string[] args)
        {
            GameInit();
            //RealUI.test2();
            //RunWindow();
            RunAlavlonUI();
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
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.Run(new TestFormX());
        }

        public static AppBuilder BuildAvaloniaApp()
        {
            return AppBuilder.Configure<src.UI.App>().UseSkia().UseMonoMac();
        }

        static void RunAlavlonUI()
        {
            BuildAvaloniaApp().Start<src.UI.MainWindow>();

        }
    }
}