using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace ExecutionTimeLogger.Models
{
    public class TrackEvent
    {
        public TrackEvent()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }
        public string EventName { get; set; }
        public string Phase { get; set; }
        [JsonIgnore]
        public Stopwatch EventStopWatch { get; set; }
        public double ElapsedMilliseconds => EventStopWatch.Elapsed.TotalMilliseconds;
        public DateTime UtcEventDate => DateTime.UtcNow;
        public string Message { get; set; }
    }
}