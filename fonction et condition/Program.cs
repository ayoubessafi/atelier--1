using System;

namespace fonction_et_condition
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 4;
            while ( a < 15)
            {
                int c = a * b;
                Console.WriteLine(c);
                a++;
            }

        }
    }
}
