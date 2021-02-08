using FlowBlot.Model;

namespace FlowBlot.Flows
{
    public class Flow_00075
    {
        public const string ID = "00075"; 
        public const string Description = "A points-to analysis taint propagation using an assign function";
        public const bool IsVulnerable = true;

        public void Run()
        {
            Blot blot1 = new Blot();
            Blot blot2 = null;

            Assign(blot1, blot2);

            blot1.Name = System.Console.ReadLine();

            /*FLOW:Flow_00075 - A points-to analysis taint propagation using an assign function:OS Command Injection:0+:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            System.Diagnostics.Process.Start(blot2.Name);
        }


        public void Assign(Blot b1, Blot b2)
        {
            b2 = b1;
        }
    }
}
