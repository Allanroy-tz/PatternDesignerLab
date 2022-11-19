
namespace Chain_of_Responsibility_Pattern
{
    public abstract class Leader
    {
        protected string name;
        protected Leader successor;

        public Leader(string name) { this.name = name; }
        public void SetSuccessor(Leader successor) { this.successor = successor; }
        public abstract void HandleRequest(LeaveRequest request);
    }
}