using System;
using System.Diagnostics;

namespace MistralTask.WebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("This message is to let you know that you don't use the right path.");
            Console.WriteLine("To stop, hit `CTRL + C`...");

            var process = Process.GetCurrentProcess();
            process.WaitForExit();
        }
    }
}