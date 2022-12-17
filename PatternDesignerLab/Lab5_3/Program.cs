using System;

namespace Lab5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Tz0718WeaponFactory pisf = new Tz0718PistolFactory();
            Tz0718WeaponFactory subf = new Tz0718SubmachineGunFactory(); 
            Tz0718WeaponFactory snif = new Tz0718SniperRifleFactory();
            Tz0718PlayerCreateDirector pcd1 = new Tz0718PlayerCreateDirector();
            Tz0718Player p1 = pcd1.Construct(new Tz0718MaleSoldier("万叶"));
            Tz0718Player p2 = pcd1.Construct(new Tz0718FemaleSoldier("雷电将军")); 
            p1.SetWeapon(subf.CreateWeapon()); p2.SetWeapon(snif.CreateWeapon());
            Console.WriteLine("-----游戏角色信息-----"); p1.DescribePlayer();
            p2.DescribePlayer();
            Console.WriteLine("-----游戏角色行动-----");
            p1.SetState(new Tz0718NormalState(p1)); p1.Pause();
            p1.Start();p1.Attack();p1.Move(); p1.Hurt();
            p1.SetState(new Tz0718PauseState(p1));
            p1.Pause();p1.Start();p1.Attack();p1.Move();p1.Hurt();
            p1.SetState(new DeathState(p1));
            p1.Pause(); p1.Start(); p1.Attack(); p1.Move(); p1.Hurt();

            Console.WriteLine("-----游戏角色更换武器-----"); 
            p1.GetWeapon().Use();
            p1.GetWeapon().DisPlay();
            p1.SetWeapon(snif.CreateWeapon());
            p1.GetWeapon().Use();
            p1.GetWeapon().DisPlay();
            p1.SetWeapon(pisf.CreateWeapon()); p1.GetWeapon().Use();
            p1.GetWeapon().DisPlay();

        }
    }
}
