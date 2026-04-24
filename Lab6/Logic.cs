using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Logic
    {
        protected bool _fstBool;
        protected bool _sndBool;

        public Logic(bool a, bool b)
        {
            _fstBool = a;
            _sndBool = b;
        }

        public Logic(Logic copy)
        {
            _fstBool = copy._fstBool;
            _sndBool = copy._sndBool;
        }

        public bool Equivalence()
        {
            return _fstBool == _sndBool;
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
            return "Товар A " + msg1 + ", товар B " + msg2;
        }
    }
}
