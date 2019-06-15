using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class MobileClient
    {
        private INormalPhone _normalPhone;
        private ISmartPhone _smartPhone;
        public MobileClient(IMobilePhone mobilePhone)
        {
            _normalPhone = mobilePhone.GetNormalPhone();
            _smartPhone = mobilePhone.GetSmartPhone();
        }
        public string GetSmartPhoneModelDetails()
        {
            return _smartPhone.GetModelDetail();
        }

        public string GetNormalPhoneModelDetails()
        {
            return _normalPhone.GetModelDetail();
        }
    }
}
