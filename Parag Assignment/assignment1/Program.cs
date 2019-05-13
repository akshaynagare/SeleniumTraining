using System;

namespace assignment1
{
    class Program
    {
        public string convert(string s) 
        { 
            int n = s.length(); 
  
            int res_ind = 0; 
  
            for (int i = 0; i < n; i++) 
            { 
  
                // check for spaces in the sentence 
                if (s[i] == ' ') 
                { 
                    s[i + 1] = toupper(s[i + 1]); 
                    continue; 
                } 
  
                // If not space, copy character  
                else 
                {
                    s[res_ind++] = s[i];         
                } 
  
                s[res_ind] = '\0'; 
  
    // return string to main 
                return s; 
            } 
        }
        public static void main(string[] args)
        {
            string str = "I got internship at nitor in fotech pvt ltd"; 
            console.WriteLine(str); 
            return 0;
        } 
    }

}
