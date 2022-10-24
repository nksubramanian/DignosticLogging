using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraceSoruceSample
{
    public class TraceSourceExample
    {
        static TraceSource ts = new TraceSource("TraceSourceExample");

        public TraceSourceExample()
        {
            SourceSwitch sourceSwitch = new SourceSwitch("mySwitch");
            sourceSwitch.Level = SourceLevels.Verbose;
            ts.Switch = sourceSwitch;
            var listener = new ConsoleTraceListener();
            int tsConsole = ts.Listeners.Add(listener);
            ts.Listeners[tsConsole].Name = "Console";
            XmlWriterTraceListener xmlWriterTraceListener = new XmlWriterTraceListener(
                Path.Combine(Environment.CurrentDirectory, "xmlTraceListenerOutput.xml"));
            int tsXml = ts.Listeners.Add(xmlWriterTraceListener);
            ts.Listeners[tsXml].Name = "Xml";

        }

        public void moreControl()
        {
            ts.Listeners["Console"].TraceOutputOptions = TraceOptions.Timestamp | TraceOptions.Callstack;
     
        }

        public void RunSample()
        {
            ts.TraceEvent(TraceEventType.Verbose, 0, "In RunSample method");
            ts.TraceEvent(TraceEventType.Verbose, 0, "I am in RunSample method");
        }

        public int performAddition(string a, string b)
        {
            
            try
            {
                return int.Parse(a) + int.Parse(b);
            }
            catch(Exception ex)
            {
                string errorContext = a + b;
                ts.TraceData(TraceEventType.Error, 3, new object[] { errorContext, ex });
                return 0;
            }
        }


    }
}
