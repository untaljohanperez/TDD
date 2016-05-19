using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzer.Library
{
    public class FizzBuzzer
    {
        public static string getNumber(int input)
        {
            string respuesta = string.Empty;

            if (input % 3 == 0)
            {
                respuesta += "Fizz";
            }
            if (input % 5 == 0)
            {
                respuesta += "Buzz";
            }
            if (respuesta == string.Empty){
                respuesta += input.ToString();
            }
            return respuesta;
        }
    }
}
