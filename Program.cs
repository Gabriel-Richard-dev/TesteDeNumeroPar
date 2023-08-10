using System;

namespace ParouImpar 
{

    class Program 
    {

        static void Main(string[] args) 
        {
            Menu();
        }
        
        static void Menu()
        {

            Console.Clear();
            Console.WriteLine("---- Welcome to Pair Tester ---");
            Console.WriteLine();
            Console.WriteLine("1 - Test a number");
            Console.WriteLine("0 - Exit");
            Console.WriteLine();
            Console.Write("Input your choice: ");
            short select = short.Parse(Console.ReadLine());
            
            switch(select)
            {
                case 1: eParOuImpar(); break;
                case 0: System.Environment.Exit(0); break;
                default: Console.WriteLine("Invalid selection"); Menu(); break;
            }
        }

        static void eParOuImpar(){
            Console.Clear();
            Console.Write("Enter the value: ");
            double value = int.Parse(Console.ReadLine());
            bool result = ((value%2) == 0);

            if(result)
                Console.WriteLine($"The number {value} is pair!");
            else 
                Console.WriteLine($"The number {value} is'nt pair! :(");

            Console.WriteLine("Press any key to continue... ");
            Console.ReadKey();
            Menu();
        }

    }


}