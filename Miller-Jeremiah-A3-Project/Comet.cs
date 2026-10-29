using MohawkGame2D;
using System;
using System.Numerics;

namespace MohawkGame2D
{
    public class Comet
    {
        float x = 100.0f;
        float y = 30.0f;

        float speed = 20.0f;


        public void Setup()
        {

          

        }

        public void Update()
        {
            DrawComet();

           

        }

        void RandomizeNewComet()
        {
            speed = MohawkGame2D.Random.Float(y += Time.DeltaTime * 100f, y += Time.DeltaTime * 200f);
            x = MohawkGame2D.Random.Float(20, 380);
           
        }

        void DrawComet()
        {
            //Comet

            Vector2 offset = new Vector2(0, 0);

            int height = 20;
            int width = 10;
            x += Time.DeltaTime * 0f; 
            y += Time.DeltaTime * 400f;

            Vector2 CometTrailLocation = new Vector2(x - 3, y - 25);
            Vector2 CometTrailBody = new Vector2(5, 15);

         

            Draw.SetFillColor(255, 0, 0);
            Draw.Rectangle(CometTrailLocation, CometTrailBody);

       



            Vector2 CometLocation = new Vector2(x, y);
            Vector2 CometBody = new Vector2(width, height);

            Draw.SetFillColor(55, 54, 54);
            Draw.Ellipse(CometLocation, CometBody);


            if (y > 420)
            {
                y = -50;


                RandomizeNewComet();
            }

            //getting somewhere. Ask how to make it work in the 'Comet Class'


        }

    }
}