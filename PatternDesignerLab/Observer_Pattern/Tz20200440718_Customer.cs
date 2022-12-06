namespace Observer_Pattern
{
    public class Tz20200440718_Customer : Tz20200440718_Observer
    {
        string name;
        public string Name { get { return name; } }

        public Tz20200440718_Customer(string name) { this.name = name; }
        public void Update()
        {
            System.Console.WriteLine("{0}收到了通知",name);
        }
    }
}