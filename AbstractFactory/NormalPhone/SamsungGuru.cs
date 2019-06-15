using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class SamsungGuru : INormalPhone
    {
        public string GetModelDetail()
        {
            return "Samsung Guru";
        }
    }
}
