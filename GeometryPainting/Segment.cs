﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryTasks
{
   public  class Segment
    {
        public Vector Begin;
        public Vector End;

        
        public double GetLength()
        {
           return Geometry.GetLength(this);
        }
        public  bool Contains(Vector vector)
        {
           return Geometry.IsVectorInSegment(vector, this);
        }
    }
}
