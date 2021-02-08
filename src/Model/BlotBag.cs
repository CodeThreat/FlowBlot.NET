using System;
using System.Collections.Generic;
using System.Text;

namespace FlowBlot.Model
{
    public class BlotBag
    {
        private List<Blot> blots;

        public BlotBag()
        {
            blots = new List<Blot>();
        }

        public void Put(Blot aBlot)
        {
            blots.Add(aBlot);
        }

        public Blot GetFirst()
        {
            if (blots.Count > 0)
            {
                return blots[0];
            }

            return null;
        }
    }
}
