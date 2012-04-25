using System;
using TestDrivingMVC.Service.Interfaces;

namespace TestDrivingMVC.Test.Shared.Fakes {

    public class LoggingServiceFake : ILoggingService {

        public void LogError(string message, Exception ex) {}

        public void LogDebug(string message) {}

        public bool IsOnline() {
            return true;
        }
    }
}