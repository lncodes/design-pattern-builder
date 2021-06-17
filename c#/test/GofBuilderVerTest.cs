using Xunit;

namespace Lncodes.Tutorial.Builder.Test
{
    public sealed class GofBuilderVerTest
    {
        [Theory]
        [ClassData(typeof(GofBuilderTheoryData))]
        public void Gof_Build_Character_AreEqual(Builder builder, object[] expected)
        {
            var director = new Director(builder);

            director.ConstructCompleteCharacter();
            var builderResult = director.GetResult();

            var actual = builderResult.GetData();
            Assert.Equal(actual, expected);
        }
    }
}
