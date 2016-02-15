using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ElectionsQuickSort
{
    [TestClass]
    public class ElectionsQuickSort
    {
        [TestMethod]
        public void TestMethod1()
        {
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
