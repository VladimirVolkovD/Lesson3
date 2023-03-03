using System.Text;
using System.Text.RegularExpressions;

namespace Git
{
    internal class Lesson4
    {
        public static void Regex()
        {
            //####-####-####-####
            string bankCard = "4566-4582-8946-2695";
            Regex regex = new Regex("^[0-9]{4}-[0-9]{4}-[0-9]{4}-[0-9]{4}$");
            Match match = regex.Match(bankCard);

            if (match.Success)
            {
                Console.WriteLine(bankCard);
            }
            else
            {
                Console.WriteLine("Wrong");
            }
        }

        public static void BankCard()
        {

            string bankCard = "4562,1564,1565,9874";

            string[] bankCardNumbers = bankCard.Split(",");
            foreach (string block in bankCardNumbers)
            {
                Console.WriteLine(block);
            }

            string result = string.Concat("asdfasdf ", "asdfasdf ");
        }

        public static void FirstWordLetterToUpperCase()
        {
            string sentence = "helo my name I Henri my secret password is secret";

            string[] words = sentence.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                words[i] = word.Replace(word[0], char.ToUpper(word[0]));
            }

            string result = string.Join(" ", words);

            Console.WriteLine(result);
        }

        public static void Replace()
        {
            string words = "helo abc my name I Henri my secret password is *secret*";

            string result = words.Replace("abc", "*");
            Console.WriteLine(result);

            int firstIndex = words.IndexOf("*");
            int lastIndex = words.LastIndexOf("*");

            result = words.Substring(firstIndex + 1, lastIndex - firstIndex - 1);
            Console.WriteLine(result);

            string example = "e";
            firstIndex = example.IndexOf("e");
            Console.WriteLine(example.Insert(firstIndex + 1, "^"));

            char symbol = 'e';
            string symbolString = "954893jsoidfjg";

            Console.WriteLine(words.Replace("edsafghjkl;lhgjkjfdhsa", "e^"));
            Console.WriteLine(words.Replace('e', 'a'));
        }

        public static void EmptyString()
        {
            string emptyString = "";
            string emptyStringBylClasss = string.Empty;
            string emptyStringWithWhiteSpace = " ";
            string nullString = null;

            Console.WriteLine(string.IsNullOrEmpty(emptyString));
            Console.WriteLine(string.IsNullOrEmpty(emptyStringBylClasss));
            Console.WriteLine(string.IsNullOrEmpty(emptyStringWithWhiteSpace));
            Console.WriteLine(string.IsNullOrEmpty(nullString));

            Console.WriteLine(string.IsNullOrWhiteSpace(emptyString));
            Console.WriteLine(string.IsNullOrWhiteSpace(emptyStringBylClasss));
            Console.WriteLine(string.IsNullOrWhiteSpace(emptyStringWithWhiteSpace));
            Console.WriteLine(string.IsNullOrWhiteSpace(nullString));
        }

        public static void Strings()
        {
            StringBuilder stringBuilder = new StringBuilder("Hello I am User");
            stringBuilder.Append(" not like you ahah");
            Console.WriteLine(stringBuilder.ToString());

            int age = 25;
            double height = 1.836484;
            int number = 2175684;
            Console.WriteLine(height);
            Console.WriteLine(number.ToString("+37517 ### ## ##"));

            string s1 = "Hello";
            string s2 = "I";
            string s3 = "am";
            string s4 = "student";

            string[] arrays = { s1, s2, s3, s4 };

            string result = string.Join("-|-", arrays);

            string name = Console.ReadLine();
            string baseHelloString = "Hello !";
            Console.WriteLine(baseHelloString + name);
            Console.WriteLine($"Hello {name}");

            Console.WriteLine(baseHelloString.Insert(0, name));

            Console.WriteLine(string.Format("Hello {0}", name));

            Console.WriteLine(string.Format("Hello {0}, my name is {1}", name, 123));

            string bankHelloString = "Hello your bank account : BYN65A51148142684829";

            int index = bankHelloString.IndexOf("t");
            Console.WriteLine(bankHelloString.ToUpper());
            Console.WriteLine(bankHelloString.Replace("ou", "Test"));
        }
    }
}
