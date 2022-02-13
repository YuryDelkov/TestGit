using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitApp
{
    interface IWeapon
    {
        int Damage { get; set; }
        void Fire();
    }
}
