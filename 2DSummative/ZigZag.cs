using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DSummative
{
    class ZigZag
    {

        public int x, y, sizeW, sizeH, speedX, speedY;

        public ZigZag(int _x, int _y, int _sizeW, int _sizeH, int _speedX, int _speedY)
        {

            x = _x;
            y = _y;
            sizeW = _sizeW;
            sizeH = _sizeH;
            speedX = _speedX;
            speedY = _speedY;

        }

        public void Zig()
        {
            x += speedX;
            y += speedY;
        }
    }
}
