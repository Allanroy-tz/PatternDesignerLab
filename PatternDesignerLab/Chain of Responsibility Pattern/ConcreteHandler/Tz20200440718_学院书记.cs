namespace Chain_of_Responsibility_Pattern
{
    public class Tz20200440718_学院书记 : Tz20200440718_Leader
    {
        public Tz20200440718_学院书记(string name) : base(name) { }
        public override void HandleRequest(Tz20200440718_LeaveRequest request)
        {
            if (request.GetLeaveTime() <= 60 * 24*7)
            {
                System.Console.WriteLine("学院书记“{0}”批准了“{1}”的请假条，请假时间为“{2}”天", name, request.GetLeaveName(), request.GetLeaveTime() / (60 * 24));
            }
            else
            {
                System.Console.WriteLine("“{0}”想要请假“{1}”天,那得去办休学手续了！", request.GetLeaveName(),request.GetLeaveTime()/(24*60));
            }
        }
    }
}