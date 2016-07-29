using System;
using System.IO;

namespace LogWithShareRead
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var stream = File.Open("test.log", FileMode.Create, FileAccess.Write, FileShare.Read))
            using (var writer = new StreamWriter(stream))
            {
                while (true)
                {
                    writer.WriteLine($"Hello at {DateTimeOffset.Now}");
                    writer.Flush();
                    System.Threading.Thread.Sleep(1000);
                }
            }
        }
    }
}
