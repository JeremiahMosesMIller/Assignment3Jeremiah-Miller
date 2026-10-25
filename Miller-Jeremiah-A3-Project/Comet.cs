using MohawkGame2D;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Miller_Jeremiah_A3_Project
{
    public class Meteorite
    {

        float x = 0.0f;
            float y = 0.0f;

        float speed = 20.0f;
       public void setup()
        {

            speed = MohawkGame2D.Random.Float(30, 50);
            y = MohawkGame2D.Random.Float(50, 100);
        }

        public void update()
        {

          
           




           






        }
        void DrawComet()
        {
            //Comet

            int height = 50;
            int width = 10;
            x = 30;
            y = 30;

            Vector2 CometTrailLocation = new Vector2(x - 1, y - 30);
            Vector2 CometTrailBody = new Vector2(3, 5);

            Draw.FillColor = Color.White;
            Draw.Rectangle(CometTrailLocation, CometTrailBody);



            Vector2 CometLocation = new Vector2(x, y);
            Vector2 CometBody = new Vector2(width, height);

            Draw.FillColor = Color.LightGray;
            Draw.Ellipse(CometLocation, CometBody);

         

        }

    }
}