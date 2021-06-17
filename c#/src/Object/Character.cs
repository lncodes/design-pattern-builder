using System;

namespace Lncodes.Tutorial.Builder
{
    public class Character
    {
        protected readonly string _name;
        protected readonly float _height;
        protected readonly float _weight;
        protected readonly Gender _gender;
        protected readonly DateTime _birthDate;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="height"></param>
        /// <param name="weight"></param>
        /// <param name="gender"></param>
        /// <param name="birthDate"></param>
        public Character(string name, float height, float weight, Gender gender, DateTime birthDate) =>
            (_name, _height, _weight, _gender, _birthDate) = (name, height, weight, gender, birthDate);
    
        /// <summary>
        /// Method to get the player data
        /// </summary>
        /// <returns cref="object[]">Player data</returns>
        public object[] GetData() =>
            new object[] { _name, _height, _weight, _gender, _birthDate };
    }
}