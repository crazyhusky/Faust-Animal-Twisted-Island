﻿using System;
using FATIbeta.CoreEngine;

namespace FATIbeta.src.UI
{
    public class InputAbstraction
    {
        public static void GameTick(object sender, EventArgs eventArgs)
        {
            
        }

        public static void GameInputUpdate(object sender, EventArgs eventArgs)
        {
            Program.MainGame.getGameLoop().GameLoopLoopTick();
        }
    }
}