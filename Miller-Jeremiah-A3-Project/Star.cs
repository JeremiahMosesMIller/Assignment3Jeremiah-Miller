using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace MohawkGame2D
{
    public class Star
    {
        int x = 0;
        int y = 0;
        public void Setup()
        {
            x = Random.Integer(0, 400);
            y = Random.Integer(0,200);
        }
        public void Update()
        {
           
            Drawstar();
        }



        void Drawstar()
        {

            
            Draw.SetFillColor(255, 255, 255);
            Draw.Circle(x, y, 4);
            Draw.SetFillColor(20);
            Draw.Circle(x, y, 2);



        }

    }
}
