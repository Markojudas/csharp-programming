using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {   
            // //UPCASTING
            // Text text = new Text();
            // Shape shape = text;

            // text.Width = 200;
            // shape.Width = 100;

            // //text and shape are pointing to the same object in memory

            // System.Console.WriteLine(text.Width);
            // 0StreamReader reader = new StreamReader(new MemoryStream());

            // var list = new ArrayList();

            // list.Add(1);
            // list.Add("Mosh");
            // list.Add(new Text());

            // var anotherList = new List<Shape>();

            //DOWNCASTING
            Shape shape = new Text();

            Text text = (Text)shape; //downcasting  

        }
           

            





    }
}
