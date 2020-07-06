using System;
using System.Collections.Generic;
using System.Text;

namespace FlowBlot.Model
{
    public class Atlas : Robot
    {

        public string DoParkour()
        {
            return this.name;
        }

        public override bool Start()
        {
            return true;
        }

        public override bool Stop()
        {
            throw new NotImplementedException();
        }
    }
}
