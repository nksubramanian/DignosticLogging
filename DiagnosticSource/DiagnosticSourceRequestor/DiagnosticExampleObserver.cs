using System.Diagnostics;

namespace DiagnosticSourceRequestor
{
    public sealed class DiagnosticExampleObserver : IObserver<DiagnosticListener>, IObserver<KeyValuePair<string, object>>
    {
        private readonly List<IDisposable> _subscriptions = new List<IDisposable>();
        public DiagnosticExampleObserver()
        {
        }

        public void OnCompleted()
        {
            
        }

        public void OnError(Exception error)
        {
            
        }

        public void OnNext(KeyValuePair<string, object> value)
        {
            Console.WriteLine("Event Name " + value.Key);
            Console.WriteLine(value.Value);
            Console.WriteLine("---------------------------------------------");

        }

        void IObserver<DiagnosticListener>.OnCompleted()
        {
           
        }

        void IObserver<DiagnosticListener>.OnError(Exception error)
        {
          
        }

        void IObserver<DiagnosticListener>.OnNext(DiagnosticListener value)
        {
            Console.WriteLine("DiagnosticSourceFound " + value.Name);
        }
    }
}