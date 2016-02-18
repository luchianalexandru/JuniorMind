using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Catalog
{
    [TestClass]
    public class Catalog
    {

        [TestMethod]
        public void TestsIfBuildingTheStringArrayForTwoStudentsWorks()
        {
            Subject maths = new Subject("Mathematics", new int[] { 10, 9 });
            Subject sports = new Subject("Sport", new int[] { 7, 5 });
            Subject[] subjects = { maths, sports };
            Student ion = new Student { name = "Ion", subjectAndGrades = subjects };

            Subject math = new Subject("Mathematics", new int[] { 7, 5 });
            Subject sport = new Subject("Sport", new int[] { 10, 9 });
            Subject[] subject = { math, sport };
            Student vasile = new Student { name = "Vasile", subjectAndGrades = subject };

            Student[] allClass = { ion, vasile };
            CollectionAssert.AreEqual(new string[] { "Ion", "Vasile" }, BuildsStudentArray(allClass));
        }

        [TestMethod]
        public void TestsIfBuildingTheStringArrayForFourStudentsWorks()
        {
            Subject math1 = new Subject("Mathematics", new int[] { 10, 9 });
            Subject sport1 = new Subject("Sport", new int[] { 7, 5 });
            Subject[] subjects1 = { math1, sport1 };
            Student ion = new Student { name = "Ion", subjectAndGrades = subjects1 };

            Subject math2 = new Subject("Mathematics", new int[] { 7, 5 });
            Subject sport2 = new Subject("Sport", new int[] { 10, 9 });
            Subject[] subjects2 = { math2, sport2 };
            Student vasile = new Student { name = "Vasile", subjectAndGrades = subjects2 };

            Subject math3 = new Subject("Mathematics", new int[] { 7, 5 });
            Subject sport3 = new Subject("Sport", new int[] { 10, 9 });
            Subject[] subjects3 = { math3, sport3 };
            Student petrica = new Student { name = "Petrica", subjectAndGrades = subjects3 };

            Student[] allClass = { ion, vasile, petrica };
            CollectionAssert.AreEqual(new string[] { "Ion", "Vasile", "Petrica" }, BuildsStudentArray(allClass));

        }

        [TestMethod]
        public void TestsTheSortingAlgorithmForAlphabeticalOrder()
        {
            Subject math1 = new Subject("Mathematics", new int[] { 10, 9 });
            Subject sport1 = new Subject("Sport", new int[] { 7, 5 });
            Subject[] subjects1 = { math1, sport1 };
            Student zorand = new Student { name = "Zorand", subjectAndGrades = subjects1 };

            Subject math2 = new Subject("Mathematics", new int[] { 7, 5 });
            Subject sport2 = new Subject("Sport", new int[] { 10, 9 });
            Subject[] subjects2 = { math2, sport2 };
            Student alex = new Student { name = "Alex", subjectAndGrades = subjects2 };

            Subject math3 = new Subject("Mathematics", new int[] { 7, 5 });
            Subject sport3 = new Subject("Sport", new int[] { 10, 9 });
            Subject[] subjects3 = { math3, sport3 };
            Student petrica = new Student { name = "Petrica", subjectAndGrades = subjects3 };

            Student[] allClass = { zorand, alex, petrica };
            QuickSort(ref allClass, 0, 2);
            CollectionAssert.AreEqual(new string[] { "Alex", "Petrica", "Zorand" }, BuildsStudentArray(allClass));

        }

        public static void QuickSort(ref Student[] theClass, int left, int right)
        {
            if (left < right)
            {
                int q = Partition(ref theClass, left, right);
                QuickSort(ref theClass, left, q - 1);
                QuickSort(ref theClass, q + 1, right);
            }
        }

        static int Partition(ref Student[] theClass, int left, int right)
        {
            Student pivot = theClass[right];
            int i = left;

            for (int j = left; j < right; j++)
            {
                if (theClass[j].name.CompareTo(pivot.name) < 0)
                    Swap(ref theClass[j], ref theClass[i++]);
            }
            theClass[right] = theClass[i];
            theClass[i] = pivot;
            return i;
        }

        static void Swap(ref Student a, ref Student b)
        {
            Student temp = a;
            a = b;
            b = temp;
        }

        private static string[] BuildsStudentArray(Student[] fullClass)
        {
            string[] studentsNames = new string[fullClass.Length];
            for (int i = 0; i < fullClass.Length; i++)
            {
                studentsNames[i] = fullClass[i].name;
            }
            return studentsNames;
        }

        public struct Student
        {
            public string name;
            public Subject[] subjectAndGrades;
        }

        public struct Subject
        {
            public string name;
            public int[] grade;
            public Subject(string name, int[] grade)
            {
                this.name = name;
                this.grade = grade;
            }
        }

    }
}
