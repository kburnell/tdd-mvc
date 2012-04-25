using StructureMap;

namespace TestDrivingMVC.Shared.Utility {

    public static class Resolver {
        
        public static T GetConcreteInstanceOf<T>() {
            return ObjectFactory.GetInstance<T>();
        }
    }
}