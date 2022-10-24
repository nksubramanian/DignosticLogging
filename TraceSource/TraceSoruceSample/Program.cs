namespace TraceSoruceSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TraceSourceExample traceSourceExample = new TraceSourceExample();
            traceSourceExample.moreControl();
            var result = traceSourceExample.performAddition("2", "3");
            traceSourceExample.RunSample();
            traceSourceExample.performAddition("s", "1");
            Console.WriteLine(result);
        }
    }
}