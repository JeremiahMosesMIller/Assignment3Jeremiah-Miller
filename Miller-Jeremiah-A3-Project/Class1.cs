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
            DrawMeteorite(10,10);



        }
        void DrawMeteorite(float x, float y)
        {
            //Flames

            Draw.SetFillColor(255, 255, 0);

            Vector3 flamePosition1 = new Vector3(20, 100, 50);

            Draw.SetFillColor(255, 0, 0);

            Vector3 flamePosition2 = new Vector3(50, 100, 50);

            Draw.SetFillColor(255, 255, 0);

            Vector3 flamePosition3 = new Vector3(80, 100, 50);

            Draw.SetFillColor(255, 95, 21);

            Vector3 flamePosition4 = new Vector3(100, 100, 50);

            Draw.SetFillColor(30, 30, 20);

            //meteorite body

            float meteoriteRadius = 15f;







        }


    }
}
