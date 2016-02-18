using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Catalog
{
    [TestClass]
    public class Catalog
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        public struct Student
        {
            public string name;
            public Subject[] mattersAndNotes;
        }

        public struct Subject
        {
            public string name;
            public int[] grade;
            public Subject(string name, int[] grade)
            {
                this.name = materName;
                this.grade = notes;
            }
        }

    }
}
