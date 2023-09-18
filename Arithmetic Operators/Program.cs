using System.Transactions;

namespace Arithmetic_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            double circumference = circumference(2);
            Console.WriteLine($"Circumference with radius 2: {circumference}");
        }

        static double circumference(double radius)
        {
            double circumference = 2 * radius * Math.PI;
            circumference = Math.Round(circumference, 2);
            return circumference;
        }

        static double area (double radius)
        {
            radius = Math.Pow (radius, 2);
            double area = Math.PI * radius;
            area = Math.Round(area, 2);
            return area;
        }

        static bool wholenumberdivision(double num1, double num2)
        {
            if(num1%num2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static double pythagoras(double width, double height)
        {
            width = Math.Pow(width, 2);
            height = Math.Pow(height, 2);
            double hypotenuse = width * height;
            hypotenuse = Math.Sqrt(hypotenuse);
            return hypotenuse;
        }

        static void books()
        {
            Console.WriteLine("How many students");
            int students = Console.ReadLine();
            Console.WriteLine("How many books");
            int books = Console.ReadLine();
            int booksperstudent = books / students;
            int booksremainder = books % students;
            Console.WriteLine($"{booksperstudent} books per student");
            Console.WriteLine($"{booksremainder} books left over");
        }

        static int storageblocks(int size)  //Size in kibibytes
        {
            size *= 2;
            int numblocks = Math.Ceiling(size);
            return numblocks;
        }

        static void pocketmoney()
        {
            Console.WriteLine("Pocket money earned each week: ");
            string? weeklyStr = Console.ReadLine();
            double weekly = double.Parse(weeklyStr);
            Console.WriteLine("Percentage saved each week:");
            string? savingsRateStr = Console.ReadLine();
            double savingsRate = double.Parse(savingsRateStr);  //As a percentage
            savingsRate /= 100; //Convert to a decimal
            double savingsAmount = weekly * savingsRate;
            savingsAmount = Math.Round(savingsAmount, 2);
            Console.WriteLine($"£{savingsAmount} saved each week");
            Console.WriteLine($"£{savingsAmount * 52} saved each year");
        }
    }
}