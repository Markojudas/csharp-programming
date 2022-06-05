namespace Inheritance
{
    public class PresentationObjection
    {
        //Super Class - base clas

        public int Width { get; set; }
        public int Height { get; set; } 

        public void Copy()
        {
            System.Console.WriteLine("Object Copied to clipboard");

        }

        public void Duplicate()
        {
            System.Console.WriteLine("Object duplicated");

        }
    }
}
