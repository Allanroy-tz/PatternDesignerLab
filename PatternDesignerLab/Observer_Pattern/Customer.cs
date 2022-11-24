namespace Observer_Pattern
{
    public class Customer : Observer
    {
        string name;
        public string Name { get { return name; } }

        public Customer(string name) { this.name = name; }
        public void Update()
        {
            System.Console.WriteLine("{0}收到了通知",name);
        }
    }
}