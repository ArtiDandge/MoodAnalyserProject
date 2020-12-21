﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Text.RegularExpressions;

namespace MoodAnalyserProject
{
    public class MoodAnalyserFactory
    {
        public static object CreateeMoodAnalyse(string className, string constructorName)
        {
            string pattern = @"." + constructorName + "$";
            Match result = Regex.Match(className, pattern);
            if (result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnalyseType = executing.GetType(className);
                    return Activator.CreateInstance(moodAnalyseType);
                }
                catch(ArgumentNullException)
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NO_SUBH_CLASS,"Class Not Found");
                }
            }
            else
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NO_SUCH_METHOD,"Constructor is Not Found");
            }
        }

        /// <summary>
        /// CreatMoodAnalser method to creat object of MoodAnalyser
        /// </summary>
        /// <param name="className">class Name</param>
        /// <param name="constructorName">costructor name</param>
        /// <param name="message">message</param>
        /// <returns></returns>
        public static object CreateMoodAnalyserUsingParameterizedConstructor(string className, string constructorName, string message)
        {
            Type type = typeof(MoodAnalyser);
            if(type.Name.Equals(className) || type.FullName.Equals(className))
            {
                if (type.Name.Equals(constructorName))
                {
                    ConstructorInfo ctor = type.GetConstructor(new[] { typeof(string) });
                    object instance = ctor.Invoke(new object[] { message });
                    return instance;
                }
                else
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NO_SUCH_METHOD,"Constructor is not Found");
                }
            }
            else
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NO_SUBH_CLASS,"Class Not Found ");
            }
        }

        /// <summary>
        /// Invoke Method using Reflection
        /// </summary>
        /// <param name="message">message</param>
        /// <param name="methodName">Method Name</param>
        /// <returns></returns>
        public static string InvokeAnalyseMood(string message, string methodName)
        {
            try
            {
                Type type = Type.GetType("MoodAnalyserProject.MoodAnalyser");
                object moodAnalyserObject = MoodAnalyserFactory.CreateMoodAnalyserUsingParameterizedConstructor("MoodAnalyserProject.MoodAnalyser", "MoodAnalyser", message);
                MethodInfo AnalseMoodInfo = type.GetMethod(methodName);
                object mood = AnalseMoodInfo.Invoke(moodAnalyserObject, null);
                return mood.ToString();
            }
            catch(NullReferenceException)
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NO_SUCH_METHOD,"Method is Not Found");
            }
        }
        /// <summary>
        /// Function to set the Field Dynamically using Reflection
        /// </summary>
        /// <param name="message">message</param>
        /// <param name="fieldName">field name</param>
        /// <returns></returns>
        public static string SetField(string message, string fieldName)
        {
            try
            {
                MoodAnalyser moodAnalyser = new MoodAnalyser();
                Type type = typeof(MoodAnalyser);
                FieldInfo field = type.GetField(fieldName, BindingFlags.Public | BindingFlags.Instance);
                if(message == null)
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NO_SUCH_FIELD,"Message should not be null");
                }
                field.SetValue(moodAnalyser, message);
                return moodAnalyser.message;
            }
            catch(NullReferenceException)
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NO_SUCH_FIELD,"Field is Not Found");
            }
        }
    }
}
