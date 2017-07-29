using System;

namespace ExecutionTimeLogger
{
    public interface IEventTimer
    {
        void Start(string eventName, string phase);
        void Stop(string eventName, string phase);
    }
}