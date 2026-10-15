namespace areaFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What shape do you want, if you want to exit simply enter any other characters execpt the shapes");
            string shape = Console.ReadLine();
            if (shape == "circle")
            {
                Console.WriteLine("Enter the radius");
                double r = Convert.ToDouble(Console.ReadLine());
                double circle = circleCalculator(r);
                Console.WriteLine(circle);
            }
            else if (shape == "rectangle")
            {
                Console.WriteLine("Enter the width");
                double w = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the height");
                double h = Convert.ToDouble(Console.ReadLine());
                double rectangle = rectangleCalculator(w,h);
                Console.WriteLine(rectangle);
            }
            else if (shape == "triangle")
            {
                Console.WriteLine("Enter the base");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the height");
                double h = Convert.ToDouble(Console.ReadLine());
                double triangle = triangleCalculator(b, h);
                Console.WriteLine(triangle);
            }
            else if (shape == "trapezoid")
            {
                Console.WriteLine("Enter the top length");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the bottom length");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the height");
                double h = Convert.ToDouble(Console.ReadLine());
                double traps = trapsCalculator(a, b, h);
                Console.WriteLine(traps);
            }
            else if (shape == "parallelogram")
            {
                Console.WriteLine("Enter the base");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the height");
                double h = Convert.ToDouble(Console.ReadLine());
                double parallel = rectangleCalculator(b, h);
                Console.WriteLine(parallel);
            }
            else if (shape == "square")
            {
                Console.WriteLine("Enter the area");
                double r = Convert.ToDouble(Console.ReadLine());
                double square = squareCalculator(r);
                Console.WriteLine(square);
            }
            else if (shape == "ellipse")
            {
                Console.WriteLine("Enter the semi-major axis");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the semi-minor axis");
                double b = Convert.ToDouble(Console.ReadLine());
                double ellipse = ellipseCalculator(a, b);
                Console.WriteLine(ellipse);
            }
            else
            {
                break;
            }
        }
        static public double circleCalculator(double r)
        {
            double area = r * Math.PI;
            return area;
        }
        static public double rectangleCalculator(double w,double h)
        {
            double area = w * h;
            return area;
        }
        static public double triangleCalculator(double b,double h)
        {
            double area = b * h * 0.5;
            return area;
        }
        static public double trapsCalculator(double a, double b, double h)
        {
            double area = 0.5 * (a * b) * h;
            return area;
        }
        static public double squareCalculator(double r)
        {
            double area = r * r;
            return area;
        }
        static public double ellipseCalculator(double a, double b)
        {
            double area = a * b * Math.PI;
            return area;
        }
    }
}
