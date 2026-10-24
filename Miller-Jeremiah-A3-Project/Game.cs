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

            // SO messing around while watching Thursday's Lesson, I realised that topRectPosition just means rectangle position, or so I think. 
            //I applied the same logic to Triangles, realizing that I might be able to use the same logic with Vector3 (idk what that is either tbh, just messing around.)

            Vector2 offset = new Vector2(0, 0); 

            Vector3 TriPosition = new Vector3(20, 100, 50);

            //while I initially waa going to add a vector to everything, I'm guessing I don't need to.
            //because I'll only have one meteorite at a time on screen.



            void DrawMeteorite(int x, int y)
            {
                //Flames

                Draw.SetFillColor(255, 255, 0);

            Draw.Triangle(20, 10, 100, 60, 50, 40);

            Draw.SetFillColor(255, 0, 0);

            Draw.Triangle(50, 10, 100, 60, 50, 40);

            Draw.SetFillColor(255, 255, 0);

            Draw.Triangle(80, 40, 100, 60, 50, 40);

            Draw.SetFillColor(255, 95, 21);

            Draw.Triangle(100, 60, 100, 80, 50, 40);

            Draw.SetFillColor(30, 30, 20);

            //meteorite body

            Draw.Circle(new Vector2(90, 65), 15);

            

            //Think my main goal will be to just get the objects done., then I can focus on getting the meteorite to move

            //Floor
            Draw.SetFillColor(165, 42, 42);

            Draw.Rectangle(0, 380, 400, 20);

            }

        }





        

// Tree 

        //as far as I understand, and I am most likely wrong, is when you use int it acts like 'memory' in the sense that if you have int x = 70, if you type x while doing positions
        //it'll appear at 70. 
            void DrawTree(int x = 50, int y = 180)
            {

           
                Draw.SetFillColor(101, 67, 33);

                Draw.Rectangle(new Vector2(x, y), new Vector2(50, 180));

                Draw.SetFillColor(1, 50, 32);

                Draw.Rectangle(new Vector2(x - 220, y), new Vector2(120, 60));

                Draw.SetFillColor(1, 50, 32);

                Draw.Rectangle(new Vector2(x, y), new Vector2(100, 60));
            }

        







        }
    }


