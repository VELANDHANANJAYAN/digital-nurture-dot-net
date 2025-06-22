using System;

class Program
{
    static void Main(string[] args)
    {
        Logger logger1 = Logger.GetInstance();
        Logger logger2 = Logger.GetInstance();

        logger1.Log("First log entry.");
        logger2.Log("Second log entry.");

        if (logger1 == logger2)
        {
            Console.WriteLine("Singleton confirmed: Only one instance exists.");
        }
        else
        {
            Console.WriteLine("Singleton failed: Different instances exist.");
        }
    }
}
