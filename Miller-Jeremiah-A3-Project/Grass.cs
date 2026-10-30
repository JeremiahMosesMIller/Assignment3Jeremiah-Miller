using System;
using System.Collections.Generic;
using System.Text;

namespace MohawkGame2D
{
    public class Grass
    {
        int x = 0;
        int y = 0;
        public void Setup()
        {
            x = Random.Integer(0, 400);
            y = Random.Integer(370);
        }
        public void Update()
        {

            DrawGrass();
            
        }
     void DrawGrass()
        {
            Draw.SetFillColor(100, 110, 100);
            Draw.Rectangle(x, 370, 5, 20);
        }
    }
}
