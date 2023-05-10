using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char inputChar = Console.ReadKey().KeyChar;
            int inputCode = (int)inputChar;
            int outputCode = (inputCode + 1) % 256;
            char outputChar = (char)outputCode;

            switch (inputCode % 4)
            {
                case 0:
                    Console.Write("(" + outputChar + ")");
                    break;
                case 1:
                    Console.Write("[" + outputChar + "]");
                    break;
                case 2:
                    Console.Write("<" + outputChar + ">");
                    break;
                case 3:
                    Console.Write("{" + outputChar + "}");
                    break;
            }
        }
    }
}
