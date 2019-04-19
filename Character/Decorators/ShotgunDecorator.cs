using System;
using Character.Interfaces;

namespace Character.Decorators
{
    public class ShotgunDecorator : CharacterDecorator
    {
        public ShotgunDecorator(ICharacter character) : base(character)
        {
        }

        public override void Render()
        {
            base.Render();

            DrawShotgun();
        }

        private void DrawShotgun()
        {
            Console.WriteLine("Decorating character with a shotgun.");
        }
    }
}