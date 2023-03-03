using Git.Classes;

namespace Git
{
    internal class Program
    {


        static void Main()
        {
            var person = new Person(12, "volodya", 12);
            person.PassportIdNumber  = "asd466as4d8as6a";
            Console.WriteLine(person.PassportIdNumber);
        }

    }
}
