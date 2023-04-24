using System;
using System.Text.RegularExpressions;

namespace SlavaGu.ConsoleAppLauncher.Samples
{
    public class SysInfo
    {
        /// <summary>
        /// Run simplest shell command and return its output.
        /// </summary>
        /// <returns></returns>
        public static string GetWindowsVersion()
        {
            return ConsoleApp.Run("cmd", "/c ver").Output.Trim();
        }

        /// <summary>
        /// Run ipconfig.exe and return matching line.
        /// </summary>
        /// <returns></returns>
        public static string GetIpAddress()
        {
            var output = ConsoleApp.Run("ipconfig").Output;
            var match = Regex.Match(output, "IPv4 주소.*: (?<addr>.*)");
            return match.Success ? match.Groups["addr"].Value : "<undefined>";
        }

        /// <summary>
        /// Run ping.exe asynchronously and return roundtrip times back to the caller in a callback
        /// </summary>
        /// <param name="url"></param>
        /// <param name="replyHandler"></param>
        public static void PingUrl(string url, Action<string> replyHandler)
        {
            var regex = new Regex("(time=|평균 = )(?<time>.*?ms)", RegexOptions.Compiled);
            var app = new ConsoleApp("ping", url);
            app.ConsoleOutput += (o, args) =>
            {
                var match = regex.Match(args.Line);
                if (match.Success)
                {
                    var roundtripTime = match.Groups["time"].Value;
                    replyHandler(roundtripTime);
                }
            };
            app.Run();
        }

        /// <summary>
        /// Get Windows firewall rule
        /// </summary>
        /// <param name="ruleName"></param>
        /// <returns></returns>
        public static string GetFirewallRule(string ruleName)
        {
            var cmdLine = string.Format("advfirewall firewall show rule \"{0}\" verbose", ruleName);
            return ConsoleApp.Run("netsh", cmdLine).Output.Trim();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ruleName"></param>
        /// <returns></returns>
        public static string RClone(string ruleName)
        {
            var cmdLine = string.Format("/c rclone {0}", ruleName);
            return ConsoleApp.Run("cmd", cmdLine).Output.Trim();
        }

        public static void RCloneA(string cmdLine, Action<string> replyHandler)
        {
            //var regex = new Regex("(time=|평균 = )(?<time>.*?ms)", RegexOptions.Compiled);
            var app = new ConsoleApp("rclone.exe", cmdLine);

            Console.WriteLine(app.CmdLine);

            app.ConsoleOutput += (o, args) =>
            {
                //var match = regex.Match(args.Line);
                //if (match.Success)
                //{
                    //var roundtripTime = match.Groups["time"].Value;
                    replyHandler(args.Line);
                //}
            };
            app.Run();
        }
    }
}
