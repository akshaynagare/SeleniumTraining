using System;

namespace assignment2
{
    class Program2
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Traverse for loop from 1 to 7 and display each day name using if and switch");
            Console.WriteLine("\n enter the number between 1 to 7");
            n= Convert.ToInt32(Console.ReadLine());

            switch(n)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednusday");
                    break;
                case 4:
                    Console.WriteLine("Thusday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturnday");
                    break;
                default :
                    Console.WriteLine("Wrong input");
                    break;

            }/*while (n!=6)
            {                
             Console.ReadLine();
            }*/

        }
    }
}
