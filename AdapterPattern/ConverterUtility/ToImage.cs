using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class ToImage : IExport
    {
        public void Save()
        {
            ThirdPartyConverter c = new ThirdPartyConverter();
            c.Export();
        }
    }
}
