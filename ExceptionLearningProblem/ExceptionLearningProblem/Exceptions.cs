using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionLearningProblem
{
    class TypeOfExceptions
    {
        public static void TestIndexOutOfRangeException()
        {
            try
            {
                int[] arr = { 10, 20, 30, 40 };
                Console.WriteLine(arr[4]);
            }
            catch (IndexOutOfRangeException ex)  //Default Exception
            {
                Console.WriteLine(ex);
            }
            catch (Exception ex)                 //Parent Exception
            {
                Console.WriteLine(ex);
            }
        }
        public static void TestNullReferenceException()
        {
            try
            {
                string name = null;
                int count = name.Length;
            }
            catch (NullReferenceException ex)   //Default Exception
            {
                Console.WriteLine(ex);
            }
            catch (Exception ex)                 //Parent Exception
            {
                Console.WriteLine(ex);
            }
        }
        public static void TestArithmeticException()
        {
            try
            {
                int a = 10;
                int c = a / 0;
            }
            catch (ArithmeticException ex)          //Default Exception
            {
                Console.WriteLine(ex);
            }
            catch (Exception ex)                    //Parent Exception
            {
                Console.WriteLine(ex);
            }
        }
        public static void TestArgumentoutOfRangeException()
        {
            try
            {
                var numbers = new List<int>();
                var index = 0;
                Console.WriteLine("Removing item at index {0}", index);

                numbers.RemoveAt(index);
            }
            catch (ArgumentOutOfRangeException ex)      //Default Exception
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)                        //Parent Exception
            {
                Console.WriteLine(ex);
            }
        }
    }
}
