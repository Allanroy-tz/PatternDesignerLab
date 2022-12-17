using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_3
{
    class DeathState : Tz0718State
    {
        public DeathState(Tz0718Player player)
        {
            this.player = player;
            System.Console.WriteLine("角色处于死亡状态");
        }
        public override void Attack()
        {
            System.Console.WriteLine("{0}死了，无法攻击", player.GetName());
        }

        public override void Hurt()
        {
            System.Console.WriteLine("{0}处于死亡状态无法受到攻击", player.GetName());
        }

        public override void Move()
        {
            System.Console.WriteLine("{0}处于死亡状态无法受到移动", player.GetName());
        }

        public override void Pause()
        {
            System.Console.WriteLine("{0}处于死亡状态，游戏暂停", player.GetName());
        }

        public override void Start()
        {
            System.Console.WriteLine("{0}处于死亡状态，游戏开始", player.GetName());
        }
    }
}
