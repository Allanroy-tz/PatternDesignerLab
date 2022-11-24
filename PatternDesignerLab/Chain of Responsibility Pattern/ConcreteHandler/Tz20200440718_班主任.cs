
namespace Chain_of_Responsibility_Pattern
{
    public class Tz20200440718_班主任 : Tz20200440718_Leader
    {
        public Tz20200440718_班主任(string name) : base(name) { }
        public override void HandleRequest(Tz20200440718_LeaveRequest request)
        {
            if (request.GetLeaveTime() <= 45*2+10)
            {
                System.Console.WriteLine("班主任“{0}”批准了“{1}”的请假条，请假时间为“{2}”节课", name, request.GetLeaveName(), request.GetLeaveTime()/45);
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