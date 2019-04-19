using System;
using Character.Interfaces;

namespace Character.Decorators
{
    public class RailgunDecorator : CharacterDecorator
    {
        public RailgunDecorator(ICharacter character) : base(character)
        {
        }

        public override void Render()
        {
            base.Render();

            DrawRailgun();
        }

        private void DrawRailgun()
        {
            Console.WriteLine("Decorating character with a railgun.");
        }
    }
}