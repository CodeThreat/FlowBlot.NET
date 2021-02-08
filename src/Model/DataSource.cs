using System;
using System.Collections.Generic;
using System.Text;

namespace FlowBlot.Model
{
    public class DataSource
    {
        private string url;
        public DataSource(string url)
        {
            this.url = url;
        }

        public string getUrl()
        {
            return this.url;
        }
    }
}
