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
            Console.WriteLine(findSum(3, 4));
            seeForAssert();
        }

        private static int findSum(int a, int b)
        {
            Debug.WriteLine("I am inside the private method", "tracing");
            Debug.Indent();
            Debug.WriteLineIf(5 > 1, "I am printed if true", "I am printed if false");
            Debug.Unindent();
            Debug.WriteLine("This statement is solely for seeing the unidenting");
            return a + b;
        }

        private static void seeForAssert()
        {
            // Create an index for an array.
            int index;

            // Perform some action that sets the index.
            index = -40;

            // Test that the index value is valid.
            Debug.Assert(index > -1);
        }

    }
}