using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            string eventlog = "Application";
            string eventSource = "Logging Demo";
            string eventMessage = "Hello from the Logging Demo application";

            if (!EventLog.SourceExists(eventSource))
	        {
                EventLog.CreateEventSource(eventSource, eventlog);
		 
	        }
            EventLog.WriteEntry(eventSource, eventMessage);
        }
    }
}
