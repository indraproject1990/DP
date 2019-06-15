using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Nokia1600 : INormalPhone
    {
        public string GetModelDetail()
        {
            return "Nokia 1600";
        }
    }
}
