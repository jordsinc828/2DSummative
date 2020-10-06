using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _2DSummative
{
    class Boxes
    {

        public int x, y, sizeW, sizeH, speed;

        public Boxes(int _x, int _y, int _sizeW, int _sizeH, int _speed)
        {

            x = _x;
            y = _y;
            sizeW = _sizeW;
            sizeH = _sizeH;
            speed = _speed;
        }

        public void Move()
        {
            sizeH += speed;
        }


        public Boolean Collision(Boxes b)
        {
            Rectangle boxRec = new Rectangle(b.x, b.y, b.sizeW, b.sizeH);
            Rectangle heroRec = new Rectangle(x, y, 10, 10);

            return boxRec.IntersectsWith(heroRec);
        }



    }
}
