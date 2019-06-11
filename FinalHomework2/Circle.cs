using System;
namespace FinalHomework2
{
    public class Circle : Squareandparse
    {
    
    public double Radius { get; private set; }

        public Circle()
        {
            Radius = Inputdata();
        }

         public const double pi = 3.14;

        public override void FigureSquare()
        {

            double circleSquare = Math.Round((Constants.Pi * (Math.Pow(Radius, 2))), 2);
        Console.WriteLine("Circle area is: " + circleSquare);

        }
        public override void Fits(double Side)
        
         {
            if (Radius * 2 <= Side)
        {
            Console.WriteLine("Circle fits into the Square");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Circle does't fit into the square");
            Console.WriteLine();
        }

           
        }

        

    }
}

