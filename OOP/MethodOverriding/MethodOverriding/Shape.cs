using System;

namespace MethodOverriding
{

    public class Circle : Shape
    {
        public override void Draw()
        {
            //any code specific to the circle itself
            //we can pass the excuting to the parent class
            //base.Draw(); -> here we don't need it since there is no implementation
            Console.WriteLine("Draw a Circle");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            //base.Draw(); -> same as circle
            Console.WriteLine("Draw a rectangle");

        }
    }

    public class Triangle : Shape
    {
        public override void Draw()
        {
            //base.Draw();
            Console.WriteLine("Draw a triangle");            
        }
    }
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        //public Position Position { get; set; } 
        
        public virtual void Draw()
        {
            //for override = virtual
        }
    }
}
