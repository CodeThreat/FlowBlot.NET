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
            System.Diagnostics.Process.Start(blot.Label);
        }

    }
}
