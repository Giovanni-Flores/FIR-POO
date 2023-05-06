using System;
using System.Collections.Generic;
using System.Text;

namespace Aula4
{
    class Car
    {
        public String name { get; set; }
        public int power { get; set; }

        public String viewName()
        {
            return name;
        }

        public int viewPower()
        {
            return power;
        }
        
    }
}
