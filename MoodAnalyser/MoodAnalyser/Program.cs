using System;

namespace MoodAnalyser
{
    public class Program
    {
        public  string CheckMood(string mood)
        {
            if (mood == "Happy")
            {
                return "Happy";
            }
           return "sd";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Mood Analyser!");
           
        }
    }
}
