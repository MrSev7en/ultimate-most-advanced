using System;
using Ultimate_Most_Advanced___Console.Language;

namespace Ultimate_Most_Advanced___Console.Commands
{
    public struct Handler
    {
        public Handler(List.Commands Command, string[] args)
        {
            switch (Command)
            {
                case List.Commands.clear:
                    {
                        new Command.clear(args);
                    }
                    break;

                case List.Commands.web:
                    {
                        new Command.web(args);
                    }
                    break;

                case List.Commands.experimental:
                    {
                        new Command.experimental(args);
                    }
                    break;

                case List.Commands.none:
                    {
                        Console.WriteLine(enUS.get(Global.Messages.COMMAND_NOT_FOUND));
                    }   
                    break;
            }
        }
    }
}
