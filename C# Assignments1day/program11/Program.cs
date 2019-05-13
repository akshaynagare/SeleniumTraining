using System;

namespace program11
{
    class Program
    {
      /*  public static void forwardstr()
        {
            Console.WriteLine("\n the forward string are:{0}",str);
        }*/
        public void reversestr()
        {
           string str;
           string str1=" ";
            int i;
            Console.WriteLine("enter the string u wan to reverse");
            str=Console.ReadLine();
            int l = str.Length-1;
            for(i=l;i>=0;i--)
            {
                str1=str1+str[i];
            }
            Console.WriteLine("reverse of string is:{0}",str1);
        }
        static public void Main(string[] args)
        {
            Program p=new Program();
            Console.WriteLine(" C# CODE FOR FORWARD AND REVERSE GIVEN STRING");
          // p.forwardstr();
            p.reversestr();
            
        }
    }
}
