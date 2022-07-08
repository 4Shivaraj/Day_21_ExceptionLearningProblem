// See https://aka.ms/new-console-template for more information

namespace ExceptionLearningProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Exception Learning Problem");
            TypeOfExceptions.TestIndexOutOfRangeException();
            TypeOfExceptions.TestNullReferenceException();
            Console.ReadLine();
        }
    }
} 