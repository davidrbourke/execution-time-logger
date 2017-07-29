using System;
using ExecutionTimeLogger;
using ExecutionTimeLogger.Models;

namespace ExecutionTimeLogger
{
    public interface IEventLogger
    {
        void Log(TrackEvent trackEvent);
    }
}