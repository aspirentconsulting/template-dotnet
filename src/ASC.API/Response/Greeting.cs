namespace ASC.API.Response
{
    public class Greeting
    {
        public Greeting(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
