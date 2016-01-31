using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hanoi
{
    [TestClass]
    public class Hanoi
    {
        [TestMethod]
        public void HanoiTestFor1()
        {
            Assert.AreEqual("AC", Solution(1, 'A', 'B', 'C'));
        }

        [TestMethod]
        public void HanoiTestFor2()
        {
            Assert.AreEqual("AB AC BC", Solution(2, 'A', 'B', 'C'));
        }

        [TestMethod]
        public void HanoiTestFor3()
        {
            Assert.AreEqual("AC AB CB AC BA BC AC", Solution(3, 'A', 'B', 'C'));
        }

        public string Solution(int n, char source, char aux, char destination )
        {
            string result = string.Empty;
            if (n == 1)
            {
                return $"{source}{destination}";
            }
            result += Solution(n - 1, source, destination, aux);
            result += " " + Solution(1, source, aux, destination);
            result += " " + Solution(n - 1, aux, source, destination);
            return result;

        }
    }
}
