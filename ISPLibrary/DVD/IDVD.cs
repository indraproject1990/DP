﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPLibrary
{
    public interface IDVD : ILibraryItem
    {
        List<string> Actors { get; set; }
        int RuntimeInMinutes { get; set; }
    }
}
