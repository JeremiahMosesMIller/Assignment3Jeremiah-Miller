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
        Meteorite Meteorite1 = new Meteorite();
       

        public void Setup()
        {
            Window.SetSize(400, 400);

            Comet1.Setup();
            Meteorite1.Setup();
            
          
        }
        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(20);
            Comet1.Update();
            Meteorite1.Update();


         

            DrawTree(200 + 50, 0);
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


