using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Character.Interfaces;

namespace Character
{
    public class BaseCharacter : ICharacter
    {
        public void Render()
        {
            Console.WriteLine("Drawing character outline.");
        }
    }
}
