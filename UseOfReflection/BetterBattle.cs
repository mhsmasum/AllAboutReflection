using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UseOfReflection
{
    public class BetterBattle
    {
        ICharacter _CurrentCharacter;
        public BetterBattle(ICharacter currentCharecter)
        {
            _CurrentCharacter = currentCharecter;
        }

        public void RearAttack()
        {
            var CharacterType = _CurrentCharacter.GetType();

            MethodInfo BackStabMethodInfo = CharacterType.GetMethod("Backstab");

            if (BackStabMethodInfo == null)
            {
                _CurrentCharacter.Attack();
            }
            else
            {
                object BackStabCharacterInstance = Activator.CreateInstance(CharacterType, null);
                BackStabMethodInfo.Invoke(BackStabCharacterInstance, null);
            }


        }
    }

   
}
