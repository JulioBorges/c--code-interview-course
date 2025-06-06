using C_CourseCodeInterview.Base;
using System.Runtime.CompilerServices;

namespace C_CourseCodeInterview.InterviewChallenges
{
    public class MaxPlanesToFall : IExecution
    {
        public string Name => "Max planes to fall - HackerRank chalenge";

        public string Description => @"Given two arrays startHeight[] and descentRate[] consisting of N integers where
            startHeight[i] represents the initial position of the ith plane and
            descentRate[i] is the speed at which the plane is landing,
            the task is to print the number of the plane that can be stopped from landing
            by shooting an aircraft at every second.";

        public void Run()
        {
            TestCase([4, 3], [2, 2], 2);
            TestCase([20, 40, 60], [10, 10, 10], 3);
        }

        private static void TestCase(List<int> startHeight, List<int> descentRate, int shouldBe)
        {
            Console.WriteLine("=========================================");

            Console.WriteLine("Test case:");
            Console.WriteLine($"Start height: {string.Join(", ", startHeight)}");
            Console.WriteLine($"Descent rate: {string.Join(", ", descentRate)}");

            int result = MaxPlanes(startHeight, descentRate);
            Console.WriteLine($"Maximum planes that can be stopped: {result}");

            if (result == shouldBe)
                Console.WriteLine("Test passed!");
            else
                Console.WriteLine($"Test failed! Expected {shouldBe}, but got {result}.");
        }

        /*
         * Complete the 'maxPlanes' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY startHeight
         *  2. INTEGER_ARRAY descentRate
         */

        public static int MaxPlanes(List<int> startHeight, List<int> descentRate)
        {
            List<double> timesToLand = [];

            for (int i = 0; i < startHeight.Count; i++)
            {
                timesToLand.Add((double)(startHeight[i]) / descentRate[i]);
            }

            timesToLand.Sort();

            int shotedAirplanes = 0;
            int timeAttempt = 1;

            for (int i = 0; i < timesToLand.Count; i++)
            {
                var time = timesToLand[i];
                // If the current time attempt is less than or equal to the landing time of the plane
                if (timeAttempt >= time)
                {
                    shotedAirplanes++;
                    timeAttempt++;
                }
            }

            // Get the airplanes on ground based on difference between total airplanes and shoted airplanes
            int airplanesOnGround = startHeight.Count - shotedAirplanes;
            return airplanesOnGround;
        }

        // Old implementation
        //public static int maxPlanes(List<int> startHeight, List<int> descentRate)
        //{
        //    List<double> timeToLand = new List<double>();

        //    for (int i = 0; i < startHeight.Count; i++)
        //    {
        //        timeToLand.Add((double)(startHeight[i]) / descentRate[i]);
        //    }

        //    int shotAirplanes = 0;

        //    timeToLand.Sort();

        //    for (int i = 0; i < timeToLand.Count; i++)
        //    {
        //        var time = timeToLand[i];
        //        Console.WriteLine(time);

        //        if (i <= time)
        //            shotAirplanes++;
        //    }

        //    return shotAirplanes;
        //}
    }
}