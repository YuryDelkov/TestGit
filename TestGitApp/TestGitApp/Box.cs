using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitApp
{
    internal class Box : IHasInfo
    {
        public void ShowInfo()
        {
            Console.WriteLine("Красивая коробка!");
        }
    }
}
