using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class ThirdPartyConverter
    {
        public void Export()
        {
            Console.WriteLine("Converted to Image Format");
        }
    }
}
