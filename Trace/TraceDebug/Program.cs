using System.Diagnostics;

namespace TraceDebug
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listener = new ConsoleTraceListener();
            Trace.Listeners.Add(listener);
            Trace.WriteLine("I am in the main method", "tracing");
            Debug.WriteLine("I am in the main method", "Debug");
            Console.WriteLine("Hello, World!");
        }
    }
}