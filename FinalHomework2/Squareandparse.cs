using System;
namespace FinalHomework2
{
    public abstract class Squareandparse
    {
        public abstract void FigureSquare();
        public abstract void Fits(double value);

        public double Inputdata()
        {

            int i = 3;

            double value = 0;

            while (i > 0)
            {
                if (double.TryParse(Console.ReadLine(), out double parsedInput) && parsedInput > 0)
                {
                    value = parsedInput;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input, only integer or decimals higher than zero are accepted");
                    i--;
                }
            }

            if (i == 0)
            {
                Random random = new Random();

                value = Math.Round(random.NextDouble() * ((5.5) / 10), 5);

                Console.WriteLine($"To much unsuccessful attempts, random value equals to {value} was set");
            }



            return value;

        }










    }
}
