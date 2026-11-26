// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("platformer game");
            Window.SetSize(1920, 1080);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(255, 255, 255);

            Level_1 level = new Level_1();
            Collision[] hitboxes = new Collision[level.platforms_1.Length];

            level.Update();

            for (int i = 0; i < hitboxes.Length; i++)
            {
                hitboxes[i] = new Collision();
                hitboxes[i].position = level.platforms_1[i].position;
                hitboxes[i].size = level.platforms_1[i].size;

                hitboxes[i].Update();
            }



            //Collision[] hitboxes = new Collision[1];
            //for (int i = 0; i < hitboxes.Length; i++)
            //{
               // hitboxes[i] = new Collision();
                //hitboxes[i].position = new Vector2((Window.Size.X / 2), (Window.Size.Y / 2));
                //hitboxes[i].size = new Vector2((Window.Size.X / 2), (Window.Size.Y / 2));

                //hitboxes[i].Update();
            //}
        }
    }

}
