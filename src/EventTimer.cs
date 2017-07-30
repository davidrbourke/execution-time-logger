using System;
using ExecutionTimeLogger.Models;
using System.Diagnostics;

namespace ExecutionTimeLogger
{
    public class EventTimer : IEventTimer
    {
        private IEventLogger _logger;
        private TrackEvent _trackedEvent;
        
        public EventTimer(IEventLogger logger)
        {
            _logger = logger;
        }

        public void Start(string eventName, string phase)
        {
            _trackedEvent = new TrackEvent
            {
                EventName = eventName,
                Phase = phase,
                EventStopWatch = new Stopwatch()
            };
            _logger.Log(_trackedEvent);
            _trackedEvent.EventStopWatch.Start();
        }

        public void Stop()
        {
            _trackedEvent.EventStopWatch.Stop();
            _logger.Log(_trackedEvent);
        }
    }
}