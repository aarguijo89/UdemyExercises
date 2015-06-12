using System;
using System.Threading;

namespace StopWatchExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var stopWatch = new StopWatch();

                stopWatch.Start();
                Thread.Sleep(8);
                stopWatch.Stop();

                Console.WriteLine("The duration is: {0}", stopWatch.GetDuration());

                stopWatch.Start();
                Thread.Sleep(20);
                stopWatch.Stop();

                Console.WriteLine("The duration is: {0}", stopWatch.GetDuration());
            }
            catch (InvalidOperationException exception)
            {
                Console.WriteLine("Error: {0}", exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine("Oops an unexpected error occurred:  {0}",exception.Message);
            }

            Console.ReadLine();

        }
    }
}
