using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasic
{
    internal class AreaOfShapes
    {
        private float _FResult;
        private int _IResult;

        public float Area(float r)
        {
            float pi = 3.14f;
            _FResult = pi * r  *r;
            return _FResult;
        }

        public int Area(int s )
        {
            _IResult = s * s;
            return _IResult;
        }

        public int Area(int l , int b)
        {
            _IResult = l * b;
            return _IResult;

        }


        public float Area(float b, float h)
        {
            _FResult = (b * h) * 0.5f;
            return _FResult;
        }
    }
}
