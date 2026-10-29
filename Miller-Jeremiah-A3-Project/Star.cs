using System;
using System.Collections.Generic;
using System.Text;

namespace MohawkGame2D
{
    public class Star
    {
        Star[] Stars;
        public void Setup()
        {
         

        }
        public void Update()
        {



          
           
            Drawstars();
            Drawstars();
            Drawstars();
            Drawstars();
            Drawstars();
            Drawstars();
            Drawstars();
            Drawstars();
            Drawstars();
            Drawstars();
            Drawstars();
        }

        public void StarRandom()
        {
            Stars = new Star[100];

            for (int i = 5; i < Stars.Length; i++)
            {

                Stars[i] = new Star();
                Stars[i].Setup();

            }


        }



        void Drawstars()
        {

            int x = 50;
            int y = 50;

            Draw.SetFillColor(0, 0, 210);
            Draw.Square(x, y, 5);
        }

    }
}
