using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ElectionsQuickSort
{
    [TestClass]
    public class ElectionsQuickSort
    {
        [TestMethod]
        public void TestsSwap()
        {
            Politician[] office = { new Politician("zagrean", 10), new Politician("tamas", 5)};
            Politician[] expected = { new Politician("tamas", 5), new Politician("zagrean", 10)};
            Swap(ref office[0], ref office[1]);
            CollectionAssert.AreEqual(expected, office);
        }


        static void Swap(ref Politician a, ref Politician b)
        {
            Politician temp = a;
            a = b;
            b = temp;
        }

        public struct VotesPerOffice
        {
            public Politician[] office;
            public VotesPerOffice(Politician[] office)
            {
                this.office = office;
            }
        }
        public struct Politician
        {
            public string name;
            public int votes;
            public Politician(string name, int votes)
            {
                this.name = name;
                this.votes = votes;
            }
        }
    }
}
