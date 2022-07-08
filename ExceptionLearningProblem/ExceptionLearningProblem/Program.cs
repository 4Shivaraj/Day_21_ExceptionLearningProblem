// See https://aka.ms/new-console-template for more information

namespace ExceptionLearningProblem
{
    class Program
    {
        public static string Shivaraj { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Exception Learning Problem");
            TypeOfExceptions.TestIndexOutOfRangeException();
            TypeOfExceptions.TestNullReferenceException();
            TypeOfExceptions.TestArithmeticException();
            TypeOfExceptions.TestArgumentoutOfRangeException();
            Console.ReadLine();
        }
    }
} 