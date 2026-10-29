using System.Numerics;


namespace MohawkGame2D
{
    public class Meteorite
    {



      



        public void Setup()
        {

            DrawMeteorite();

        }
        public void Update()
        {



        }
        void DrawMeteorite(float x = 1f, float y = 1f)
        {
            //Flames



            Vector2 offset = new Vector2(0, 0);

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

            x += Time.DeltaTime * 60f;
            y += Time.DeltaTime * 60f;


            //Think my main goal will be to just get the objects done., then I can focus on getting the meteorite to move



        }



        //WOOOORRRRRRRRRRRRRRKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK

    }
}
