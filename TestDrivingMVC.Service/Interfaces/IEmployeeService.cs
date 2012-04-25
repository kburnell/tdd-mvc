using System.Collections.Generic;
using TestDrivingMVC.Domain;

namespace TestDrivingMVC.Service.Interfaces {

    public interface IEmployeeService {

        decimal CalculateSalary(long employeeId);
    }
}