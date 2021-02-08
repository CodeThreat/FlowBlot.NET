using FlowBlot.Model;
using System;

namespace FlowBlot.Flows
{
    public class Flow_00019
    {
        public const string ID = "00019"; 
        public const string Description = "A setter taint propagation";
        public const bool IsVulnerable = true;

        public void Run()
        {
            Blot blot = new Blot();
            blot.Label = String.Empty;


            /*FLOW:Flow_00019 - A setter taint propagation:OS Command Injection:5:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            System.Diagnostics.Process.Start(blot.Label);
        }

    }
}
