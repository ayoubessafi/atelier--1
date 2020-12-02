using System;

namespace fonction_et_condition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez l'action à effectuer");
            Console.WriteLine("Presse a pour addition");
            Console.WriteLine("Presse s pour la soustraction ");
            Console.WriteLine("Presse m pour la multiplication" );
            Console.WriteLine("Presse d pour la division");
            string action = Console.ReadLine();
            Console.WriteLine("tapis 1ére nombre");
            int input_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("tapis 2éme nombre");
            int input_2 = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            switch (action)
            {
                case "a":
                    {
                        result = Addition(input_1, input_2);
                        break;
                    }
                case "s":
                    {
                        result = Subtraction(input_1, input_2);
                        break;
                    }
                case "m":
                    {
                        result = Multiplication(input_1, input_2);
                        break;
                    }
                case "d":
                    {
                        result = Division(input_1, input_2);
                        break;
                    }
                default:
                    Console.WriteLine("Wrong action!! try again");
                    break;
            }
            Console.WriteLine("The result is {0}",result);
            Console.WriteLine("presse q pour arrêter");
            if (Console.ReadLine() == "q")
            {
                Environment.Exit(0);
            }
        }
        //Addition  
        public static int Addition(int input_1, int input_2)
        {
            int result = input_1 + input_2;
            return result;
        }
        //Substraction  
        public static int Subtraction(int input_1, int input_2)
        {
            int result = input_1 + input_2;
            return result;
        }
        //Multiplication  
        public static int Multiplication(int input_1, int input_2)
        {
            int result = input_1 + input_2;
            return result;
        }
        //Division  
        public static int Division(int input_1, int input_2)
        {
            int result = input_1 + input_2;
            return result;
        }
    }
}