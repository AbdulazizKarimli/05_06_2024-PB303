namespace _05_06_2024
{
    class Employee : Person
    {
        public int salary;

        public Employee(string name, string surname, int age, int salary) : base(name, surname, age)
        {
            this.salary = salary;
        }
    }
}
