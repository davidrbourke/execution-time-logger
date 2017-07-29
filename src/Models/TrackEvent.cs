using System;

namespace ExecutionTimeLogger.Models
{
    public class TrackEvent
    {
        public string EventName { get; set; }
        public string Phase { get; set; }
        public DateTime? EventTime { get; set; }
        public string Message { get; set; }
    }
}