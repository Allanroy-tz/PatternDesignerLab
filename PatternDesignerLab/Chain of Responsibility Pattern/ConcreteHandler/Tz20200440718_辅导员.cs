

namespace Chain_of_Responsibility_Pattern
{
    public class Tz20200440718_辅导员 : Tz20200440718_Leader
    {
        public Tz20200440718_辅导员(string name) : base(name) { }
        public override void HandleRequest(Tz20200440718_LeaveRequest request)
        {
            if (request.GetLeaveTime() <= 60*24)
            {
                System.Console.WriteLine("辅导员“{0}”批准了“{1}”的请假条，请假时间为“{2}”小时", name, request.GetLeaveName(), request.GetLeaveTime() / 60);
            }
            else
            {
                if (successor != null)
                {
                    successor.HandleRequest(request);
                }
            }
        }
    }
}