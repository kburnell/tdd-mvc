using System;
using TestDrivingMVC.Service.Interfaces;

namespace TestDrivingMVC.Service {

    public class LoggingService : ILoggingService {

        public void LogError(string message, Exception ex) {
            throw new NotImplementedException();
        }

        public void LogDebug(string message) {
            throw new NotImplementedException();
        }

        public bool IsOnline() {
            throw new NotImplementedException();
        }
    }
}