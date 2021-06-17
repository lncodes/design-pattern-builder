using System;

namespace Lncodes.Tutorial.Builder
{
    public sealed class SecondConcerteBuilder : Builder
    {
        ///<inheritdoc cref="Builder"/>
        internal override void SetCharacterName() =>
            Name = "Olivia";

        ///<inheritdoc cref="Builder"/>
        internal override void SetCharacterHeight() =>
            Height = 170.5f;

        ///<inheritdoc cref="Builder"/>
        internal override void SetCharacterWeight() =>
            Weight = 55;

        ///<inheritdoc cref="Builder"/>
        internal override void SetCharacterGender() =>
            Gender = Gender.Female;

        ///<inheritdoc cref="Builder"/>
        internal override void SetCharacterBirthDate() =>
            BirthDate = DateTime.Parse("05/20/1995");

        ///<inheritdoc cref="Builder"/>
        internal override Character GetResult() =>
            new Character(Name, Height, Weight, Gender, BirthDate);
    }
}
