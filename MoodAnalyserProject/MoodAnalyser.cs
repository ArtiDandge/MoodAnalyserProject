using System;

namespace MoodAnalyserProject
{
    public class MoodAnalyser
    {
        public string message;
        public MoodAnalyser():this("I am in Happy Mood")
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
            MoodAnalyser mood1 = new MoodAnalyser("I am in Happy Mood");
            Console.WriteLine(mood.analyseMood1());
            Console.WriteLine(mood1.analyseMood1());
        }
        public string analyseMood(string moood)
        {
            if (moood.Equals("Happy"))
            {
                return moood + " mood";
            }
            else if (moood.Equals("Sad"))
            {
                return moood + " mood";
            }
            else if (moood.Equals("I am in Sad Mood"))
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
            else if(message.Equals("I am in Happy Mood"))
            {
                return "HAPPY";
            }
            else
            {
                return "Happy";
            }
        }
    }
}
