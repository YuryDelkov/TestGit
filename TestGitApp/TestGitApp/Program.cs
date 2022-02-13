using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Weapon[] weapons = new Weapon[2] {new Pistol(10), new Rifle(50)};

            foreach(var weapon in weapons)
            {
                player.CheckInfo(weapon);
                player.Fire(weapon);
            }

            Console.WriteLine();

            Box box = new Box();
            player.CheckInfo(box);

            Console.ReadKey();
        }
    }
}