using System;

namespace Chain_of_Responsibility_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Tz20200440718_Leader 任课老师, 班主任, 辅导员, 学院副书记, 学院书记;
            任课老师 = new Tz20200440718_任课老师("李老师");
            班主任 = new Tz20200440718_班主任("王老师");
            辅导员 = new Tz20200440718_辅导员("张老师");
            学院副书记 = new Tz20200440718_学院副书记("郑书记");
            学院书记 = new Tz20200440718_学院书记("傅书记");
            任课老师.SetSuccessor(班主任);
            班主任.SetSuccessor(辅导员);
            辅导员.SetSuccessor(学院副书记);
            学院副书记.SetSuccessor(学院书记);
            学院书记.SetSuccessor(null);

            Tz20200440718_LeaveRequest 张三的请假条 = new Tz20200440718_LeaveRequest("张三", 10);
            任课老师.HandleRequest(张三的请假条);
            Tz20200440718_LeaveRequest 李四的请假条 = new Tz20200440718_LeaveRequest("李四", 45);
            任课老师.HandleRequest(李四的请假条);
            Tz20200440718_LeaveRequest 王五的请假条 = new Tz20200440718_LeaveRequest("王五", 60*4);
            任课老师.HandleRequest(王五的请假条);
            Tz20200440718_LeaveRequest 刘六的请假条 = new Tz20200440718_LeaveRequest("刘六", 60 * 24*2);
            任课老师.HandleRequest(刘六的请假条);
            Tz20200440718_LeaveRequest 三七的请假条 = new Tz20200440718_LeaveRequest("三七", 60 * 24 * 4);
            任课老师.HandleRequest(三七的请假条);
            Tz20200440718_LeaveRequest 学霸的请假条 = new Tz20200440718_LeaveRequest("学霸", 60 * 24 * 100);
            任课老师.HandleRequest(学霸的请假条);
        }
    }
}
