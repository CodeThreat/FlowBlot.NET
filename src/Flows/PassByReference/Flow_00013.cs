using FlowBlot.Model;
using System;

namespace FlowBlot.Flows
{
    public class Flow_00013
    {
        public const string ID = "00013";
        public const string Description = "A complex pass by reference taint propagation";
        public const bool IsVulnerable = true;

        public void Run()
        {
            string input = System.Console.ReadLine();
            Blot blot = new Blot() { Name = String.Empty };
            Color(blot, input);

            /*FLOW:Flow_00013 - A complex pass by reference taint propagation:OS Command Injection:9:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            System.Diagnostics.Process.Start(blot.Name);
        }

        public void Color(Blot blot, string input)
        {
            blot.Name = input;
        }
    }
}
