using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_2
{
    class Tz0718MeetingList
    {
        List<Tz0718User> meetingList = new List<Tz0718User>();
        public void AddUser(Tz0718User user) { meetingList.Add(user); }
        public void RemoveUser(Tz0718User user) { meetingList.Remove(user); }
        public void SendNoticeInfo(string msg)
        {
            System.Console.WriteLine("给会议成员发送通知");
            foreach (Tz0718User user in meetingList)
            {
                user.Action(msg);
            }
        }
    }
}
