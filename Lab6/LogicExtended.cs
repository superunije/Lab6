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

        public LogicExtended(LogicExtended copy) : base(copy)
        {
            _name1 = copy._name1;
            _name2 = copy._name2;
        }

        public void Invert()
        {
            _fstBool = !_fstBool;
            _sndBool = !_sndBool;
        }

        public bool IsBothTrue()
        {
            return _fstBool && _sndBool;
        }

        public void SetValues(bool a, bool b)
        {
            _fstBool = a;
            _sndBool = b;
        }

        public override string ToString()
        {
            string msg1 = "не в наличии";
            string msg2 = "не в наличии";
            if (_fstBool)
            {
                msg1 = "в наличии";
            }
            if (_sndBool)
            {
                msg2 = "в наличии";
            }
            return "Товар " + _name1 + " " + msg1 + ", товар " + _name2 + " " + msg2;
        }
    }
}
