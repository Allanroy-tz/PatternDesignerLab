namespace Chain_of_Responsibility_Pattern
{
    public class Tz20200440718_LeaveRequest
    {
        private string leaveName;
        private int leaveTime;
        /// <param name="leaveName"></param>
        /// <param name="leaveTime">请假时长,单位为：分钟</param>
        public Tz20200440718_LeaveRequest(string leaveName,int leaveTime) { this.leaveTime = leaveTime;this.leaveName = leaveName; }
        public void SetLeaveName(string leaveName) { this.leaveName = leaveName; }
        public string GetLeaveName() { return this.leaveName; }
        public void SetLeaveTime(int leaveTime) { this.leaveTime = leaveTime; }
        public int GetLeaveTime() { return leaveTime; }
    }
}