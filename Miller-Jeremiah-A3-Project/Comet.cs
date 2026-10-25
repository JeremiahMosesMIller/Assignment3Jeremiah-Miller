using MohawkGame2D;
using System;
using System.Numerics;

namespace Miller_Jeremiah_A3_Project
{
    public class Comet
    {
        

        float Comet1 = 30f;
        float x = 100.0f;
            float y = 30.0f;

        float speed = 20.0f;
       public void setup()
        {

            speed = MohawkGame2D.Random.Float(30, 50);
            x = MohawkGame2D.Random.Float(50, 350);
        }

        public void update()
        {

         



        }
        void DrawComet()
        {
            //Comet

            Vector2 offset = new Vector2(0, 0);

            int height = 50;
            int width = 10;
            x -= Time.DeltaTime * 30f;
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