using System;
using System.Collections.Generic;
using TestDrivingMVC.Domain;
using TestDrivingMVC.Service.Interfaces;
using TestDrivingMVC.Shared.Utility;

namespace TestDrivingMVC.Service {

    //Employee Service
    public class EmployeeService : IEmployeeService {

        private readonly ILoggingService _loggingService;

        public EmployeeService() {
            _loggingService = Resolver.GetConcreteInstanceOf<ILoggingService>();
        }

        public decimal CalculateSalary(long employeeId) {
            _loggingService.LogDebug(string.Format("Calculating Salary For Employee: {0}", employeeId));
            decimal output = 0;
            /* 
             * Complex logic that needs to be performed
             * in order to determine the employee's salary
             */
            return output;
        }
    }
}