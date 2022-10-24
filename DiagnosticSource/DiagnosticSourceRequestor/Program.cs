using System.Diagnostics;

namespace DiagnosticSourceRequestor
{
    public class Program
    {
        static  void Main(string[] args)
        {
            var observer = new DiagnosticExampleObserver();
            IDisposable subscription = DiagnosticListener.AllListeners.Subscribe(observer);

            var url = "http://localhost:5193/WeatherForecast";

            using var client = new HttpClient();

            var msg = new HttpRequestMessage(HttpMethod.Get, url);
            msg.Headers.Add("User-Agent", "C# Program");
            var res = client.SendAsync(msg).Result;

            var content = res.Content.ReadAsStringAsync().Result;

            Console.WriteLine(content);




        }
    }
}