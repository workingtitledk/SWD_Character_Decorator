using System;
using Character.Interfaces;

namespace Character.Decorators
{
    public class VikingDecorator : CharacterDecorator
    {
        public VikingDecorator(ICharacter character) : base(character)
        {
        }

        public override void Render()
        {
            base.Render();

            DrawViking();
        }

        private void DrawViking()
        {
            Console.WriteLine("Decorating character as a viking.");
        }
    }
}