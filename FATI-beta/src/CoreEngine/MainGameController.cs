﻿using System;
using System.IO;
using System.Linq;
using FATIbeta.src.UI;
using SharpPhysFS;

namespace FATIbeta.CoreEngine
{
    public sealed class MainGameController : IDisposable
    {
        private JsonMapping DefinedParts;
        private PhysFS filesystemLink;
        private GameLoop TheGameLoop;
        public winformLink gameUI;

        public MainGameController()
        {
            DefinedParts = JsonMapping.Instance;
            filesystemLink = new PhysFS("");
            TheGameLoop = new GameLoop();
        }

        public void LoadAssets()
        {
            AssetLoaderFactory.LoadFiles(filesystemLink, DefinedParts);
        }

        public void SetupFileSystems()
        {
            var seporator = filesystemLink.GetDirSeparator();
            var BaseDataDir = Environment.CurrentDirectory + seporator + "GameData";
            var UnPackedData = BaseDataDir + seporator + "Unpacked";
            var Packed = BaseDataDir + seporator + "Packed";
            var saveData = BaseDataDir + seporator + "SaveData";

            filesystemLink.PermitSymbolicLinks(true);
            Directory.CreateDirectory(BaseDataDir);
            Directory.CreateDirectory(UnPackedData);
            Directory.CreateDirectory(Packed);
            Directory.CreateDirectory(saveData);
            filesystemLink.SetWriteDir(saveData);
            filesystemLink.Mount(UnPackedData, "", true);
            SetupPackedData(Packed);
        }

        public GameLoop getGameLoop()
        {
            return TheGameLoop;
        }

        public JsonMapping GetJsonMappingInstance()
        {
            return DefinedParts;
        }

        private void SetupPackedData(string baseDir)
        {
            //get all files in alphabetic order
            var sorted = Directory.GetFiles(baseDir).OrderBy(f => f);
            foreach (var file in sorted)
            {
                try
                {
                    filesystemLink.Mount(file, "", false);
                }
                catch (PhysFS.PhysFSException)
                {
                }
            }
        }

        #region IDisposable Support

        private bool disposedValue = false; // To detect redundant calls

        private void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    filesystemLink.Deinit();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        ~MainGameController()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(false);
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}