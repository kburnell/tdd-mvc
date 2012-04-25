using Microsoft.VisualStudio.TestTools.UnitTesting;
using StructureMap;
using TestDrivingMVC.Service;
using TestDrivingMVC.Service.Interfaces;
using TestDrivingMVC.Shared.Utility;
using Should;

namespace TestDrivingMVC.Web.Test.Unit.Utility {
    [TestClass]
    public class ResolverTest {

        [TestMethod]
        public void GetConcreteInstanceOf_ShouldReturn_LoggingService_WhenT_Is_ILoggingService() {
            //Arrange
            ObjectFactory.Initialize(registry => registry.Scan(x =>
            {
                x.AssembliesFromApplicationBaseDirectory();
                x.WithDefaultConventions();
            }));
            //Act
            ILoggingService result = Resolver.GetConcreteInstanceOf<ILoggingService>();
            //Assert
            result.ShouldBeType<LoggingService>();
        }
    }
}