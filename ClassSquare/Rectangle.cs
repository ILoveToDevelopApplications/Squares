using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSquare
{
    class Rectangle
    {

        public  int SideLength {get;set;}

        public int SideLength2 { get; set; }


        public int CalculateArea()
        {

            return SideLength * SideLength2;

            throw new NotImplementedException();
        }

        public int  CalculatePerimeter()
        {
            return (SideLength * 2) + (SideLength * 2);
        }


    }

   

}
