// Include the namespaces (code libraries) you need below.
using Miller_Jeremiah_A3_Project;
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
        Comet Comet1 = new Comet();
        float x = 100.0f;
        float y = 30.0f;

        float speed = 20.0f;
        


        public void Setup()
        {

            speed = MohawkGame2D.Random.Float(30, 50);
            x = MohawkGame2D.Random.Float(50, 350);
            Window.SetSize(400, 400);

            Comet1.setup();
            
          
            }
        


      
        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()

            
            


        {

            Comet1.update();

          
          


            Window.ClearBackground(20);

          

            // stars
            int size = 10;
           int x = Input.GetMouseX();
            int y = 0;


            DrawComet();
            

            //
            DrawTree(x + 50, y);








            // ON the verge of giving up, I used this  DrawTree(x + 80, y); beneath DrawTree(x + 50, y); ALl it did was make the trunk green?????

           

          



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













            //Floor
            Draw.SetFillColor(165, 42, 42);

            Draw.Rectangle(0, 380, 400, 20);



          
            

        }


       

          

       
       
        
           
       

          


        



        void Drawstars(int x, int y)
        {


            Draw.SetFillColor(0, 0, 210);
            Draw.Square(x, y, 10);
        }




        void DrawComet()
        {
            //Comet

            Vector2 offset = new Vector2(0, 0);

            int height = 50;
            int width = 10;
            x = 30f;
            y += Time.DeltaTime * 30f;

            Vector2 CometTrailLocation = new Vector2(x - 1, y - 30);
            Vector2 CometTrailBody = new Vector2(3, 5);

            Draw.FillColor = Color.White;
            Draw.Rectangle(CometTrailLocation, CometTrailBody);



            Vector2 CometLocation = new Vector2(x, y);
            Vector2 CometBody = new Vector2(width, height);

            Draw.FillColor = Color.LightGray;
            Draw.Ellipse(CometLocation, CometBody);


            if (y > 420)
            {
                y = -50;

            }

            //getting somewhere. Ask how to make it work in the 'Comet Class'
           

        }
















        // Tree 

        //as far as I understand, and I am most likely wrong, is when you use int it acts like 'memory' in the sense that if you have int x = 70, if you type x while doing positions
        //it'll appear at 70. 
        void DrawTree(int x, int y)
            {

            Draw.SetFillColor(101, 67, 33);
            Draw.Rectangle(200, 200, 40, 180);
     
          
           



            Draw.SetFillColor(1, 50, 32);
            Draw.Circle(220, 180, 80);

      

               
            }

        







        }
    }


