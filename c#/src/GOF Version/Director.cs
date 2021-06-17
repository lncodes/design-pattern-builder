namespace Lncodes.Tutorial.Builder
{
    public sealed class Director
    {
        private readonly Builder _builder = default;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="builder"></param>
        public Director (Builder builder) =>
            _builder = builder;

        /// <summary>
        /// Method to construct a complete character
        /// </summary>
        public void ConstructCompleteCharacter()
        {
            _builder.SetCharacterName();
            _builder.SetCharacterHeight();
            _builder.SetCharacterWeight();
            _builder.SetCharacterGender();
            _builder.SetCharacterBirthDate();
        }

        /// <summary>
        /// Method to construct a nameless character
        /// </summary>
        public void ConstructNamelessCharacter()
        {
            _builder.SetCharacterHeight();
            _builder.SetCharacterWeight();
            _builder.SetCharacterGender();
            _builder.SetCharacterBirthDate();
        }

        /// <summary>
        /// Method get the result of builder pattern 
        /// </summary>
        /// <returns cref="Character"></returns>
        public Character GetResult() =>
            _builder.GetResult();
    }
}
