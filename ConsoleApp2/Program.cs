using System;

namespace Grades
{
    class Program
    {

        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();
            book.AddGrade(5);
            book.AddGrade(6);
            book.AddGrade(3);

            book.NameChanged += OnNameChanged;

            book.Name = "Chris";
            book.Name = "Matt";

            Console.WriteLine("Grade list:");
            Console.WriteLine(book.ShowGrades());

            Console.WriteLine("Average:");
            Console.WriteLine(book.CalculateAverage());

            Console.WriteLine($"Name is {book.Name}");

            book.Name = "Popularny Stefanek";

            Console.ReadLine();
        }

        static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Name changed from {args.OldName} to {args.NewName}");
        }

    }
}
