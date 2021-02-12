using FlowBlot.Model;

namespace FlowBlot.Flows
{
    public class Flow_00043
    {
        public void Run()
        {
            Blot blot = new Blot();
            string input = FlowBlot.Model.Framework.Source();
            blot.Name = input;
            Method1(blot);

            /*FLOW:Flow_00043 - A model pass-through taint propagation:codethreat.flowblot.benchmark:16:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            FlowBlot.Model.Framework.Sink(blot.Name);
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
