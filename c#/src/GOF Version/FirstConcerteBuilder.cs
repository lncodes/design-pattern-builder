using System;

namespace Lncodes.Tutorial.Builder
{
    public sealed class FirstConcerteBuilder : Builder
    {
        ///<inheritdoc cref="Builder"/>
        internal override void SetCharacterName() =>
            Name = "Smith";

        ///<inheritdoc cref="Builder"/>
        internal override void SetCharacterHeight() =>
            Height = 175.25f;

        ///<inheritdoc cref="Builder"/>
        internal override void SetCharacterWeight() =>
            Weight = 70f;

        ///<inheritdoc cref="Builder"/>
        internal override void SetCharacterGender() =>
            Gender = Gender.Male;

        ///<inheritdoc cref="Builder"/>
        internal override void SetCharacterBirthDate() =>
            BirthDate = DateTime.Parse("05/20/1999");

        ///<inheritdoc cref="Builder"/>
        internal override Character GetResult() =>
            new Character(Name, Height, Weight, Gender, BirthDate);
    }
}
