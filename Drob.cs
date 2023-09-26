using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fractionСlassLibrary
{
    public class Drob
    {
        public string FixWrongResult(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new Exception("Пустота фвф");
            }
            if (text == "/")
            {
                throw new Exception("Пустота фвф");
            }

            
            string[] number = text.Split('/');


            if (number.Length >2)
            {
                throw new Exception("Пустота фвф");
            }

            if (Convert.ToDouble(number[0]) > Convert.ToDouble(number[1]) )
            {
                number[0] = number[1];
            }

            
            string newtextstring = string.Join("/", number);
            return newtextstring;
        }
    }
}
