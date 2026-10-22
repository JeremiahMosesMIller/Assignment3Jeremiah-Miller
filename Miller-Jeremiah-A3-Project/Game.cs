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

            void DrawMeteorite(int x, int y)
            {
                Draw.SetFillColor(255, 255, 0);

            Draw.Triangle(20, 10, 100, 60, 50, 40);

            Draw.SetFillColor(255, 0, 0);

            Draw.Triangle(50, 10, 100, 60, 50, 40);

            Draw.SetFillColor(255, 255, 0);

            Draw.Triangle(80, 40, 100, 60, 50, 40);

            Draw.SetFillColor(255, 95, 21);

            Draw.Triangle(100, 60, 100, 80, 50, 40);

            Draw.SetFillColor(30, 30, 20);

            Draw.Circle(90, 65, 15);

            }













        }
    }

}
