

using FlowBlot.Model;

namespace FlowBlot.Flows
{
    public class Flow_00072
    {
        // a step towards soundness. not precise. trust level matters: medium|low

        public void Run()
        {
            string input = FlowBlot.Model.Framework.Source();
            IWeatherService weatherService = WeatherServiceFinder.FetchProvider();
            string passThrough = weatherService.GetWeatherData(input);

            /*FLOW:Flow_00072 - A 3rd-party code taint propagation:codethreat.flowblot.benchmark:6:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            FlowBlot.Model.Framework.Sink(passThrough);
        }
    }
}
