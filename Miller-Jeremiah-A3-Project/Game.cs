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
        float y = 0.0f;
        float x = 0.0f;
        float speed = 20.0f;

        public void Setup()
        {

            Window.SetSize(400, 400);
            Window.ClearBackground(20);
            float y = 0.0f;
                float x = 0.0f;
            float speed = 20.0f;
            speed = Random.Float(15, 50);
         
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
           
            void DrawApple(int x, int y, int height, int width)
                {


                Draw.Circle(200, 200, 30);
            Draw.SetFillColor(30, 30, 20);

            Draw.Rectangle(195, 160, 10, 25);
             Draw.SetFillColor(100, 0, 0);

                x = 50;
             

            }

            

        }
    }

}
