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

            
            

         

            Draw.SetFillColor(69, 69, 69);

            Draw.Triangle(Input.GetMouseX() + 20, Input.GetMouseY() + 10, Input.GetMouseX() + 100, Input.GetMouseY() + 60, Input.GetMouseX() +50, Input.GetMouseY() + 40);

            Draw.SetFillColor(255, 255, 255);

            Draw.Triangle(Input.GetMouseX() + 50, +Input.GetMouseY() + 10, Input.GetMouseX() + 100, +Input.GetMouseY() + 60, Input.GetMouseX() + 50, Input.GetMouseY() + 40);

            Draw.SetFillColor(50,50,50);

            Draw.Triangle(Input.GetMouseX() + 80, Input.GetMouseY() + 40, Input.GetMouseX() + 100, Input.GetMouseY() + 60, Input.GetMouseX() + 50, Input.GetMouseY() + 40);

            Draw.SetFillColor(255, 255, 255);

            Draw.Triangle(Input.GetMouseX() + 100, Input.GetMouseY() + 60, Input.GetMouseX() + 100, Input.GetMouseY() + 80, Input.GetMouseX() + 50, Input.GetMouseY() + 40);

            Draw.SetFillColor(30, 30, 20);



            //meteorite body

            Draw.Circle(Input.GetMouseX() + 90, Input.GetMouseY() + 60, 25);



            //Think my main goal will be to just get the objects done., then I can focus on getting the meteorite to move

            

        }



        //WOOOORRRRRRRRRRRRRRKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK

    }
}
