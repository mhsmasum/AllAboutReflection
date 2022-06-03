using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseOfReflection
{
    public class Battle
    {
        ICharacter _CurrentCharacter;
        public Battle(ICharacter currentCharacter)
        {
            _CurrentCharacter = currentCharacter;
        }
        public void RearAttack()
        {
            switch (_CurrentCharacter.CharacterClass)
            {
                case EnumCharacterClass.Thief:
                    {
                        Thief MyThief = new Thief();
                        MyThief.Backstab();
                    }
                    break;
                case EnumCharacterClass.ProjectManager:
                    {
                        ProjectManager MyProjectManager = new ProjectManager();
                        MyProjectManager.Backstab();
                       
                    }
                    break;
                case EnumCharacterClass.Wizard:
                    {
                        _CurrentCharacter.Attack();
                    }
                    break;
                case EnumCharacterClass.Fighter:
                    {
                        _CurrentCharacter.Attack();
                    }
                    break;
                case EnumCharacterClass.Cleric:
                    {
                        _CurrentCharacter.Attack();
                    }
                    break;
            }


        }
    }
}
