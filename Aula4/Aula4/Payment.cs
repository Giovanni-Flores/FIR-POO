using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula4
{
    class Payment
    {
        public String name { get; set; }
        public float wage { get; set; }
        public float wage1  { get; set; }
        public float wage2 { get; set; }
        public float result { get; set; }
        public String negative { get; set; }

        public float[] array = new float[3];

        public string validName()
        {
            if (name.All(char.IsDigit))
            {
                
                return "Numbers is not allowed!   ";
            }
            else
            {
                return name;
            }
        }

        public string notNegativeWage()
        {

            if (wage < 0)
            {
                return negative = "Não é permitido valores NEGATIVOS!!1809dghasgdasjdg1tshdgfwuye";
            }
            else
            {
                return negative = Convert.ToString(wage);
            }
        }

        public float totalWage()
        {

            if (array[1] < 0)
            {
                if (array[2] < 0)
                {
                    return 0;
                }
                return array[2];
            }
            else if (array[2] < 0)
            {
                return array[1];
            }
            else
            {
                return result = array[1] + array[2];
            }
        }

    }
}
