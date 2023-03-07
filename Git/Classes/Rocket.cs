namespace Git.Classes
{
    internal class Rocket
    {
        Manager manager;

        public Rocket()
        {
            manager = new Manager("Vasilii", 5);
        }

        public void Start()
        {
            manager.GetCredo();
        }
    }
}
