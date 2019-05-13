using System;

					
public class Program
{
	public void StrConCat()
	{
		 String s1=" Where ";
		 String s2="are you";
	  	 //String s3;
		
		//StringBuilder sb=new StringBuilder();
		Console.WriteLine("\n First String:=" +s1);
		Console.WriteLine("\n Second String:=" +s2);
		
		Console.WriteLine("\n Append 2nd string to 1st string");
		Console.WriteLine(String.Concat(s1,s2));
		
		Console.WriteLine("\n Append 1st string to 2nd string");
		Console.WriteLine(String.Concat(s2,s1));
		
		//Console.WriteLine(s1+""+""s3);
	}
	
	public void InsertString(String s1, String s2)
	{
		char[] ch1 = s1.ToCharArray();
		char[] ch2 = s2.ToCharArray();

		for(int i=0; i<s1.Length; i++)
		{
			for(int j=0; j<s2.Length; j++)
			{
				if (ch2[j] == ch1[i])
				ch2[j] = ' ';
			}
		}

		s2 = new String(ch2);

		char[] splitchar = { ' ' };
		String[] substr = s2.Split(splitchar);

		for(int i=0; i<substr.Length; i++)
		{
			substr[i] = substr[i].Trim();
		}

		s2 = string.Join("", substr);

		s1 = s1.Insert(1, s2);

		Console.WriteLine("\n The new non-duplicate merged string is : {0}", s1);
}

	
	
	public static void Main()
	{
		String s1=" Where ";
		String s2="are you";
	    Program p=new Program();
		p.StrConCat();
		p.InsertString(s1,s2);
		
	}
}