using System;

namespace TestDrivingMVC.Service.Interfaces {

    public interface ILoggingService {

        void LogError(string message, Exception ex);
        void LogDebug(string message);
        bool IsOnline();

    }
}