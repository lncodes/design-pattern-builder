using System;

namespace Lncodes.Tutorial.Builder
{
    public abstract class Builder
    {
        protected string Name;
        protected float Height;
        protected float Weight;
        protected Gender Gender;
        protected DateTime BirthDate;

        /// <summary>
        /// Method to set character name 
        /// </summary>
        internal abstract void SetCharacterName();

        /// <summary>
        /// Method to set character height
        /// </summary>
        internal abstract void SetCharacterHeight();

        /// <summary>
        /// Method to set character weight
        /// </summary>
        internal abstract void SetCharacterWeight();

        /// <summary>
        /// Method to set character gender
        /// </summary>
        internal abstract void SetCharacterGender();

        /// <summary>
        /// Method to set character birth date
        /// </summary>
        internal abstract void SetCharacterBirthDate();

        /// <summary>
        /// Method get the result of builder pattern
        /// </summary>
        /// <returns cref="Character"></returns>
        internal abstract Character GetResult();
    }
}
