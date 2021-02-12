using System.Collections.Generic;
using System.Reflection;

namespace FlowBlot
{
    public class Flow_00062
    {
        // This case, in fact, is neither true nor false. 
        // For soundiness, it will be handled as true. 

        public void Run()
        {
            string input = FlowBlot.Model.Framework.Source();

            Assembly flowAssembly = Assembly.LoadFile(@"flow.dll");
            System.Type flowAssemblyType = flowAssembly.GetType("Flow.Fetcher");

            object flowInstance = System.Activator.CreateInstance(flowAssemblyType);

            MethodInfo getMethod = flowAssemblyType.GetMethod("Get");

            List<object> arguments = new List<object>();
            arguments.Add(input);
            arguments.Add(System.String.Empty);

            object output = getMethod.Invoke(flowInstance, arguments.ToArray());

            /*FLOW:Flow_00062 - A reflection taint propagation:codethreat.flowblot.benchmark:7:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            FlowBlot.Model.Framework.Sink(output.ToString());
        }
    }
}
