using System;
using System.Collections.Generic;

namespace Lab_18
{
    class Program
    {
        static void Main(string[] args)
        {
            string strInput = Console.ReadLine();
            char[] Arr = strInput.ToCharArray(); //разделяю строку на буквы
            Stack<char> str = new Stack<char>();
            bool f = true;

            foreach (char s in Arr)
            {
                if (s == '('|| s == '{'|| s == '[')
                {
                    str.Push(s); //Если очередной символ — открывающая скобка, нужно поместить её на вершину стека
                }
                if (s == ')')
                {
                    if (str.Count == 0 || str.Pop() != '(')
                    {
                        f=false;
                    }
                }
                if (s == '}')
                {
                    if (str.Count == 0 || str.Pop() != '{')
                    {
                        f = false;
                    }
                }
                if (s == ']')
                {
                    if (str.Count == 0 || str.Pop() != '[')
                    {
                        f = false;
                    }
                }
            }
            if (str.Count != 0)
                f = false;
                Console.WriteLine(f);
            Console.ReadKey();

        }
    }
    }
