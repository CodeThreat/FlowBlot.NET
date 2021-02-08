using FlowBlot.Model;

namespace FlowBlot.Flows
{
    public class Flow_00020
    {
        public const string ID = "00020"; 
        public const string Description = "A setter FP taint propagation";
        public const bool IsVulnerable = false;

        public void Run()
        {
            Blot blot = new Blot();
            blot.Viscosity = System.Console.ReadLine();


            /*FLOW:Flow_00020 - A setter FP taint propagation:OS Command Injection:0:NONE:0:
             *STEP_PATH:ABC
             */
            System.Diagnostics.Process.Start(blot.Viscosity);
        }

    }
}
