using System;
using System.Collections.Generic;
using System.Text;

namespace hometask1.MODELS
{
    class Rectangular : Figure
    {
        private int _width;
        private int _length;
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value >= 0)
                {
                    _width = value;
                }
            }
        }
        public int Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value >= 0)
                {
                    _length = value;
                }
            }
        }

        public Rectangular(int _width, int _length)
        {
            this._width = _width;
            this._length = _length;
        }

        public override int CalcArea()
        {
            int result = _width * _length;
            return result;
        }
    }
}
