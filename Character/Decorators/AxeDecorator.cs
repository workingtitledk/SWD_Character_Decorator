using System;
using Character.Interfaces;

namespace Character.Decorators
{
    public class AxeDecorator : CharacterDecorator
    {
        public AxeDecorator(ICharacter character) : base(character)
        {
        }

        public override void Render()
        {
            base.Render();

            DrawAxe();
        }

        private void DrawAxe()
        {
            Console.WriteLine("Decorating character with an axe.");
        }
    }
}