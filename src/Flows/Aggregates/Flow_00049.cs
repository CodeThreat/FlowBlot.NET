﻿using System.Collections;

namespace FlowBlot
{
    public class Flow_00049
    {
        public const string ID = "00049";
        public const string Description = "An ArrayList taint propagation";
        public const bool IsVulnerable = true;

        public void Run()
        {
            string input = System.Console.ReadLine();
            ArrayList inputs = new ArrayList();
            inputs.Add(input);
            inputs.Add(string.Empty);
            inputs.Add(string.Empty);
            if (inputs != null && inputs.Count > 0)
            {
                /*FLOW:Flow_00049 - An ArrayList taint propagation:OS Command Injection:5:FIND_ISSUE:1:
                 *STEP_PATH:ABC
                 */
                System.Diagnostics.Process.Start(inputs[0].ToString());
            }
        }
    }
}