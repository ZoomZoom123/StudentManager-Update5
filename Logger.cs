using System;

namespace StudentManager
{
    public class Logger
    {
        const string DefaultSystemName = "SchoolTracker";
        public static void Log(string msg, string system = DefaultSystemName, int priority = 1)
        {
            Console.WriteLine("System: {0}, Priority: {1}, Message: {2}", system, priority, msg);
        }
    }
}