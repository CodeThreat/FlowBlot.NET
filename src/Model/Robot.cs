using System;
using System.Collections.Generic;
using System.Text;

namespace FlowBlot.Model
{
    public class Robot : Machine
    {
        public string name { get; set; }

        public override string SayName()
        {
            return "My name is " + this.name;
        }

        public override bool Start()
        {
            return true;
        }

        public override bool Stop()
        {
            throw new NotImplementedException();
        }

        public override void Pause()
        {
            name = FlowBlot.Model.Framework.Source();
        }
    }
}
