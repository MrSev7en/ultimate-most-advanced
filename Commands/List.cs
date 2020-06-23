namespace Ultimate_Most_Advanced___Console.Commands
{
    public struct List
    {
        public enum Commands
        {
            none,
            clear,
            write,
            web,
            experimental,
        }

        public class Get
        {
            public static Commands Command(string args)
            {
                switch (args)
                {
                    case "clear":
                        {
                            return Commands.clear;
                        }

                    case "write":
                        {
                            return Commands.write;
                        }

                    case "web":
                        {
                            return Commands.web;
                        }

                    case "experimental":
                        {
                            return Commands.experimental;
                        }

                    default:
                        {
                            return Commands.none;
                        }
                }
            }
        }
    }
}