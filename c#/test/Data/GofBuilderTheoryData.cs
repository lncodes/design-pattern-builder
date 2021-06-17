using Xunit;
using System;

namespace Lncodes.Tutorial.Builder.Test
{
    public sealed class GofBuilderTheoryData : TheoryData<Builder, object[]>
    {
        public GofBuilderTheoryData()
        {
            Add(new FirstConcerteBuilder(), new object[5] { "Smith", 175.25f, 70f, Gender.Male, DateTime.Parse("05/20/1999") });
            Add(new SecondConcerteBuilder(), new object[5] { "Olivia", 170.5f, 55f, Gender.Female, DateTime.Parse("05/20/1995") });
        }
    }
}