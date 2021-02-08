using System.Collections.Generic;
using System.Reflection;

namespace FlowBlot
{
    public class Flow_00062
    {
        public const string ID = "00062";
        public const string Description = "A reflection taint propagation";
        public const bool IsVulnerable = true; // This case, in fact, is neither true nor false. 
                                               // For soundiness, it will be handled as true. 

        public void Run()
        {
            string input = System.Console.ReadLine();

            Assembly flowAssembly = Assembly.LoadFile(@"flow.dll");
            System.Type flowAssemblyType = flowAssembly.GetType("Flow.Fetcher");

            object flowInstance = System.Activator.CreateInstance(flowAssemblyType);

            MethodInfo getMethod = flowAssemblyType.GetMethod("Get");

            List<object> arguments = new List<object>();
            arguments.Add(input);
            arguments.Add(System.String.Empty);

            object output = getMethod.Invoke(flowInstance, arguments.ToArray());

            /*FLOW:Flow_00062 - A reflection taint propagation:OS Command Injection:9:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            System.Diagnostics.Process.Start(output.ToString());
        }
    }
}
