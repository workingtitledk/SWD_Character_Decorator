using System;
using Character.Interfaces;

namespace Character.Decorators
{
    public class LionDecorator : CharacterDecorator
    {
        public LionDecorator(ICharacter character) : base(character)
        {
        }

        public override void Render()
        {
            base.Render();

            DrawLion();
        }

        private void DrawLion()
        {
            Console.WriteLine("Decorating character with a lion sidekick.");
        }
    }
}