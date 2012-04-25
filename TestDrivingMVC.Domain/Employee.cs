namespace TestDrivingMVC.Domain {
    public class Employee {

        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Department Department { get; set; }
    }
}