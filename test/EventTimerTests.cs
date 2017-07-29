using System;
using Xunit;
using ExecutionTimeLogger;
using ExecutionTimeLogger.Models;
using Moq;

namespace Test
{
    public class EventTimerTests
    {
        [Fact]
        public void Start_EventPhaseProvided_NoExceptions()
        {
            // Arrange
            Mock<IEventLogger> eventLoggerMock = new Mock<IEventLogger>();
            var eventTimer = new EventTimer(eventLoggerMock.Object);

            // Act
            eventTimer.Start("a", "b");
        }

        [Fact]
        public void Start_EventMissing_Logged()
        {
            // Arrange
            Mock<IEventLogger> eventLoggerMock = new Mock<IEventLogger>();
            var eventTimer = new EventTimer(eventLoggerMock.Object);

            // Act
            eventTimer.Start(null, "b");
            
            // Assert
            eventLoggerMock.Verify(x => x.Log(It.IsAny<TrackEvent>()), Times.Once());
        }
    }
}
