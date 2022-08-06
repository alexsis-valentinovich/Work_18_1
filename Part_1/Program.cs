using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите иследуемую строку");
            string element_Str = Console.ReadLine();
            if (Check(element_Str) == false)
                Console.WriteLine("Не верная строка");
            else
                Console.WriteLine("Верная строка");
            Console.ReadKey();
        }
        static bool Check(string element_Str)
        {
            Stack<char> stack_Str = new Stack<char>();
            Dictionary<char, char> dicSkoba = new Dictionary<char, char>
            {
             {'(',')'},
             {'{','}'},
             {'[',']'},
            };
            foreach (char c in element_Str)
            {
                if ((c == '(') || (c == '{') || (c == '['))
                {
                    stack_Str.Push(dicSkoba[c]);
                }
                if ((c == ')') || (c == '}') || (c == ']'))
                {
                    if (stack_Str.Count == 0 || stack_Str.Pop() != c)
                    {
                        return false;
                    }
                }
            }
            if (stack_Str.Count == 0)
                return true;
            else
                return false;

        }
    }
}


