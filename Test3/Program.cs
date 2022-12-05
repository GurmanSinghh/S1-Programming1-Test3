using System;

namespace _301183986
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                char ui=GurmanMenu();


                switch (ui)
                {
                    case 'a':
                        DemoQuestion3();
                        break;

                    case 'b':
                        DemoQuestion4();
                        break;

                    case 'c':
                        DemoQuestion5();
                        break;

                    case 'x':
                        return;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;

                }

            }
        }

        private static char GurmanMenu()
        {
            Console.WriteLine("+---------------------COMP100------------------------+");
            Console.WriteLine("|            a) Working with Newton's Law            |");
            Console.WriteLine("|            b) Height Converter                     |");
            Console.WriteLine("|            c) Sine and Cosine Table                |");
            Console.WriteLine("|                                                    |");
            Console.WriteLine("|            x) To exit the program                  |");
            Console.WriteLine("+----------------------------------------------------+");
            Console.Write("Press the letter corresponding to your choice->");

            char ch;
            ch = Char.Parse(Console.ReadLine().ToLower());
            return ch;
           

           


        }

        static double CalculateGravitationalAttraction(double mass1, double mass2, double distance)
        {
            double force;
            const double G = 6.673E-11;

            force = G * (mass1 * mass2) / Math.Pow(distance, 2);
            return force;


        }

        static void DemoQuestion3()
        {
            Console.WriteLine("\n\n**********Begin Question 3 **********");
            double mass1 = 5.972E24;
            double mass2 = 7.348E22;
            double distance = 384400000;

            double attractiveForce;

            attractiveForce = CalculateGravitationalAttraction(mass1, mass2, distance);

            Console.WriteLine($"The Gravitational Force of Attraction is {attractiveForce:E2}");

            Console.WriteLine("\n**********End Question 3 **********\n\n");

        }
       
        static void HeightConversion(int cm)
        {
            double meters;

            meters = Convert.ToDouble(cm) / 100.00;
            Console.WriteLine($"Height In Meters: {meters,2}");


        }

        static void DemoQuestion4()
        {
            Console.WriteLine("\n\n**********Begin Question 4 **********");

            int a;
            int b;
            int c;

            a = 75;
            HeightConversion(a);

            b = 100;
            HeightConversion(b);

            c = 290;
            HeightConversion(c);

            Console.WriteLine("\n\n**********End Question 4 **********\n\n");
        }

        static void SineCosine(double angles, out double sin, out double cos)
        {
            sin = Math.Sin(angles);
            cos = Math.Cos(angles);
        }


        static void DemoQuestion5()
        {
            Console.WriteLine("\n\n**********Begin Question 5 **********");
            Console.WriteLine("Angle      Sine    Cosine");
            Console.WriteLine("-------------------------");

            for (double angle = 0.500; angle <= 0.509; angle = angle + 0.001)
            {
                double x;
                double y;
                SineCosine(angle, out x, out y);
                Console.WriteLine($"{angle,5:f3}  {x,8:f4}  {y,8:f4}");
            }

            Console.WriteLine("\n**********End Question 5 **********\n\n");
        }

    }

}
