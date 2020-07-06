using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowBlot.Model
{
    public class A
    {
        public String b = "Y";
    }

    public class B
    {
        public A attr;
    }

    public class C
    {
        public String x = String.Empty;
    }

    public class D
    {
        public String x = String.Empty;
    }

    public class E
    {
        D d = null;

        public E(D d)
        {
            this.d = d;
        }

        public void ReInitialize(D d)
        {
            this.d = d;
        }

        public D Get()
        {
            return d;
        }
    }

    public class F : E
    {
        public F(D d) : base(d)
        {
        }
    }

    interface G
    {
        A Id(A a);
    }

    public class H : G
    {
        public A Id(A a)
        {
            return a;
        }
    }

    public class N
    {
        public string n = String.Empty;
    }

    public class M:N
    {
    }

    public class O:N
    {
    }
}
