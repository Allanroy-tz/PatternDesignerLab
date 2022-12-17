using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_3
{
    class Tz0718PauseState : Tz0718State
    {
        public Tz0718PauseState(Tz0718Player player)
        {
            this.player=player;
            System.Console.WriteLine("角色处于暂停状态");
        }
        public override void Attack()
        {
            System.Console.WriteLine("{0}处于暂停状态,无法攻击", player.GetName());
        }

        public override void Hurt()
        {
            System.Console.WriteLine("{0}处于暂停状态,无法被攻击", player.GetName());
        }

        public override void Move()
        {
            System.Console.WriteLine("{0}处于暂停状态,无法移动", player.GetName());
        }

        public override void Pause()
        {
            System.Console.WriteLine("游戏暂停", player.GetName());
        }

        public override void Start()
        {
            System.Console.WriteLine("游戏开始", player.GetName());
        }
    }
}
