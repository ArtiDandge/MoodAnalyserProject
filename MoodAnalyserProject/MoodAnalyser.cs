﻿using System;

namespace MoodAnalyserProject
{
    public class MoodAnalyser
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyser Project !");
        }
        public string analyseMood(string mood)
        {
            if (mood.Equals("Happy"))
            {
                return mood + " mood";
            }
            else if (mood.Equals("I am in Sad Mood"))
            {
                return "SAD";
            }
            else 
            {
                return mood + " mood";
            }
            
        }
    }
}
