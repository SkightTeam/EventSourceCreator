using System;
using System.Diagnostics;

namespace EventSourceCreator {
    class Program {
        static void Main(string[] args) {
            if (EventLog.SourceExists(args[0])) {
                Console.WriteLine("Source already existed");
            } else {
                EventLog.CreateEventSource(args[0],"Skight I-Tech");
                Console.WriteLine("Create success!");
            }
        }
    }
}
