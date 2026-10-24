using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MohawkGame2D
{

    public class Meteorite
    {
        Meteorite meteorite1 = new Meteorite();

        float y = 0.0f;
        float x = 0.0f;
        float speed = 20.0f;

        Vector2 direction = new Vector2(0, 0);


    }
    public class Class1
    {

        void DrawMeteorite(float x, float y)
        {
            //Flames

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







        }
    }
}
