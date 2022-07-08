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
                int[] arr = { 10, 20, 30, 40};
                Console.WriteLine(arr[4]);
            }
            catch(IndexOutOfRangeException ex)  //Default Exception
            {
                Console.WriteLine(ex);
            }
            catch(Exception ex)                 //Parent Exception
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
            catch (NullReferenceException ex)  //Default Exception
            {
                Console.WriteLine(ex);
            }
            catch (Exception ex)                 //Parent Exception
            {
                Console.WriteLine(ex);
            }
        }
    }
}
