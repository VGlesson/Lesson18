using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            Console.WriteLine(Check(str));
            Console.ReadKey();

        }

        static bool Check(string str)
        { 
            Stack<char> stac = new Stack<char>();
            Dictionary<char, char> br = new Dictionary<char, char>
            {
                {'(', ')' },
                {'{', '}' },
                {'[', ']' },
            };
            
            foreach (char c in str)
            {
                if (c == '(' || c == '{' || c == '[')
                    stac.Push(br[c]);
                if (c == ')' || c == '}' || c == ']')
                {
                    if (stac.Count==0 || stac.Pop()!=c)
                    {
                        return false;
                    }
                }
            }
            if (stac.Count == 0)
                return true;
            else
                return false;
        }
    }
}
