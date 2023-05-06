using System;
using System.Collections.Generic;
using System.Text;

namespace Aula4
{
    class Telephone
    {
        public String numberTelephone { get; set; }
        public String mobileOperator { get; set; }

        public String viewNumber()
        {
            return numberTelephone;
        }

        public String viewMobileOperator()
        {
            return mobileOperator;
        }



    }
}
