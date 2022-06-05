using System;
using System.Collections.Generic;

namespace MethodOverriding
{
    public class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Draw(); //it could be a circle or a rectangle and it will execute their draw(); - polymorphism
            }
        }
    }
}
