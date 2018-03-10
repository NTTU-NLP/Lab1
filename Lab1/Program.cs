using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(@"..\..\..\Dataset\0005_gs.xml"))
            {
                while (sr.Peek() != -1)
                {
                    string line = sr.ReadLine();
                    foreach (var ch in line)
                    {
                        if (!Char.IsWhiteSpace(ch))
                        {
                            Console.Write(ch);
                        }
                    }
                }
            }
        }
    }
}
