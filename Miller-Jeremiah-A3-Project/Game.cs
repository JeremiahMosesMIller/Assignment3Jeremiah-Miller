// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    /// 

    public class Game
    {
       


        public void Setup()
        {

            Window.SetSize(400, 400);
            Window.ClearBackground(20);
            
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()

            

        {
            Window.ClearBackground(Color.Black);
         
            // stars
            int size = 10;
           int x = Input.GetMouseX();
            int y = 0;

            
         


           
            Draw.SetFillColor(0, 0, 210);
            Draw.Square(x, y, size);
            Drawstars(x + 20, y + 20);
            Drawstars(x + 23, y + 58);
            Drawstars(x + 47, y + 86);
            Drawstars(x + 23, y + 20);
            Drawstars(x + 88, y + 94);
            Drawstars(x + 17, y + 38);
            Drawstars(x + 380, y + 32);
            Drawstars(x + 350, y + 76);
            Drawstars(x + 230, y + 40);
            Drawstars(x + 270, y + 49);
            Drawstars(x + 286, y + 58);
            Drawstars(x - 20, y + 20);
            Drawstars(x - 23, y + 58);
            Drawstars(x - 47, y + 86);
            Drawstars(x - 54, y + 77);
            Drawstars(x - 74, y + 22);
            Drawstars(x - 17, y + 38);
            Drawstars(x - 300, y + 47);
            Drawstars(x - 239, y + 81);
            Drawstars(x - 230, y + 71);
            Drawstars(x - 270, y + 41);
            Drawstars(x - 286, y + 58);

          
                
             


            // if (Input.IsKeyboardKeyDown(KeyboardKey.Space))
            //{
            //    Drawstars(x, y, size);
            //   x = Random.Float(3, 3);
            //   y = Random.Float(3, 4);
            //  }

            //I initially wanted the stars position to be randomized each time you booted the game up. iwas going to use the space bar to trigger,
            //it as I could not figure out how to do it on it's own.
            //I could not get it down so ultimately I've decided to hand place them.




            //Meteorite Flames

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









            //Floor
            Draw.SetFillColor(165, 42, 42);

            Draw.Rectangle(0, 380, 400, 20);

        }

        //CURRENT GOALS! Figure out how to actually use the function so that the trees can be placed. Also learn how to make meteorite move from the left to rightside of the Screen

        // SO messing around while watching Thursday's Lesson, I realised that topRectPosition just means rectangle position, or so I think. 
        //I applied the same logic to Triangles, realizing that I might be able to use the same logic with Vector3 (idk what that is either tbh, just messing around.)

        Vector2 offset = new Vector2(0, 0); 

            Vector3 TriPosition = new Vector3(20, 100, 50);

        //while I initially waa going to add a vector to everything, I'm guessing I don't need to.
        //because I'll only have one meteorite at a time on screen.




        void Drawstars(int x, int y)
        {


            Draw.SetFillColor(0, 0, 210);
            Draw.Square(x, y, 10);
        }




        void DrawMeteorite(float x, float y)
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


