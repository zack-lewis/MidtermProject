namespace MidtermProject {
    // The Employee class should be created in a file called Employee.cs.
    // The Employee class is to have four private properties: firstName, lastName, id, and empType. The empType property is to be an enumerated type named EmployeeType where the fields are Sales, Manager, Production. The firstName, lastName, and id properties are strings that denote the person's name and identification number respectively.
    // The Employee class is to have a constructor that accepts firstName, lastName, id, and empType to initialize a new instance of an Employee and sets its properties.
    // The Person class is to have a public method (function) that prints information about the person. So, for example, if employee is “Truman Tiger” with id: 12345, and is a sales person  this method is to return:
    // “Name: Truman Tiger
    // ID: 12345
    // Type: Sales"
    // The Employee class should also have methods that:
    //     Gets the employee's first name
    //     Sets the employee's first name
    //     Gets the employee's last name
    //     Sets the employee's last name
    //     Gets the employee's empType
    //     Sets the employee's empType (empType should be an enumerated type called EmployeeType where the fields are SalesPerson, Manager, Production)
    //     Gets the employee's id
    class Employee {
        private string firstName;
        private string lastName;
        private string id;
        private EmployeeType empType;

        public Employee(string firstName, string lastName, string id, EmployeeType empType) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
            this.empType = empType;
        }

        public void setFirstName(string input) {
            this.firstName = input;
        }

        public string getFirstName() {
            return this.firstName;
        }

        public void setLastName(string input) {
            this.lastName = input;
        }

        public string getlastName() {
            return this.lastName;
        }

        public string getID() {
            return this.id;
        }

        public void setEmpType(EmployeeType input) {
            this.empType = input;
        }

        public EmployeeType GetEmployeeType() {
            return this.empType;
        }

        public void getEmployeeInfo() {
            System.Console.WriteLine($"Name: { this.firstName } { this.lastName }");
            System.Console.WriteLine($"ID: { this.id }");
            System.Console.WriteLine($"Employee Type: { this.empType }");
        }
    }
}