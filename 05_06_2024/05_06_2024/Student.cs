namespace _05_06_2024
{
    //public,internal, private, protected
    //private protected, protected internal
    public class Student : Person
    {
        protected internal int grade;

        public Student()
        {

        }

        public Student(string name, string surname, int age, int grade) : base(name, surname, age)
        {
            this.grade = grade;
        }

        public string GetInfo()
        {
            return $"Name: {name} - Surname: {surname} - Age: {age}";
        }
    }
}