using MohawkGame2D;

using System.Numerics;
using System.Xml.Serialization;


namespace MohawkGame2D
{
    public class Stars
    {

       
        
       
      
      
        
        public void Setup()
        {

           

        }
        public void Update() 
        {

            DrawStar();
           
        }

        void DrawStar()
        {

            int size = 10;
            int x = Input.GetMouseX();
            int y = 0;

            Vector2 StarBody = new Vector2(x, y);
            Draw.SetFillColor(0, 0, 210);
            Draw.Square(x, y, 5);

          

//WOOOORRRRRRRRRRRRRRKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK

        }
    }
    }
