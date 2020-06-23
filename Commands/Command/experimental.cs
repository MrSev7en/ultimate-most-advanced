using System;
using Ultimate_Most_Advanced___Console.Language;

namespace Ultimate_Most_Advanced___Console.Commands.Command
{
    public struct experimental
    {
        public experimental(string[] args)
        {
            try
            {
                if (args.Length == new long())
                {
                    Console.WriteLine(enUS.get(Global.Messages.HIGH_EXPERIMENTAL_INVALID_PARAMETER));

                    return;
                }

                switch (args[0])
                {
                    case "true":
                        {
                            Program.High_Experimental = true;

                            Console.WriteLine(enUS.get(Global.Messages.HIGH_EXPERIMENTAL_ENABLED));
                        }
                        break;

                    case "false":
                        {
                            Program.High_Experimental = new bool();

                            Console.WriteLine(enUS.get(Global.Messages.HIGH_EXPERIMENTAL_DISABLED));
                        }
                        break;

                    default:
                        {
                            Console.WriteLine(enUS.get(Global.Messages.HIGH_EXPERIMENTAL_INVALID_PARAMETER));
                        }
                        break;
                }
            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message); Console.ReadLine(); }
        }
    }
}
