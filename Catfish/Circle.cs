using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catfish
{   
    //this is a sealed class, it will not be able to inherit to another form 
    public sealed class Circle:Shape
    {
        private const float PI = 3.14159f;
        public float Radius;
        public float Area;

        public Circle()
        {
            Radius = 1.0f;

        }

            public override float ComputeArea()
            {
                Area = PI * Radius * Radius;

                return Area;
            }

        }

    }






