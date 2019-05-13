using System;
namespace ServiceProject
{
    public delegate void printdelegate(int value);//Declaration of deligate
    public class program
    {
          public void printnum(int num)
        {
            Console.WriteLine("Delegate Example");
            //print printDel=new print(printnum);//deligate print points to function printnum
            //printDel(10000);
            //printDel(400); 
            Console.WriteLine("Number {0}",num);
        }
    }

}
