namespace Ultimate_Most_Advanced___Console.Language
{
    public struct enUS
    {
        public static string get(Global.Messages ID)
        {
            string Output = string.Empty;

            switch (ID)
            {
                case Global.Messages.COMMAND_NOT_FOUND: { Output = "Command not found."; } break;

                case Global.Messages.WEB_INVALID_PARAMETER: { Output = "Invalid web parameter,\nsee in 'help web' command."; } break;
                case Global.Messages.WEB_MISSING_PARAMETER: { Output = "Missing - parameter."; } break;
                case Global.Messages.WEB_SENDED: { Output = "Send [word] to '[url]' with [size] packets"; } break;
                case Global.Messages.IP_SENDED: { Output = "Send [size] packets in UDP to '[address]'"; } break;
                case Global.Messages.IP_SENDED_WITHOUT_MULTICORE: { Output = "Send data without any another packages."; } break;
                case Global.Messages.IP_SENDED_WITH_MULTICORE: { Output = "Send with multicore, be careful."; } break;
                case Global.Messages.WEB_MULTICORE_DISABLED: { Output = "Web Multicore as disabled with success."; } break;
                case Global.Messages.WEB_MULTICORE_ENABLED: { Output = "Web Multicore as enabled with success, with power [power]ks/s."; } break;

                case Global.Messages.HIGH_EXPERIMENTAL_DISABLED: { Output = "High Experimental functions as turned OFF with success."; } break;
                case Global.Messages.HIGH_EXPERIMENTAL_ENABLED: { Output = "High Experimental functions as turned ON with success.\nBE CAREFUL, HIGH EXPERIMENTAL FUNCTIONS USE MORE CPU AND RAM!"; } break;
                case Global.Messages.HIGH_EXPERIMENTAL_NOT_ENABLED: { Output = "High Experimental funcions as not enabled, enable it and try again later."; } break;
                case Global.Messages.HIGH_EXPERIMENTAL_INVALID_PARAMETER: { Output = "Invalid High Experimental parameter, must be 'true' or 'false'."; } break;
            }

            return Output;
        }
    }
}
