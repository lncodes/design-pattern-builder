using Xunit;
using System;

namespace Lncodes.Tutorial.Builder.Test
{
    public sealed class InternetBuilderTheoryData : TheoryData<string, float, float, Gender, DateTime>
    {
        public InternetBuilderTheoryData()
        {
            Add("Smith", 175.25f, 70f, Gender.Male, DateTime.Parse("05/20/1999"));
            Add("Smith", 175.25f, 70f, Gender.Male, DateTime.Parse("05/20/1999"));
            Add("Smith", 175.25f, 70f, Gender.Male, DateTime.Parse("05/20/1999"));
        }
    }
}
