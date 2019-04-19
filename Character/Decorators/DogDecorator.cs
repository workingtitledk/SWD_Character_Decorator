using System;
using Character.Interfaces;

namespace Character.Decorators
{
    public class DogDecorator : CharacterDecorator
    {
        public DogDecorator(ICharacter character) : base(character)
        {
        }

        public override void Render()
        {
            base.Render();

            DrawDog();
        }

        private void DrawDog()
        {
            Console.WriteLine("Decorating character with a dog sidekick.");
        }
    }
}