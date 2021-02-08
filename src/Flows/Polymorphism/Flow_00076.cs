using FlowBlot.Model;

namespace FlowBlot.Flows
{
    public class Flow_00076
    {
        public const string ID = "00076"; 
        public const string Description = "An inheritance based taint propagation";
        public const bool IsVulnerable = false;

        public void Run()
        {
            Robot robot = new Robot();
            robot.Pause();
        }

        public void PauseMachine(Machine machine)
        {
            machine.Pause();
            string name = machine.SayName();

            /*FLOW:Flow_00076 - An inheritance based taint propagation:OS Command Injection:0:NONE:0:
             *STEP_PATH:ABC
             */
            System.Diagnostics.Process.Start(name);
        }
    }
}
