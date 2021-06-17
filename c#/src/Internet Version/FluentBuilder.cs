using System;

namespace Lncodes.Tutorial.Builder
{
    public sealed class FluentBuilder
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
        /// <returns cref="FluentBuilder"></returns>
        public FluentBuilder SetCharacterName(string name)
        {
            _name = name;
            return this;
        }

        /// <summary>
        /// Method to set character height
        /// </summary>
        /// <param name="height"></param>
        /// <returns cref="FluentBuilder"></returns>
        public FluentBuilder SetCharacterHeight(float height) 
        { 
            _height = height;
            return this;
        }

        /// <summary>
        /// Method to set character weight
        /// </summary>
        /// <param name="weight"></param>
        /// <returns cref="FluentBuilder"></returns>
        public FluentBuilder SetCharacterWeight(float weight)
        {
            _weight = weight;
            return this;
        }

        /// <summary>
        /// Method to set character gender
        /// </summary>
        /// <param name="gender"></param>
        /// <returns cref="FluentBuilder"></returns>
        public FluentBuilder SetCharacterGender(Gender gender)
        {
            _gender = gender;
            return this;
        }

        /// <summary>
        /// Method to set character birth date
        /// </summary>
        /// <param name="birthDate"></param>
        /// <returns cref="FluentBuilder"></returns>
        public FluentBuilder SetCharacterBirthDate(DateTime birthDate)
        {
            _birthDate = birthDate;
            return this;
        }

        /// <summary>
        /// Method get the result of builder pattern
        /// </summary>
        /// <returns cref="Character"></returns>
        public Character GetResult() =>
            new Character(_name, _height, _weight, _gender, _birthDate);
    }
}
