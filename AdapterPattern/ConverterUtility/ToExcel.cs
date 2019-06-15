﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class ToExcel : IExport
    {
        public void Save()
        {
            Console.WriteLine("Converted to Excel Format");
        }
    }
}
