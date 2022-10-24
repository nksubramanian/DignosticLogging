using System.Diagnostics;

namespace DiagnosticSourceDemo
{
    public class TestDiagnosticObserver : IObserver<DiagnosticListener>
    {
        public void OnNext(DiagnosticListener value)
        {
            if (value.Name == "Microsoft.Extensions.Hosting")
            {
                value.Subscribe(new TestKeyValueObserver());
            }
        }
        public void OnCompleted() { }
        public void OnError(Exception error) { }

    }
}
