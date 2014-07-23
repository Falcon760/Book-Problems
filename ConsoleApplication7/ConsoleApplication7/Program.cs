using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    public class StringHelper
    {
        public static string Capitalize(string input)
        {
            char[] chararray = input.ToCharArray[];
            if (char.IsUpper(chararray[0]) == true)
                char.ToLower(chararray[0]);
            else
                char.ToUpper(charrarray[0]);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string name = "john";
            string result = StringHelper.Captialize(name);
            //convert the first letter in a string to uppercase
        }
    }
}
