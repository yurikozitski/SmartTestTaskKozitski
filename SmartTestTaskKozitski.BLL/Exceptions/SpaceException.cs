﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTestTaskKozitski.BLL.Exceptions
{
    public class SpaceException : ContractException
    {
        public SpaceException(string message) : base(message) { }
    }
}
