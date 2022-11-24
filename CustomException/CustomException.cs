using System;
namespace CustomExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number1, Number2, Result;
            try
            {
                Console.WriteLine("Enter First Number:");
                Number1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Second Number:");
                Number2 = int.Parse(Console.ReadLine());

                if (Number2 % 2 == 0)
                {
                    throw new EvenNumberException("Even Number Exception Occured Inside the Main Method of Program Class");
                }
                Result = Number1 / Number2;
                Console.WriteLine(Result);
            }
            catch (EvenNumberException one)
            {
                Console.WriteLine($"Message: {one.Message}");
                Console.WriteLine($"Source: {one.Source}");
                Console.WriteLine($"StackTrace: {one.StackTrace}");
            }

            Console.ReadKey();
        }
    }
}
