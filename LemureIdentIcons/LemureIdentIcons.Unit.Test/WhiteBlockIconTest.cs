using System;
using Xunit;

namespace LemureIdentIcons.Unit.Test
{
    public class WhiteBlockIconTest
    {
        [Fact]
        public void GenerateIcon()
        {
            var bitmap = new LemureIdentIcon().CreateIcon("Test lemure", IdentIconType.WhiteBlockIcon);
            Assert.NotNull(bitmap);
        }
    }
}
