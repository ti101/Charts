﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charts
{
    interface IFunction
    {
        string FunctionName
        {
            get;
        }
        double Value(double x);
        event emptyFunction FunctonChanged;
    }
    public delegate void emptyFunction();
}
