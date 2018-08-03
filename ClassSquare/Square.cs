using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSquare
{
    class Square:Rectangle
    {

        public int sideLength;


        public Square(int sideLength) // const
        {
            SideLength = sideLength;

        }

        public int Sidelength { get; set; }
 
        public CalculatePerimeter()
        {

            int perimeter = 4 * Sidelength;

            return perimeter;
        }  

        public CalculateArea()
        {
            return Sidelength * Sidelength;

            
        }


    }

    
    
}
