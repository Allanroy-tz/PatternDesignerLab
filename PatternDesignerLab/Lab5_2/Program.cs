using System;

namespace Lab5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Tz0718User user1 = new Tz0718Employee("成员1");
            Tz0718User user2 = new Tz0718Employee("成员2");
            Tz0718User user3 = new Tz0718Employee("成员3");
            Tz0718User user4 = new Tz0718Employee("成员4");
            Tz0718User user5 = new Tz0718Employee("成员5");
            Tz0718Department department01 = new Tz0718Department("部门1");
            department01.Add(user1);
            department01.Add(user2);
            department01.Add(user3);
            Tz0718Department department02 = new Tz0718Department("部门2");
            department02.Add(user3);
            department02.Add(user4);
            department02.Add(user5);

            Console.WriteLine("-----开始发送消息-----");
            Tz0718MeetingList meeting = new Tz0718MeetingList();
            meeting.AddUser(user5);
            meeting.AddUser(department01);
            meeting.SendNoticeInfo("开始第二次会议");
            Console.WriteLine("-----向单个成员发送消息-----");
            department01.SendMsg("成员1", "准备答辩");
            department01.SendMsg("成员2", "准备答辩");
            Console.WriteLine("-----向部门全部成员发送消息-----");
            department02.Action("明天放假");
        }
    }
}
