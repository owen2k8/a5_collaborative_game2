using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MohawkGame2D
{
    public class Collision
    {

        public Vector2 position = new Vector2(0, 0);
        public Vector2 size = new Vector2(0, 0);


        public void Update()
        {
            Draw.Rectangle(position, size);
        }

    }

}
