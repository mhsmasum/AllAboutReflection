using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseOfReflection
{
    public interface ICharacter
    {
         EnumCharacterClass CharacterClass { get; }
         void Attack() { }
    }

    public enum EnumCharacterClass
    {
        Thief,
        Fighter,
        Cleric,
        Wizard,
        ProjectManager

    }
}
