namespace Git.Classes
{
    public class Manager : Person 
    {
        public double experience;

        public Manager(double experience) 
        {
            this.experience = experience;
        }

        public Manager(string name, double experience) : base(name) 
        {
            this.experience = experience;
        }

        public new void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"experience: {experience}\n");
        }

        public override void GetCredo()
        {
            Console.WriteLine("I am a good manager");
        }

        public void GetExpirience()
        {
            Console.WriteLine(experience);
        }
    }
}
