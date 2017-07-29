using System.IO;
using ExecutionTimeLogger.Models;
using Newtonsoft.Json;

namespace ExecutionTimeLogger
{
    public class FileLogger : IEventLogger
    {
        private const string FILE_NAME = "etl.txt";

        public void Log(TrackEvent trackEvent)
        {
            string[] lines = { JsonConvert.SerializeObject(trackEvent) };
            File.AppendAllLines(FILE_NAME, lines);
        }
    }
}