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
        Comet Comet2 = new Comet();
        Star star1 = new Star();
        Meteorite Meteorite1 = new Meteorite();
        
        Star[] Stars;


        public void Setup()
        {
            Window.SetSize(400, 400);

            Comet1.Setup();
            Comet2.Setup();
            Meteorite1.Setup();
            star1.Setup();

            StarRandom();
          
        }
        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(3);
            Comet1.Update();
            Comet2.Update();
            Meteorite1.Update();
            star1.Update();
            //something I realized is you kinda need the Class1.Update in your files for it to work. Which is kinda the main thing I think I had difficulty with
            for (int i = 0; i < Stars.Length; i++)
            {
                Stars[i].Update();
            }

            

            DrawTree(200 + 50, 0);
            //Floor
            Draw.SetFillColor(100, 110, 100);

            Draw.Rectangle(0, 380, 400, 20);
        }
        //getting somewhere. Ask how to make it work in the 'Comet Class'
       // Tree 
        //as far as I understand, and I am most likely wrong, is when you use int it acts like 'memory' in the sense that if you have int x = 70, if you type x while doing positions
        //it'll appear at 70. 
        void DrawTree(int x, int y)
        {

            Draw.SetFillColor(54, 55, 55);
            Draw.Rectangle(200, 200, 40, 180);

            Draw.SetFillColor(100, 110, 100);
            Draw.Circle(180, 180, 60);
            Draw.Circle(260, 120, 50);

            Draw.SetFillColor(100, 110, 100);
            Draw.Circle(220, 180, 80);
           


        }

        public void StarRandom()
        {
            Stars = new Star[100];

            for (int i = 0; i < Stars.Length; i++)
            {

                Stars[i] = new Star();
                Stars[i].Setup();



            }


        }





    }
}


