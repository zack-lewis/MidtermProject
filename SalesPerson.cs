namespace MidtermProject{
    // The SalesPerson class is to be created in a file called SalesPerson.cs and is to be a subclass of the Employee class.
    // The SalesPerson class will have two additional new properties beyond what the Employee class supplies: a sting called department stating the salesperson's department and an float called total sales stating how much sales the salesperson has.
    // The SalesPerson class is to have a constructor that accepts firstName, lastName, id, department and, sales to initialize a new instance of a SalesPerson and set its properties. To do this, the SalesPerson class constructor is to call the superclass (Employee) constructor using base() (Links to an external site.). When the superclass constructor is called, the empType is to be automatically set to Sales.
    // The SalesPerson class inherits all methods and properties from Employee.
    // The SalesPerson class is also to have the following additional public methods:
    //     A method that updates the sales property by adding "sales" to it. So, if a salesperson currently has $5000 in sales, and they get an additional $1500 in sales, this function should add 1500 to sales to make sales 6500.
    //     A method that returns the salesperson's level. SalesLevel is to be an enumerated type with fields: Platinum, Diamond, Gold, Silver, Bronze. If the salesperson has sales less than $10,000 they are Bronze level, $10,000 to $19,999.99 in sales Silver level, $20,000 to $29,999.99 in sales Gold level, $30,000 to $39,999.99 in sales Diamond level, $40,000 or greater in sales Platinum level.
    
    class SalesPerson : Employee {
        private string department;
        private float sales = 0;

        public SalesPerson(string firstName, string lastName, string id, string department, float sales) : base(firstName, lastName, id, EmployeeType.Sales) {
            updateSales(sales);
            setDepartment(department);
        }

        public void updateSales(float input) {
            if(input < 0) {
                throw new System.ArgumentOutOfRangeException("Sales cannot be negative");
            }

            this.sales += input;
        }

        public float getSales() {
            return this.sales;
        }

        public SalesLevel GetSalesLevel() {
            float current = getSales();
            
            //SalesLevel is to be an enumerated type with fields: Platinum, Diamond, Gold, Silver, Bronze. 
            // If the salesperson has sales less than $10,000 they are Bronze level, 
            // $10,000 to $19,999.99 in sales Silver level, 
            // $20,000 to $29,999.99 in sales Gold level, 
            // $30,000 to $39,999.99 in sales Diamond level, 
            // $40,000 or greater in sales Platinum level.
            if( current<10000 ) {
                return SalesLevel.Bronze;
            }
            else if(current < 20000) {
                return SalesLevel.Silver;
            }
            else if(current < 30000) {
                return SalesLevel.Gold;
            }
            else if(current < 40000) {
                return SalesLevel.Diamond;
            }
            else {
                return SalesLevel.Platinum;
            }
        }

        public void setDepartment(string input) {
            if(input == null || input == "") {
                throw new System.ArgumentException("Department cannot be empty");
            }

            this.department = input;
        }

        public string getDepartment() {
            return this.department;
        }

    }
}