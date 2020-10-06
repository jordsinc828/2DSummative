using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DSummative
{
    class FallBox
    {

        public int x, y, sizeW, sizeH, speed;

        public FallBox(int _x, int _y, int _sizeW, int _sizeH, int _speed)
        {

            x = _x;
            y = _y;
            sizeW = _sizeW;
            sizeH = _sizeH;
            speed = _speed;

        }

        public void Fall()
        {
            y += speed;
        }
    }
}
