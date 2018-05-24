﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R.Services
{
    //basic storage plugin for various implementations/database connectors
    public interface IConfigurationUpdateService : IService
    {
        void UpdateConfiguration(R.Config.Update.IUpdatePackage pkg);
        void UpdateSettings(ICollection<string> paths);
        void ReleaseConfiguration();
        //IApplicationBuilder ApplicationBuilder { get; set; }
    }
    /*public interface IStoragePlugin
    {
        void RefreshConfiguration();
        void RefreshDateConnections(string [] connectors);
    }*/
}