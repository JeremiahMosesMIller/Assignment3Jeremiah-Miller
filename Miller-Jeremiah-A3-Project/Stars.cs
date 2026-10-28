using MohawkGame2D;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Numerics;
using System.Text;

namespace MohawkGame2D
{
    public class Stars
    {
        public static int Length { get; private set; }

        public void Setup()
        {

        }
        public void Update()
        {

            float[] xcoords = new float[10];
            int[] x = [50, 60, 70, 100, 120, 170, 200, 233, 240, 275, 289, 300, 312, 323, 339, 341, 351, 362, 369,370, 389, 399];

            float[] ycoords = new float[10];
            int[] y = [50, 60, 70, 100, 120, 170, 200, 233, 240, 275, 289, 300, 312, 323, 339, 341, 351, 362, 369, 370, 389, 399];



        }


        // stars
        void Drawstars(int x, int y, int size)
        {
            Vector2 Star = new Vector2(x, y);
            Draw.SetFillColor(0, 0, 210);
            Draw.Square(x, y, 10);

            for (int i = 20; i < Stars.Length; i++)
            {
                float[] xcoords = new float[10];

                float[] ycoords = new float[10];

            }
        }


    }
}
