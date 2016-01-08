using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catfish
{
   public sealed class Square : Shape
    {
        public float Side;
        public float Area;


        public Square()
        {
            Side = 1.0f;
        }


        public override float ComputeArea()
        {
             Area = Side * Side;

            return Area;
        }
    }
}
