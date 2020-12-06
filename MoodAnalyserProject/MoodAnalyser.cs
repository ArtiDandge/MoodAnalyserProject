using System;

namespace MoodAnalyserProject
{
    public class MoodAnalyser
    {
        public string message;
        public MoodAnalyser():this("I am in Sad Mood")
        {
            
        }
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyser Project !");
            MoodAnalyser mood = new MoodAnalyser("I am in Sad Mood");
            Console.WriteLine(mood.analyseMood1());
        }
        public string analyseMood(string message)
        {
            if (message.Equals("Happy"))
            {
                return message + " mood";
            }
            else if (message.Equals("Sad"))
            {
                return message + " mood";
            }
            else if (message.Equals("I am in Sad Mood"))
            {
                return "SAD";
            }
            else 
            {
                return "HAPPY";
            }

            
        }
        public string analyseMood1()
        {
            if (message.Equals("I am in Sad Mood"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }

        }
    }
}
