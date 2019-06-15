using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class MotoE4Plus : ISmartPhone
    {
        public string GetModelDetail()
        {
            return "Moto E4 Plus";
        }
    }
}
