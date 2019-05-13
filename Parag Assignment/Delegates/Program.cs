using System;

namespace Delegates
{
    class Program
    {
        public delegate void print(int value);//Declaration of deligate
        
        static void Main(string[] args)
        {
            Console.WriteLine("Delegate Example");
            
            print printDel=new print(printnum);//deligate print points to function printnum
            printDel(10000);
            printDel(400);
            
        }

        public static void printnum(int num)
        {
            Console.WriteLine("Number {0}",num);
        }


    }

}