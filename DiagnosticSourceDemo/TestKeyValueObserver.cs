namespace DiagnosticSourceDemo
{
    internal class TestKeyValueObserver : IObserver<KeyValuePair<string, object?>>
    {
        public void OnNext(KeyValuePair<string, object?> value)
        {
            Console.WriteLine($"Received event: {value.Key} with value {value.Value?.GetType()}");
        }
        public void OnCompleted() { }
        public void OnError(Exception error) { }
    }
}