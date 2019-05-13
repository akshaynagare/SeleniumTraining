using System;

namespace ServiceProject
{
    public class program
    {

        public void getdata()
        {
            string str="akshay nagare";
            int l=0,word=1;
            //Console.WriteLine("Count the Total n umber of word");
            //Console.WriteLine("Enter the string");
            str=Console.ReadLine();
            while(l<str.Length-1)
            {
                if(str[l]==' ' || str[l]=='\n' || str[l]=='\t')
                {
                    word++;
                }
                l++;
            }
            Console.Write("Total number of words in the string is : {0}\n", word);

        }
    }
}
