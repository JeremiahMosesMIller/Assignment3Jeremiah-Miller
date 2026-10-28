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
        Comet Comet1 = new Comet();
        Stars Stars1 = new Stars();
   



        public void Setup()
        {

         
            Window.SetSize(400, 400);

            Comet1.Setup();


            Stars[] Stars = new Stars[100];

            for (int i = 0; i < Stars.Length; i++)
            {
                Stars[i] = new Stars();

                Stars[i].Setup();
            }


        }




        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()





        {

           
            Window.ClearBackground(20);

            Comet1.Update();
        




            // stars
            int size = 10;
            int x = Input.GetMouseX();
            int y = 0;

        


            //
            DrawTree(x + 50, y);








            // ON the verge of giving up, I used this  DrawTree(x + 80, y); beneath DrawTree(x + 50, y); ALl it did was make the trunk green?????










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



       










        //getting somewhere. Ask how to make it work in the 'Comet Class'








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


