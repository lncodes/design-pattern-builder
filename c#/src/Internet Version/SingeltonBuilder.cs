using System;

namespace Lncodes.Tutorial.Builder
{
    public sealed class SingeltonBuilder
    {
        private string _name;
        private float _height;
        private float _weight;
        private Gender _gender;
        private DateTime _birthDate;

        #region Singelton
        /// <summary>
        /// Class instance
        /// </summary>
        private static readonly Lazy<SingeltonBuilder> _instance = new Lazy<SingeltonBuilder>(CreateInstance);

        /// <summary>
        /// Constructor
        /// </summary>
        private SingeltonBuilder() { }

        /// <summary>
        /// Method to create class instance
        /// </summary>
        /// <returns cref="SingeltonBuilder"></returns>
        private static SingeltonBuilder CreateInstance() =>
            new SingeltonBuilder();

        /// <summary>
        /// Method to get class instance
        /// </summary>
        /// <returns cref="SingeltonBuilder"></returns>
        public static SingeltonBuilder GetInstance() =>
            _instance.Value;
        #endregion

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
        /// <returns cref="Character"></returns>
        public Character GetResult() =>
            new Character(_name, _height, _weight, _gender, _birthDate);
    }
}
