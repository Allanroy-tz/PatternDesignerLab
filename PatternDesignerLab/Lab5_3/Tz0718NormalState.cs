using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_3
{
    class Tz0718NormalState : Tz0718State
    {
        public Tz0718NormalState(Tz0718Player player)
        {
            this.player = player;
            System.Console.WriteLine("角色是正常状态");
        }
        public override void Attack()
        {
            Console.WriteLine("“正常状态的”{0}在使用{1}", player.GetName(), player.GetWeapon().fire());
        }

        public override void Hurt()
        {
            Console.WriteLine("“正常状态的”{0}收到了伤害", player.GetName());
        }

        public override void Move()
        {
            Console.WriteLine("“正常状态的”{0}在移动", player.GetName());
        }

        public override void Pause()
        {
            Console.WriteLine("“正常状态的”{0}游戏停止", player.GetName());
        }

        public override void Start()
        {
            Console.WriteLine("“正常状态的”{0}游戏开始", player.GetName());
        }
    }
}
