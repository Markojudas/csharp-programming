namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle();
            circle.Draw();

            var rectangle = new Rectangle();
            
            rectangle.Draw();

            //var shape = new Shape(); -> cannot create an instance of an abstract class

            

        }
    }
}
