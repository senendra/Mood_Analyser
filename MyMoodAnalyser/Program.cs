using System;
namespace MyMoodAnalyser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter message: ");
            string message = Console.ReadLine();
            MoodAnalyser checkmood = new MoodAnalyser();
            string result = checkmood.analyseMood(message);
            Console.WriteLine(result+" Mood");
        }
    }
}
