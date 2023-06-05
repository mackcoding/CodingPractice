using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public static class Debug
    {
        public static void Write(string Msg)
        {
            Console.WriteLine(Msg);
        }

        public static void Result(string Msg)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Write(Msg);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static string ReadInput(string Msg)
        {
            Console.Write(Msg);
            return Console.ReadLine() ?? string.Empty;
        }

        public static void LineSplit()
        {
            Console.WriteLine("==============================");
        }
    }
}
