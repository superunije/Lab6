using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class LogicExtended : Logic
    {
        private string? _name1;
        private string? _name2;

        public LogicExtended(bool a, bool b, string? name1, string? name2) : base(a, b)
        {
            _name1 = name1;
            _name2 = name2;
        }

        public LogicExtended(LogicExtended other) : base(other)
        {
            _name1 = other._name1;
            _name2 = other._name2;
        }

        public void Invert()
        {
            fstBool = !fstBool;
            sndBool = !sndBool;
        }

        public bool IsBothTrue()
        {
            return fstBool && sndBool;
        }

        public void SetValues(bool a, bool b)
        {
            fstBool = a;
            sndBool = b;
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
            return "Товар " + _name1 + " " + msg1 + ", товар " + _name2 + " " + msg2;
        }
    }
}
