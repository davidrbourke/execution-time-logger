using System;
using ExecutionTimeLogger.Models;

namespace ExecutionTimeLogger
{
    public interface IEventTimer
    {
        void Start(string eventName, string phase);
        void Stop();
    }
}