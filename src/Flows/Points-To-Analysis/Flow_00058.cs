using FlowBlot.Model;

namespace FlowBlot
{
    public class Flow_00058
    {
        public void Run()
        {
            string input = FlowBlot.Model.Framework.Source();

            A a = new A();
            a.b = input;

            G g = new H();
            A b = g.Id(a);

            /*FLOW:Flow_00058 - An interface based alias analysis taint propagation:codethreat.flowblot.benchmark:8:FIND_ISSUE:1:
              *STEP_PATH:ABC
              */
            FlowBlot.Model.Framework.Sink(b.b);
        }
    }
}
