using FlowBlot.Model;

namespace FlowBlot.Flows
{
    public class Flow_00043
    {
        public const string ID = "00043"; 
        public const string Description = "A model pass-through taint propagation";
        public const bool IsVulnerable = true;

        public void Run()
        {
            Blot blot = new Blot();
            string input = System.Console.ReadLine();
            blot.Name = input;
            Method1(blot);


            /*FLOW:Flow_00043 - A model pass-through taint propagation:OS Command Injection:15:FIND_ISSUE:2:
             *STEP_PATH:ABC
             */
            System.Diagnostics.Process.Start(blot.Name);
        }

        public void Method1(System.Object myobj)
        {
            // log myobj
            string s = Method2(myobj);
        }

        public string Method2(System.Object myobj)
        {
            return System.String.Format("LOG {0}/{1}", myobj.ToString(), "");
        }
    }
}
