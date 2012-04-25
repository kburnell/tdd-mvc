using System.Collections.Generic;

namespace TestDrivingMVC.Domain {

    public class Department {

        public long Id { get; set; }
        public long Name { get; set; }
        public IList<Employee> Employees { get; set; }
    }
}