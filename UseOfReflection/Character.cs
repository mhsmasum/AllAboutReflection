using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseOfReflection
{
    public abstract class Character : ICharacter
    {
        public abstract EnumCharacterClass CharacterClass { get; }
        public void Attack()
        {
            Console.WriteLine("Character Attacks");
        }

        public void Defend()
        {
            Console.WriteLine("Character Defends");
        }
    }

    public class Thief : Character
    {
        public override EnumCharacterClass CharacterClass { get { return EnumCharacterClass.Thief; } }

        public void Backstab()
        {
            Console.WriteLine("Thief Backstabs;");
        }
    }

    public class ProjectManager : Character
    {
        public override EnumCharacterClass CharacterClass { get { return EnumCharacterClass.Thief; } }

        public void Backstab()
        {
            Console.WriteLine("Project Manager Backstabs;");
        }
    }

    public class Salesperson : Character
    {
        public override EnumCharacterClass CharacterClass { get { return EnumCharacterClass.Thief; } }

        public void Backstab()
        {
            Console.WriteLine("Salesperson Backstabs;");
        }
    }

    public class Wizard : Character
    {
        public override EnumCharacterClass CharacterClass { get { return EnumCharacterClass.Wizard; } }
    }

    public class Fighter : Character
    {
        public override EnumCharacterClass CharacterClass { get { return EnumCharacterClass.Fighter; } }
    }

    public class Cleric : Character
    {
        public override EnumCharacterClass CharacterClass { get { return EnumCharacterClass.Cleric; } }
    }

    
}
