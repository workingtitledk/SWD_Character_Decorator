using System;
using Character.Interfaces;

namespace Character.Decorators
{
    public class SwordDecorator : CharacterDecorator
    {
        public SwordDecorator(ICharacter character) : base(character)
        {
        }

        public override void Render()
        {
            base.Render();

            DrawSword();
        }

        private void DrawSword()
        {
            Console.WriteLine("Decorating character with a sword.");
        }
    }
}