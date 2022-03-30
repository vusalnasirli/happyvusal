using System;
using System.Collections.Generic;
using System.Text;

namespace hometask1.MODELS
{
    class Square : Figure
    {
        private int _side;
        public int Side
        {
            get
            {
                return _side;
            }
            set
            {
                if ( value >=0)
                {
                    _side =value;
                }
            }
        }
        public Square( int _side)
        {
            this._side = _side;
        }


        public override int CalcArea()
        {
            int result = _side * _side;
            return result;
        }

        
    }

      
}
