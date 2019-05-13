using System;

namespace program10
{
    using System;

class assignment
{
   public void RemoveSpecialSymbol()
        {
          string str = "$A!ksh$ay&Na%gar#e";
             string[] chars = new string[] { ",", ".", "/", "!", "@", "#", "$", "%", "^", "&", "*", "'", "\"", ";", "_", "(", ")", ":", "|", "[", "]" };
            
            for (int i = 0; i < chars.Length; i++)
            {
                if (str.Contains(chars[i]))
                {
                    str = str.Replace(chars[i], "");
                }
            }
            Console.WriteLine(str);
        }
        
        public static void Main(string[] args)
        {
            assignment s = new assignment();
            s.RemoveSpecialSymbol();    
        }
    }
}
