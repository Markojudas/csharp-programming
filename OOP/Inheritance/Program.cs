using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();
            //text inherits PresentationObject
            text.Width = 100;  //property of PresentationObject
            text.Copy(); //method of PresentationObject 

        }
    }
}
