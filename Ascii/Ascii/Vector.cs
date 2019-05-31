using System;
using System.Collections.Generic;
using System.Text;

namespace Ascii
{
    public class Vector
    {
        private object p1;
        private object p2;

        public Vector(object p1, object p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }

        public Vector x { get; set; }
        public Vector y { get; set; }
        public static Vector operator +(Vector left, Vector right)
        {
            return new Vector(right.x + left.x, right.y + left.y);
        }
    }
}
