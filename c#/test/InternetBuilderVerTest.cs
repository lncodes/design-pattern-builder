using Xunit;
using System;

namespace Lncodes.Tutorial.Builder.Test
{
    public sealed class InternetBuilderVerTest
    {
        [Theory]
        [ClassData(typeof(InternetBuilderTheoryData))]
        public void Fluent_Build_Character_AreEqual(string name, float height, float weight, Gender gender, DateTime birthDate) 
        {
            var character = new FluentBuilder()
                .SetCharacterName(name)
                .SetCharacterHeight(height)
                .SetCharacterWeight(weight)
                .SetCharacterGender(gender)
                .SetCharacterBirthDate(birthDate)
                .GetResult();

            var actual = character.GetData();

            Assert.Equal(actual, new object[] { name, height, weight, gender, birthDate });
        }

        [Theory]
        [ClassData(typeof(InternetBuilderTheoryData))]
        public void Generic_Build_Character_AreEqual(string name, float height, float weight, Gender gender, DateTime birthDate)
        {
            var builder = new GenericBuilder<Character>();

            builder.SetCharacterName(name);
            builder.SetCharacterHeight(height);
            builder.SetCharacterWeight(weight);
            builder.SetCharacterGender(gender);
            builder.SetCharacterBirthDate(birthDate);
            var character = builder.GetResult();

            var actual = character.GetData();

            Assert.Equal(actual, new object[] { name, height, weight, gender, birthDate });
        }

        [Theory]
        [ClassData(typeof(InternetBuilderTheoryData))]
        public void Inner_Build_Character_AreEqual(string name, float height, float weight, Gender gender, DateTime birthDate)
        {
            var builder = new InnerClassBuilder();

            builder.SetCharacterName(name);
            builder.SetCharacterHeight(height);
            builder.SetCharacterWeight(weight);
            builder.SetCharacterGender(gender);
            builder.SetCharacterBirthDate(birthDate);
            var character = builder.GetResult();

            var actual = character.GetData();

            Assert.Equal(actual, new object[] { name, height, weight, gender, birthDate });
        }

        [Theory]
        [ClassData(typeof(InternetBuilderTheoryData))]
        public void Singleton_Build_Character_AreEqual(string name, float height, float weight, Gender gender, DateTime birthDate)
        {
            var builder = SingeltonBuilder.GetInstance();

            builder.SetCharacterName(name);
            builder.SetCharacterHeight(height);
            builder.SetCharacterWeight(weight);
            builder.SetCharacterGender(gender);
            builder.SetCharacterBirthDate(birthDate);
            var character = builder.GetResult();

            var actual = character.GetData();

            Assert.Equal(actual, new object[] { name, height, weight, gender, birthDate });
        }
    }
}
