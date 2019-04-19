using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Character.Interfaces;

namespace Character.Decorators
{
    public abstract class CharacterDecorator : ICharacter
    {
        private ICharacter _character;

        protected CharacterDecorator(ICharacter character)
        {
            _character = character;
        }

        public virtual void Render()
        {
            // Delegation
            _character.Render();
        }
    }
}
