﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proxy
{
    interface IServer
    {
        bool login(string _username, string _password);
    }
}
