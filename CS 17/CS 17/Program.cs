using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
               
                Console.WriteLine("Hello world");
                throw new Exception("Goodbye cruel world");
                Console.WriteLine("Goodbye");
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            finally
            {
                Console.Read();
            }
        }
    }
}
