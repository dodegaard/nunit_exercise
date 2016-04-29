using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int digitOne;
            int digitTwo;

            bool digitOneCheck = int.TryParse(args[0], out digitOne);
            bool digitTwoCheck = int.TryParse(args[1], out digitTwo);

            if ( args.Length == 2 && digitOneCheck && digitTwoCheck)
            {
                var calculator = new Calculator();
                Console.WriteLine(calculator.Multiply( digitOne, digitTwo ));
                Console.ReadKey();
            }
        }
    }
}
