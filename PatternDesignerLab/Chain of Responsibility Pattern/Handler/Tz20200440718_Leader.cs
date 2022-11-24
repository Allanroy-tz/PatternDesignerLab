
namespace Chain_of_Responsibility_Pattern
{
    public abstract class Tz20200440718_Leader
    {
        protected string name;
        protected Tz20200440718_Leader successor;

        public Tz20200440718_Leader(string name) { this.name = name; }
        public void SetSuccessor(Tz20200440718_Leader successor) { this.successor = successor; }
        public abstract void HandleRequest(Tz20200440718_LeaveRequest request);
    }
}