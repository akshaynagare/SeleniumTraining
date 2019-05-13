using System;

namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,j,rows;
            Console.Write("\n\n");
            Console.Write("Display the pattern as right angle triangle using number:\n");
            Console.Write("-----------------------------------------------------------");
            Console.Write("\n\n");
	        Console.Write("Input number of rows : ");
            rows= Convert.ToInt32(Console.ReadLine());   
            for(i=1;i<=rows;i++)
            {
	            for(j=1;j<=i;j++)
	            Console.Write("*",j);
	        Console.Write("\n");
            }
        }
    }
}

