using FlowBlot.Model;

namespace FlowBlot
{
    public class Flow_00061
    {
        public void Run()
        {
            string input = FlowBlot.Model.Framework.Source();

            MProxy proxy = new MProxy();
            MProxy.Fetch fetchDelegate = new MProxy.Fetch(proxy.FetchNoPropagate);
            string output = fetchDelegate(input);


            /*FLOW:Flow_00061 - A delegate FP taint propagation:codethreat.flowblot.benchmark:6:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            FlowBlot.Model.Framework.Sink(output);
        }
    }
}
