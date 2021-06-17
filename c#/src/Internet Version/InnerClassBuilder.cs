using System;

namespace Lncodes.Tutorial.Builder
{
    public sealed class InnerClassBuilder
    {
        private string _name;
        private float _height;
        private float _weight;
        private Gender _gender;
        private DateTime _birthDate;

        /// <summary>
        /// Method to set character name 
        /// </summary>
        /// <param name="name"></param>
        public void SetCharacterName(string name) =>
            _name = name;

        /// <summary>
        /// Method to set character height
        /// </summary>
        /// <param name="height"></param>
        public void SetCharacterHeight(float height) =>
            _height = height;

        /// <summary>
        /// Method to set character weight
        /// </summary>
        /// <param name="weight"></param>
        public void SetCharacterWeight(float weight) =>
            _weight = weight;

        /// <summary>
        /// Method to set character gender
        /// </summary>
        /// <param name="gender"></param>
        public void SetCharacterGender(Gender gender) =>
            _gender = gender;

        /// <summary>
        /// Method to set character birth date
        /// </summary>
        /// <param name="birthDate"></param>
        public void SetCharacterBirthDate(DateTime birthDate) =>
            _birthDate = birthDate;

        /// <summary>
        /// Method get the result of builder pattern
        /// </summary>
        /// <returns cref="InnerCharacter"></returns>
        public InnerCharacter GetResult() =>
            new InnerCharacter(this);

        public sealed class InnerCharacter
        {
            private readonly string _name;
            private readonly float _height;
            private readonly float _weight;
            private readonly Gender _gender;
            private readonly DateTime _birthDate;

            /// <summary>
            /// Constructor
            /// </summary>
            /// <param name="builder"></param>
            public InnerCharacter(InnerClassBuilder builder)
            {
                _name = builder._name;
                _height = builder._height;
                _weight = builder._weight;
                _gender = builder._gender;
                _birthDate = builder._birthDate;
            }

            /// <summary>
            /// Method to get the player data
            /// </summary>
            /// <returns cref="object[]">Player data</returns>
            public object[] GetData() =>
                new object[] { _name, _height, _weight, _gender, _birthDate };
        }
    }
}
