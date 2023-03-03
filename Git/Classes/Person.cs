using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git.Classes
{
    /// <summary>
    /// Represent person
    /// </summary>
    public class Person
    {
        public string name;
        public int age;
        public int id;


        //private
        string passportIdNumber;

        public string PassportIdNumber
        {
            private get
            {
                return age + passportIdNumber + id;
            }
            private set
            {
                if (value > 18)
                {
                    passportIdNumber = value;
                }               
            }
        }


        public string GetpassportIdNumber()
        {
            return "**" + passportIdNumber + "**";
        }

        public void SetpassportIdNumber(string number)
        {
            passportIdNumber = number;
        }

        public Person()
        {
            passportIdNumber = "115654A016PB3";
        }

        public Person(int age, string name, int id = 1)
        {
            this.name = name;
            this.age = age;
            this.id = id;
        }

        public void GetInfo()
        {
            var passportNumber = GetpassportIdNumber();
            Console.WriteLine($"Name: {name}, age: {age}, id: {passportNumber}");
        }

        public void CompareWith(Person anotherPerson)
        {

            if (anotherPerson.age == this.age)
            {
                Console.WriteLine("Same age!");
            }
            else
            {
                Console.WriteLine("Not same age!");
            }
        }

    }
}
