using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Moto : IMobilePhone
    {
        public INormalPhone GetNormalPhone()
        {
            return new MotoOld();
        }

        public ISmartPhone GetSmartPhone()
        {
            return new MotoE4Plus();
        }
    }
}
