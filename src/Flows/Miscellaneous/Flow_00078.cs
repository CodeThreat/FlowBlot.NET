using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FlowBlot.Flows
{
    public class Flow_00078
    {
        public const string ID = "00078";
        public const string Description = "An extension method taint propagation";
        public const bool IsVulnerable = true;

        public void Run()
        {
            string input = System.Console.ReadLine();

            string output = input.TrimAndReturn();

            /*FLOW:Flow_00078 - An extension method taint propagation:OS Command Injection:0+:FIND_ISSUE:1:
            *STEP_PATH:ABC
            */
            System.Diagnostics.Process.Start(output);
        }
    }

    public static class StringExtension
    {
        public static string TrimAndReturn(this string str)
        {
            return str.Trim();
        }
    }
}
