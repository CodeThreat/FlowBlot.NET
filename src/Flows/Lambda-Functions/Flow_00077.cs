using FlowBlot.Model;
using System;
using System.Security.Cryptography.X509Certificates;

namespace FlowBlot
{
    public class Flow_00077
    {
        public const string ID = "00077";
        public const string Description = "An expression lambda FP taint propagation";
        public const bool IsVulnerable = false;

        public void Run()
        {
            string input = System.Console.ReadLine();

            Func<string, string> myFunc = x => x == "Formal" ? "Welcome" : "Howdy";

            string output = myFunc(input);

            /*FLOW:Flow_00077 - An expression lambda FP taint propagation:OS Command Injection:6:FIND_ISSUE:1:
            *STEP_PATH:ABC
            */
            System.Diagnostics.Process.Start(output);
        }
    }
}
