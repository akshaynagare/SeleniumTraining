using System;

namespace assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1=0,n2=1,n3,count;
            Console.WriteLine("Fibonnanci Series Program in C#");
            Console.WriteLine("Enter the value");
            count= int.Parse(Console.ReadLine());
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            for (int i = 2; i <=count; i++)

            {
                n3=n1+n2;
                Console.WriteLine(n3);
                n1=n2;
                n2=n3;
            }
        }
    }
}
