using System;
using Xunit;

namespace Dictionary
{
    public class DictionaryFacts
    {
        [Fact]
        public void ShouldReturnNullForEmptyDictionary()
        {
            var d = new Dictionary<int, string>();
            Assert.Equal(0, d.Count);
        }


        [Fact]
        public void ShouldReturnCounterDifferentThan0()
        {
            var d = new Dictionary<string, int>();
            d.Add("cats", 12);
            d.Add("dogs", 133);
            Assert.Equal(2, d.Count);
        }

        [Fact]
        public void ShouldReturnCounterNullForClear()
        {
            var d = new Dictionary<string, int>();
            d.Add("cats", 12);
            d.Add("dogs", 133);
            d.Clear();
            Assert.Equal(0, d.Count);
        }
    }
}
