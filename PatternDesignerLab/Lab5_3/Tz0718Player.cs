using System;

namespace Lab5_3
{
    public class Tz0718Player
    {
        string name;
        string body;
        string costume;
        Tz0718Weapon weapon;
        Tz0718State state;
        public Tz0718Player(string name) { this.name = name; }
        public void SetName(string name) { this.name = name; }
        public string GetName()
        {
            return name;
        }
        public string GetBody() { return body; }
        public string GetCostume() { return costume; }
        public Tz0718Weapon GetWeapon()
        {
            return weapon;
        }
        public void Pause() { state.Pause(); }

        internal void SetWeapon(Tz0718Weapon weapon)
        {
            this.weapon = weapon;
        }

        public void Start() { state.Start(); }
        public void Attack() { state.Attack(); }
        public void Move() { state.Move(); }
        public void SetState(Tz0718State state) { this.state = state; }
        public void SetBody(string body)
        {
            this.body = body;
        }

        public void Hurt()
        {
            state.Hurt();
        }

        public void SetCostume(string costume)
        {
            this.costume = costume;
        }
        public void DescribePlayer()
        {
            System.Console.WriteLine("角色名字：{0}", name);
            System.Console.WriteLine("角色造型：{0}", body);
            System.Console.WriteLine("角色服装：{0}", costume);
            System.Console.WriteLine("角色武器：{0}", weapon.GetWeaponName());
        }
    }
}