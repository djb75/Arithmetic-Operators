using System.Transactions;

namespace Arithmetic_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            double circumf = circumference(2);
            Console.WriteLine($"Circumference with radius 2: {circumf}");
            Console.WriteLine($"Area of a circle with radius 2: {area(2)}");
            Console.WriteLine($"Whole number division of 4/3: {wholenumberdivision(4, 3)}");
            Console.WriteLine($"Pythagoras on a triangle with 3, 4 size lengths: {pythagoras(3, 4)}");
            books();
            Console.WriteLine($"Number of 512b blocks needed to store 512KiB: {storageblocks(512)}");
            pocketmoney();
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
            string? studentsStr = Console.ReadLine();
            int students = int.Parse(studentsStr);
            Console.WriteLine("How many books");
            string? booksStr = Console.ReadLine();
            int books = int.Parse(booksStr);
            int booksperstudent = books / students;
            int booksremainder = books % students;
            Console.WriteLine($"{booksperstudent} book(s) per student");
            Console.WriteLine($"{booksremainder} book(s) left over");
        }

        static int storageblocks(int size)  //Size in kibibytes
        {
            size *= 2;
            return size;
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