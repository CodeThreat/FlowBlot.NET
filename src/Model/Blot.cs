using System;

namespace FlowBlot.Model
{
    public class Blot
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DoC { get; set; }
        public float Amount { get; set; }
        public bool IsColored { get; set; }

        string label { get; set; }
        public string Label
        {
            get
            {
                return this.label;
            }
            set
            {
                this.label = value + FlowBlot.Model.Framework.Source();
            }
        }

        string viscosity { get; set; }
        public string Viscosity
        {
            get
            {
                return this.viscosity;
            }
            set
            {
                this.viscosity = "default";
            }
        }
    }
}
