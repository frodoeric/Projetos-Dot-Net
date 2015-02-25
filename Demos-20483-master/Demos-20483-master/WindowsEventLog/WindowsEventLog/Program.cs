using System.Diagnostics;

namespace WindowsEventLog
{
    class Program
    {
        static void Main(string[] args)
        {
            string eventLog = "Application";
            string eventSource = "Logging Demo";
            string eventMessage = "Hello from the Logging Demo application";
            
            // Create the event source if it does not already exist.
            if (!EventLog.SourceExists(eventSource))
            {
                EventLog.CreateEventSource(eventSource, eventLog);
            }

            // Log the message.
            EventLog.WriteEntry(eventSource, eventMessage);
        }
    }
}
