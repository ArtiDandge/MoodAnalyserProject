
namespace MoodAnalyserProject
{
    public class MoodAnalyser
    {
        public string message;
        public MoodAnalyser() : this("I am in Happy Mood")
        {

        }
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        static void Main(string[] args)
        {
            
        }
        public string AnalyseMood()
        {
            if (this.message.Contains("Sad"))
            {
                return "SAD";
            }
            else if (this.message.Contains("Happy"))
            {
                return "HAPPY";
            }
            else if (this.message.Contains("Any"))
            {
                return "HAPPY";
            }
            else
            {
                return "HAPPY";
            }
        }
                   
        
    }
}
