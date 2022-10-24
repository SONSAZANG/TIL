using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _026_Data_Parse
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "100";
            string b = "3.141519";
            string c = "3.124123123123124512391239123";

            int parseA = int.Parse(a);
            float parseB = float.Parse(b);
            decimal parseC = decimal.Parse(c);

            Console.WriteLine("int.Parse: {0}", parseA);
            Console.WriteLine("float.Parse: {0}", parseB);
            Console.WriteLine("deciaml.Parse: {0}", parseC);
        }
    }
}
