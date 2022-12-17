using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_1
{
    public class Tz0718BookStoreConcretSubject : Tz0718Subject
    {
        public override void Notify(string msg)
        {
            foreach (Tz0718User user in userList)
            {
                user.Response(msg);
            }
        }
    }
}