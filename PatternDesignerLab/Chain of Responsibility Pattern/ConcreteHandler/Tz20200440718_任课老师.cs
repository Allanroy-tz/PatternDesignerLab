
namespace Chain_of_Responsibility_Pattern
{
    public class Tz20200440718_任课老师 : Tz20200440718_Leader
    {
        public Tz20200440718_任课老师(string name) : base(name) { }
        public override void HandleRequest(Tz20200440718_LeaveRequest request)
        {
            if(request.GetLeaveTime()<=15)
            {
                System.Console.WriteLine("任课老师“{0}”批准了“{1}”的请假条，请假时间为“{2}”分钟", name, request.GetLeaveName(), request.GetLeaveTime());
            }
            else
            {
                if(successor!=null)
                {
                    successor.HandleRequest(request);
                }
            }
        }
    }
}