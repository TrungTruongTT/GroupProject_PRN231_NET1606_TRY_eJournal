﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrpcService.InterfaceService
{
    public  interface ICurrentTime
    {
        public DateTime GetCurrentTime();
    }
}