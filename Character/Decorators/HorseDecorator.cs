using System;
using Character.Interfaces;

namespace Character.Decorators
{
    public class HorseDecorator : CharacterDecorator
    {
        public HorseDecorator(ICharacter character) : base(character)
        {
        }

        public override void Render()
        {
            base.Render();

            DrawHorse();
        }

        private void DrawHorse()
        {
            Console.WriteLine("Decorating character with a horse sidekick.");
        }
    }
}