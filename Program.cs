using System;

namespace Tennis_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome
            Console.Clear();
            Console.WriteLine("Welcome to the Tennis Quiz!!");

            int correctCount = 0;

            // Question 1
            Console.WriteLine("1. How many points do you need to win a game of tennis?");
            Console.WriteLine("Question 1 Answer:");
            int ans1 = Convert.ToInt32(Console.ReadLine());
            if (ans1 == 4 || ans1 == 60) {
                Console.WriteLine("Correct!");
                correctCount++;
            } else {
                Console.WriteLine("Incorrect.");
            }

            // Question 2
            Console.WriteLine("2. What is it called when you have a zero score in Tennis?");
            Console.WriteLine("Question 2 Answer:");
            string ans2 = Console.ReadLine().ToLower();
            if (ans2 == "love") {
                Console.WriteLine("Correct!");
                correctCount++;
            } else {
                Console.WriteLine("Incorrect.");
            }

            // Question 3
            Console.WriteLine("3. How many players, MAXIMUM, can be on a tennis court at the same time?");
            Console.WriteLine("Question 3 Answer:");
            int ans3 = Convert.ToInt32(Console.ReadLine());
            if (ans3 == 2 || ans3 == 4) {
                Console.WriteLine("Correct!");
                correctCount++;
            } else {
                Console.WriteLine("Incorrect.");
            }

            // Question 4
            Console.WriteLine("4. How large is a tennis ball's diameter? (in Inches)");
            Console.WriteLine("Question 4 Answer:");
            double ans4 = Convert.ToDouble(Console.ReadLine());
            if (ans4 == 2.7) {
                Console.WriteLine("Correct!");
                correctCount++;
            } else {
                Console.WriteLine("Incorrect.");
            }

            int correctPercent = correctCount * 25;


            // Results
            Console.WriteLine("You have finished the quiz!");
            Console.WriteLine($"You scored {correctCount}/4! ({correctPercent}%)");
            if (correctCount == 0) {
                Console.WriteLine("You need to expand your tennis knowledge!");
            } else if (correctCount == 1) {
                Console.WriteLine("Good Try! You are on your way to success!");
            } else if (correctCount == 2) {
                Console.WriteLine("Nice Job! Almost there!");
            } else if (correctCount == 3) {
                Console.WriteLine("You must play a lot! You're amazing!");
            } else if (correctCount == 4) {
                Console.WriteLine("FANTASTIC!!! YOU ARE A TENNIS PRODIGY!!!!");
            }
            
        }
    }
}
