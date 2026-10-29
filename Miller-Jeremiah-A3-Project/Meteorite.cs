using System.Numerics;


namespace MohawkGame2D
{
    public class Meteorite
    {



      



        public void Setup()
        {

          

        }
        public void Update()

        {

            DrawMeteorite();
        }
        void DrawMeteorite()
        {
            //Flames

            
            

            Vector2 offset = new Vector2(0, 0);

            Draw.SetFillColor(255, 255, 0);

            Draw.Triangle(20, 10, 100, 60, Input.GetMouseX(), Input.GetMouseY());

            Draw.SetFillColor(255, 0, 0);

            Draw.Triangle(50, 10, 100, 60, Input.GetMouseX(), Input.GetMouseY());

            Draw.SetFillColor(255, 255, 0);

            Draw.Triangle(80, 40, 100, 60, Input.GetMouseX(), Input.GetMouseY());

            Draw.SetFillColor(255, 95, 21);

            Draw.Triangle(100, 60, 100, 80, Input.GetMouseX(), Input.GetMouseY());

            Draw.SetFillColor(30, 30, 20);



            //meteorite body

            Draw.Circle(new Vector2(Input.GetMouseX(), Input.GetMouseY()), 15);

         

            //Think my main goal will be to just get the objects done., then I can focus on getting the meteorite to move



        }



        //WOOOORRRRRRRRRRRRRRKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK

    }
}
