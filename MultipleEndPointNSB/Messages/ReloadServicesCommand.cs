﻿using NServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Messages
{
    [Serializable]
    public class ReloadServicesCommand : ICommand
    {
        public int[] ServiceIds { get; set; }
    }
}
