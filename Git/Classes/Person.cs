namespace Git.Classes
{
    /// <summary>
    /// Represent person
    /// </summary>
    public class Person
    {
        public string name;
        private int age;

        public string PassportIdNumber { get; set; }

        public Person()
        {
        }

        public Person(string name)
        {
            this.name = name;
        }

        public void GetInfo()
        {
            Console.Write($"Name: {name},  passportNumber: {PassportIdNumber} ");
        }

        public virtual void GetCredo()
        {
            Console.WriteLine("I am good person");
        }

        public void GetAge()
        {
            Console.WriteLine($"Age: {age}");
        }
    }
}
