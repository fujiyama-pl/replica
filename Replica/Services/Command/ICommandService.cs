﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R.Services
{
    public interface ICommandService : IService
    {
        bool InvokeCommand(string path,object ctx);
    }
}