using MohawkGame2D;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MohawkGame2D
{

    public class Meteorite
    {
       

        float y = 0.0f;
        float x = 0.0f;
        float speed = 20.0f;

        Vector2 direction = new Vector2(0, 0);

        


    }
    public class Class1
    {

        public void Setup ()
        {

            

        }

        public void Update()
        {
            
            DrawMeteorite(100, 80);



        }
        void DrawMeteorite(float x, float y)
        {

            Draw.SetFillColor(255, 255, 0);

            Draw.Triangle(x, 10, y, 60, x, 40);

            Draw.SetFillColor(255, 0, 0);

            Draw.Triangle(50, 10, 100, 60, 50, 40);

            Draw.SetFillColor(255, 255, 0);

            Draw.Triangle(80, 40, 100, 60, 50, 40);

            Draw.SetFillColor(255, 95, 21);

            Draw.Triangle(100, 60, 100, 80, 50, 40);

            Draw.SetFillColor(30, 30, 20);

            //meteorite body

            Draw.Circle(new Vector2(90, 65), 15);





        }


    }
}

//I had this for a while why I tried using Triangles with Vectors. I know you have 6 floats for a single triangle but there isn't a Vector6 that I'm aware of so I gave up on this path

//Flames

//Draw.SetFillColor(255, 255, 0);

//Vector3 flamePosition1 = new Vector3(20, 100, 40);
//Draw.SetFillColor(255, 0, 0);

//Vector3 flamePosition2 = new Vector3(50, 100, 0);

//Draw.SetFillColor(255, 255, 0);

//Vector3 flamePosition3 = new Vector3(80, 100, 5);

//Draw.SetFillColor(255, 95, 21);

//Vector3 flamePosition4 = new Vector3(100, 100, 0);

//Draw.SetFillColor(30, 30, 20);

//meteorite body

//float meteoriteRadius = 15f;
