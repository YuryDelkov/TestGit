using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitApp
{
    abstract class Weapon : IHasInfo, IWeapon
    {
        public abstract int Damage { get; set; }

        public abstract void Fire();

        public void ShowInfo()
        {
            Console.WriteLine($"Тип - {GetType().Name}; Урон - {Damage}");
        }
    }

    class Pistol : Weapon
    {
        public override int Damage { get; set; }

        public Pistol(int damage)
        {
            Damage = damage;
        }

        public override void Fire()
        {
            Console.WriteLine($"Выстрел из пистолета!");
        }
    }

    class Rifle : Weapon
    {
        public override int Damage { get; set; }

        public Rifle(int damage)
        {
            Damage = damage;
        }

        public override void Fire()
        {
            Console.WriteLine($"Выстрел из винтовки!");
        }
    }
}
