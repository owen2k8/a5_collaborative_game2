using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MohawkGame2D
{

    public class Level_1
    {
        public Platform[] platforms_1 = new Platform[2];

        public void Visualize()
        {
            for (int i = 0; i < platforms_1.Length; i++)
            {
                platforms_1[i] = new Platform();

                if (i == 0)
                {
                    platforms_1[i].position = new Vector2(Window.Size.X / 2, Window.Size.Y / 2);
                    platforms_1[i].size = new Vector2(Window.Size.X / 2, Window.Size.Y / 2);
                }
                else if (i == 1)
                {
                    platforms_1[i].position = new Vector2(0, 0);
                    platforms_1[i].size = new Vector2(Window.Size.X / 2, Window.Size.Y / 2);
                }
            }
        }

        public void Update()
        {
            Visualize();
        }

    }

    public class Platform
    {
        public Vector2 position = new Vector2();
        public Vector2 size = new Vector2();
    }

}
