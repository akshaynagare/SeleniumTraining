using System;

namespace program9
{
    class Program
    {
        public void RemoveWhitespace()
        {
		    String s1="123| ";
            String s2=" 456|";
            String s3="789| ";
            Console.WriteLine("Before WhteSpace Remove");
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3); 
		 
		    Console.WriteLine("After Remove WhiteSpace");
			Console.WriteLine(s1.Trim());
		 	Console.WriteLine(s2.Trim());
		 	Console.WriteLine(s3.Trim());
		 
        }
	
        public static void Main(string[] args)
        {
            Program p = new Program();
            p.RemoveWhitespace();
	     }
    }
}
