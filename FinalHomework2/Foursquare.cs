using System;
namespace FinalHomework2
{
    public class Foursquare : Squareandparse
    {
        public double QquareSide { get; private set; }

        public Foursquare()
        {
            QquareSide = Inputdata();
        }

        public override void FigureSquare()
        {
            double AreaQuadrate = Math.Round((Math.Pow(QquareSide, 2)), 2);
            Console.WriteLine("Quadrate area is: " + AreaQuadrate);
            Console.WriteLine();
        }

        public override void Fits(double Radius)

       

        {


            if (QquareSide <= Radius * 2)
            {
                Console.WriteLine("Circle does't fit the square");
                Console.WriteLine();
            }
        else
            {
                Console.WriteLine("Circle fits into the Square");
                Console.WriteLine();
            }


        }
    }





    }

