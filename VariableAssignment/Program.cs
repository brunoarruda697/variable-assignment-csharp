using System;

namespace VariableAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberValue = 10;
            Console.WriteLine(numberValue);

            numberValue += 2;
            Console.WriteLine(numberValue);

            numberValue *= 2;
            Console.WriteLine(numberValue);
            Console.WriteLine("==========================");
            numberValue++;
            Console.WriteLine(numberValue);

            numberValue--;
            Console.WriteLine(numberValue);
            Console.WriteLine("==========================");
            string stringValue = "ABC";
            Console.WriteLine(stringValue);

            stringValue += "DEF";
            Console.WriteLine(stringValue);
        }
    }
}
