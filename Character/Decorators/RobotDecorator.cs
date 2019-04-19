using System;
using Character.Interfaces;

namespace Character.Decorators
{
    public class RobotDecorator : CharacterDecorator
    {
        public RobotDecorator(ICharacter character) : base(character)
        {
        }

        public override void Render()
        {
            base.Render();

            DrawRobot();
        }

        private void DrawRobot()
        {
            Console.WriteLine("Decorating character as a robot.");
        }
    }
}