using MohawkGame2D;

using System.Numerics;
using System.Xml.Serialization;


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

            DrawStars();


        }


        // stars
        void DrawStar(int x, int y, int sizey)
        {
            Vector2 StarBody = new Vector2(x, y);
            Draw.SetFillColor(0, 0, 210);
            Draw.Square(x, y, 5);

         
        }

    }
}
