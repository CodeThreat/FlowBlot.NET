using FlowBlot.Model;

namespace FlowBlot
{
    public class Flow_00060
    {
        public void Run()
        {
            string input = FlowBlot.Model.Framework.Source();

            MProxy proxy = new MProxy();
            MProxy.Fetch fetchDelegate = new MProxy.Fetch(proxy.FetchPropagate);
            string output = fetchDelegate(input);

            /*FLOW:Flow_00060 - A delegate taint propagation:codethreat.flowblot.benchmark:6:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            FlowBlot.Model.Framework.Sink(output);
        }


    }
}
