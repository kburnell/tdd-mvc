using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;
using StructureMap;
using TestDrivingMVC.Domain;
using TestDrivingMVC.Service.Interfaces;
using TestDrivingMVC.Test.Shared.Fakes;

namespace TestDrivingMVC.Service.Test.Unit {

    [TestClass]
    public class EmployeeServiceTest {

        private ILoggingService _loggingServiceFake;
        private IEmployeeService _employeeService;

        [TestInitialize]
        public void TestSetup() {
            _loggingServiceFake = new LoggingServiceFake();
            ObjectFactory.Initialize(x => x.For<ILoggingService>().Use(_loggingServiceFake));
            _employeeService = new EmployeeService();
        }

        [TestCleanup]
        public void TestTeardown() {
            _loggingServiceFake = null;
            _employeeService = null;
        }

        [TestMethod]
        public void CalculateSalary_ShouldReturn_Decimal() {
            //Arrange
            long employeeId = 12345;
            //Act
            var result = _employeeService.CalculateSalary(employeeId);
            //Assert
            result.ShouldBeType<decimal>();
        }

    }
}