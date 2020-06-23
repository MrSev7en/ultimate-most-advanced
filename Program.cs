using System;
using System.Linq;
using System.Reflection;
using Ultimate_Most_Advanced___Console.Commands;

namespace Ultimate_Most_Advanced___Console
{
    public class Program
    {
        public static bool High_Experimental = new bool();

        public static void Main()
        {
            try
            {
                Console.WriteLine("U.M.A - Ultimate Most Advanced (Console Version) - v" + Assembly.GetExecutingAssembly().GetName().Version);
                Console.WriteLine("Copyright CodeStart - All Rights Reserved. - All cycle time.\n");

                Initialize();
            }
            catch { }
        }

        private static void Initialize()
        {
            try
            {
                string Line = Console.ReadLine();

                string Command = Line.Split(' ').Take(1).First();
                string[] args = Line.Split(' ').Skip(1).ToArray();

                new Handler(List.Get.Command(Command), args);

                Initialize();
            }
            catch { }
        }
    }
}