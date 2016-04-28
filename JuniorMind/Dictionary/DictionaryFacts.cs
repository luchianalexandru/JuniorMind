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

        [Fact]
        public void ShouldBeTrueIfKeyContained()
        {
            Dictionary<string, int> d = new Dictionary<string, int> { { "cats", 12 }, { "dogs", 13 } };
            Assert.True(d.ContainsKey("dogs"));
            Assert.True(d.ContainsKey("cats"));
        }

        [Fact]
        public void ShouldNotBeTrueIfKeyIsntContained()
        {
            Dictionary<string, int> d = new Dictionary<string, int> { { "cats", 12 }, { "dogs", 13 } };

            Assert.False(d.ContainsKey("mice"));
        }

        [Fact]
        public void IsTrueIfRemovingAnItemWorks()
        {
            Dictionary<string, int> d = new Dictionary<string, int> { { "cats", 12 }, { "dogs", 13 } , { "mice", 15} };
            d.Remove("cats");
            Assert.False(d.ContainsKey("cats"));
            Assert.True(d.ContainsKey("dogs"));
            Assert.Equal(2, d.Count);
        }

        [Fact]
        public void AddWorksAfterRemove()
        {
            Dictionary<string, int> d = new Dictionary<string, int> { { "cats", 12 }, { "dogs", 13 }, { "mice", 15 } };
            d.Remove("cats");
            d.Add("bunnies", 19);
            Assert.False(d.ContainsKey("cats"));
            Assert.True(d.ContainsKey("dogs"));
            Assert.True(d.ContainsKey("bunnies"));
            Assert.Equal(3, d.Count);
        }

        [Fact]
        public void RemovingWorksIfConflictSituationsArise()
        {
            Dictionary<string, int> d = new Dictionary<string, int> { { "cats", 1 }, { "dogs", 1 }, { "mice", 1 } };
            d.Remove("cats");
            Assert.False(d.ContainsKey("cats"));
            Assert.True(d.ContainsKey("dogs"));
            Assert.Equal(2, d.Count);
        }
    }
}
