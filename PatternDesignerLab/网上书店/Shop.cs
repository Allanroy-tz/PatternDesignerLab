namespace 网上书店
{
    public class Shop : Subject
    {
        public override void Attach(Observer obs)
        {
            userList.Add(obs);
        }

        public override void Detach(Observer obs)
        {
            userList.Remove(obs);
        }

        public override void Notify()
        {
            foreach (Observer obs in userList)
            {
                obs.Update();
            }
        }
    }
}