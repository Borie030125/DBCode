namespace DBCode.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        public int Age { get; set; }
        public Student()
        {

        }

        public Student(int id, string name, string city, int age)
        {
            Id = id;
            Name = name;
            City = city;
            Age = age;
        }
    }
}
