using System;
using System.Collections.Generic;
using System.Text;

namespace FlowBlot.Model
{
    public abstract class Machine
    {
        public abstract bool Start();
        public abstract bool Stop();
        public abstract void Pause();
        public abstract string SayName();
    }
}
