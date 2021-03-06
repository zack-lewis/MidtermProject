namespace MidtermProject {
    // The Manager class is to be created in a file called Manager.cs and is to be a subclass of the Employee class.
    // The Manager class has two additional new properties beyond what the Employee class supplies, a string department and string region to denote the managers's department and region respectively.
    // The Manager class is to have a constructor that accepts firstName, lastName, id, department and, region to initialize a new instance of a Manager and set its properties. To do this, the Manager class constructor is to call the superclass (Employee) constructor using base() (Links to an external site.). When the superclass constructor is called, the category is to be automatically set to Manager.
    // The Manager class inherits all properties and methods from the Employee class.
    // The Manager class is to also have the following public methods:
    //     A method that gets the manager's department.
    //     A method that sets the manager's department.
    //     A method that gets the manager's region.
    //     A method that sets the manager's region.

    class Manager : Employee{
        private string department; 
        private string region;

        public Manager(string firstName, string lastName, string id, string department, string region) : base(firstName, lastName, id, EmployeeType.Manager) {
            setDepartment(department);
            setRegion(region);
        }

        public string getRegion() {
            return this.region;
        }

        public void setRegion(string input) {
            if(input == null || input == "") {
                throw new System.ArgumentException("Region cannot be empty");
            }

            this.region = input;
        }

        public string getDepartment() {
            return this.department;
        }

        public void setDepartment(string input) {
            if(input == null || input == "") {
                throw new System.ArgumentException("Department cannot be empty");
            }

            this.department = input;
        }
    }

}