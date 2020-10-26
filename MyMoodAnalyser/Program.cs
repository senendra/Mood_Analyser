using System;
namespace MyMoodAnalyser
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter message: ");
            string message = Console.ReadLine();
            MoodAnalyser checkmood = new MoodAnalyser(message);
            string result = checkmood.AnalyseMood();
            Console.WriteLine(result+" MOOD");
            MoodAnalyserFactory.CreateMoodAnalyser("MyMoodAnalyser.MoodAnalyser", "MoodAnalyser");
        }
    }
}
