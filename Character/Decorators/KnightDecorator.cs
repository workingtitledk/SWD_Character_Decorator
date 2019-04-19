using System;
using Character.Interfaces;

namespace Character.Decorators
{
    public class KnightDecorator : CharacterDecorator
    {
        public KnightDecorator(ICharacter character) : base(character)
        {
        }

        public override void Render()
        {
            base.Render();

            DrawKnight();
        }

        private void DrawKnight()
        {
            Console.WriteLine("Decorating character as a knight.");
        }
    }
}