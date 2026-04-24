using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Logic
    {
        protected bool fstBool;
        protected bool sndBool;

        public Logic(bool a, bool b)
        {
            fstBool = a;
            sndBool = b;
        }

        public Logic(Logic copy)
        {
            fstBool = copy.fstBool;
            sndBool = copy.sndBool;
        }

        public bool Equivalence()
        {
            return fstBool == sndBool;
        }

        public override string ToString()
        {
            string msg1 = "не в наличии";
            string msg2 = "не в наличии";
            if (fstBool)
            {
                msg1 = "в наличии";
            }
            if (sndBool)
            {
                msg2 = "в наличии";
            }
            return "Товар A " + msg1 + ", товар B " + msg2;
        }
    }
}
