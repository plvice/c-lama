using System;

namespace ConsoleApp
{
    class Program
    {

        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();
            book.AddGrade(5);
            book.AddGrade(6);
            book.AddGrade(3);

            book.nameChanged = new NameDelegate(writeDelegate);
            book.nameChanged += new NameDelegate(writeDelegateAgain);

            book.name = "GradeBook Name";
            book.name = "Duper";

            Console.WriteLine("Lista ocen:");
            Console.WriteLine(book.ShowGrades());

            Console.WriteLine("Średnia ocen:");
            Console.WriteLine(book.CalculateAverage());

            Console.WriteLine($"Ustawione imię to {book.name}");

            book.name = "Duperek";

            Console.ReadLine();
        }

        static void writeDelegate(string text)
        {
            Console.WriteLine($"Nowa wartość to: {text}");
        }

        static void writeDelegateAgain(string text)
        {
            Console.WriteLine($"Potwierdzenie: {text}");
        }

    }
}
