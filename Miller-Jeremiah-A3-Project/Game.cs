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

            //CURRENT GOALS! Figure out how to actually use the function so that the trees can be placed. Also learn how to make meteorite move from the left to rightside of the Screen

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

            //Think my main goal will be to just get the objects done., then I can focus on getting the meteorite to move

            //Floor
            Draw.SetFillColor(165, 42, 42);

            Draw.Rectangle(0, 380, 400, 20);

            
           
            }







// Tree 
            void DrawTree(int x, int y)
            {
                Draw.SetFillColor(101, 67, 33);

                Draw.Rectangle(0, 160, 50, 240);

                Draw.SetFillColor(1, 50, 32);

                Draw.Rectangle(0, 220, 120, 60);

                Draw.SetFillColor(1, 50, 32);

                Draw.Rectangle(0, 160, 100, 60);
            }







        }
    }


