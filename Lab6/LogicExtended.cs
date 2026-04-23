using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class LogicExtended : Logic
    {
        private string? _name;

        public LogicExtended(bool a, bool b, string? name) : base(a, b)
        {
            _name = name;
        }

        public LogicExtended(LogicExtended other) : base(other)
        {
            _name = other._name;
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
            return base.ToString() + ", Name = " + _name;
        }
    }
}
