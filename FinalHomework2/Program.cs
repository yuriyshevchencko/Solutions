using System;

namespace FinalHomework2
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter circle radius");
            Circle circle = new Circle();

            Console.WriteLine("Enter side of quadrate");
            Foursquare foursquare = new Foursquare();
            Console.WriteLine();

            Console.WriteLine("The comparison of the figures:");
            circle.FigureSquare();
            foursquare.FigureSquare();

            circle.Fits(foursquare.QquareSide);
            foursquare.Fits(circle.Radius);



            Console.ReadLine();



        }
    }
}
