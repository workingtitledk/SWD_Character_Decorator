using System;
using Character.Interfaces;

namespace Character.Decorators
{
    public class OwlDecorator : CharacterDecorator
    {
        public OwlDecorator(ICharacter character) : base(character)
        {
        }

        public override void Render()
        {
            base.Render();

            DrawOwl();
        }

        private void DrawOwl()
        {
            Console.WriteLine("Decorating character with an owl sidekick.");
        }
    }
}