using MohawkGame2D;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MohawkGame2D
{

  
       

        
        

        


    }
    public class Meteorite
    {

  
         float x = 0.0f;
         float y = 0.0f;
         float speed = 20f;

     

        
     

        public void Setup ()
        {

        

        speed = MohawkGame2D.Random.Float(5, 15);

       x = MohawkGame2D.Random.Float(50, 100);
       y = MohawkGame2D.Random.Float(50, 100);


         

    }

        public void Update()
        {


            



    }


    void DrawMeteorite()
        {

        float meteorite = 0f;

        meteorite += Time.DeltaTime * 30f;

            Vector2 flamePosition1 = new Vector2(20, 10);
            Vector2 flamePosition2 = new Vector2(100, 60);
            Vector2 flamePosition3 = new Vector2(50, 40);

            Draw.SetFillColor(255, 255, 0);
            Draw.Triangle(flamePosition1, flamePosition2, flamePosition3);

            Vector2 flamePosition4 = new Vector2(50, 10);
            Vector2 flamePosition5 = new Vector2(100, 60);
            Vector2 flamePosition6 = new Vector2(50, 40);

            Draw.SetFillColor(255, 0, 0);
            Draw.Triangle(flamePosition4, flamePosition5, flamePosition6);


            Vector2 flamePosition7 = new Vector2(80, 40);
            Vector2 flamePosition8 = new Vector2(100, 60);
            Vector2 flamePosition9 = new Vector2(50, 40);

            Draw.SetFillColor(255, 255, 0);
            Draw.Triangle(flamePosition7, flamePosition8, flamePosition9);

            Vector2 flamePosition10 = new Vector2(20, 10);
            Vector2 flamePosition11 = new Vector2(100, 60);
            Vector2 flamePosition12 = new Vector2(50, 40);

            Draw.SetFillColor(255, 95, 21);
            Draw.Triangle(flamePosition10, flamePosition11, flamePosition12);

            //meteorite body
            Vector2 MeteoritePosition1 = new Vector2(90, 65);

            Draw.SetFillColor(30, 30, 20);
            Draw.Circle(MeteoritePosition1, 15);


            






        

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
