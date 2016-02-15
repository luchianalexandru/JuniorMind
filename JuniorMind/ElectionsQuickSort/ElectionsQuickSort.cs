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

        [TestMethod]
        public void TestsIfTheVotesAreCentralizedForTwoOfficesAndTwoPoliticians()
        {
            Politician[] office1 = { new Politician("zagrean", 10), new Politician("tamas", 5) };
            Politician[] office2 = { new Politician("zagrean", 5), new Politician("tamas", 6) };
            Politician[] office3 = { new Politician("zagrean", 20), new Politician("tamas", 3) };
            VotesPerOffice[] allResults =
            {
               new VotesPerOffice(office1),
               new VotesPerOffice(office2),
               new VotesPerOffice(office3)
            };

            Politician[] expected = { new Politician("zagrean", 35), new Politician("tamas", 14) };
            CollectionAssert.AreEqual(expected, GetTotalOfVotes(allResults));
        }

        [TestMethod]
        public void TestsIfTheVotesAreCentralizedForThreeOfficesAndThreePoliticians()
        {
            Politician[] office1 = { new Politician("zagrean", 10), new Politician("tamas", 5), new Politician("baciu", 7) };
            Politician[] office2 = { new Politician("zagrean", 5), new Politician("tamas", 6), new Politician("baciu", 9) };
            Politician[] office3 = { new Politician("zagrean", 20), new Politician("tamas", 3), new Politician("baciu", 12) };
            VotesPerOffice[] allResults =
            {
               new VotesPerOffice(office1),
               new VotesPerOffice(office2),
               new VotesPerOffice(office3)
            };

            Politician[] expected = { new Politician("zagrean", 35), new Politician("tamas", 14), new Politician("baciu", 28) };
            CollectionAssert.AreEqual(expected, GetTotalOfVotes(allResults));
        }

        private static Politician[] CentralizeVotes(VotesPerOffice[] results)
        {
            Politician[] total = new Politician[results[0].office.Length];
            for (int i = 0; i < total.Length; i++)
            {
                total[i].name = results[0].office[i].name;
                total[i].votes = 0;
            }
            return total;
        }

        public Politician[] GetTotalOfVotes(VotesPerOffice[] results)
        {
            Politician[] totalVotes = CentralizeVotes(results);
            for (int i = 0; i < results.Length; i++)
            {
                for (int j = 0; j < totalVotes.Length; j++) 
                {
                    totalVotes[j].votes += results[i].office[j].votes;
                }
            }
            return totalVotes;
        }

        [TestMethod]
        public void TestsTheQuickSortFor3Candidates()
        {
            Politician[] office = { new Politician("zagrean", 10), new Politician("tamas", 5), new Politician("baciu", 7) };
            Politician[] expected = { new Politician("zagrean", 10), new Politician("baciu", 7), new Politician("tamas", 5) };
            QuickSort(office, 0, 2);
            CollectionAssert.AreEqual(expected, office);
        }

        [TestMethod]
        public void TestsTheHybridSortFor4Candidates()
        {
            Politician[] office = { new Politician("zagrean", 10), new Politician("tamas", 5), new Politician("baciu", 7), new Politician("heghedus", 25) };
            Politician[] expected = { new Politician("heghedus", 25), new Politician("zagrean", 10), new Politician("baciu", 7), new Politician("tamas", 5) };
            HybridSort(ref office);
            CollectionAssert.AreEqual(expected, office);
        }

        public void HybridSort(ref Politician[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = input.Length - 1; j > i; j--)
                {
                    if (input[i].votes < input[j].votes)
                    {
                        Swap(ref input[i], ref input[j]);
                    }
                }
            }
        }

        public static void QuickSort(Politician[] input, int left, int right)
        {
            if (left < right)
            {
                int q = Partition(input, left, right);
                QuickSort(input, left, q - 1);
                QuickSort(input, q + 1, right);
            }
        }

        static int Partition(Politician[] input, int left, int right)
        {
            Politician pivot = input[right];
            int i = left;

            for (int j = left; j < right; j++)
            {
                if (input[j].votes < pivot.votes)
                {
                    Swap(ref input[j], ref input[i]);
                    i++;
                }
            }
            input[right] = input[i];
            input[i] = pivot;
            return i;
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
