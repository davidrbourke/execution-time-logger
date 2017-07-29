using System;
using ExecutionTimeLogger.Models;

namespace ExecutionTimeLogger
{
    public class EventTimer : IEventTimer
    {
        private IEventLogger _logger;
        public EventTimer(IEventLogger logger)
        {
            _logger = logger;
        }
        public void Start(string eventName, string phase)
        {
            var trackedEvent = new TrackEvent
            {
                EventName = eventName,
                Phase = phase,
                EventTime = DateTime.Now
            };

            _logger.Log(trackedEvent);
        }

        public void Stop(string eventName, string phase)
        {
            var trackedEvent = new TrackEvent
            {
                EventName = eventName,
                Phase = phase,
                EventTime = DateTime.Now
            };

            _logger.Log(trackedEvent);
        }
    }
}