namespace _04_06_2024
{
    class Student
    {
        public string name;
        public string surname;
        public int age;

        public Student()
        {

        }

        public Student(string name)
        {
            this.name = name;
        }

        public Student(string name, string surname) : this(name)
        {
            this.surname = surname;
        }

        public Student(string name, string surname, int age) : this(name, surname)
        {
            this.age = age;
            //name = Name;
        }

        //public void Test()
        //{
        //    Console.WriteLine("salam");
        //}

        public string GetInfo()
        {
            //Test();
            return $"Name: {name} - Surname: {surname} - Age: {age}";
        }
    }
}
