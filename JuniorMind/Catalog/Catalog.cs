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
        public void TestsTheQuickSortingAlgorithmForAlphabeticalOrder()
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

        [TestMethod]
        public void TestsTheSelectionSortingAlgorithmForAlphabeticalOrder()
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
            SelectionSort(ref allClass);
            CollectionAssert.AreEqual(new string[] { "Alex", "Petrica", "Zorand" }, BuildsStudentArray(allClass));
        }

        [TestMethod]
        public void TestsTheGeneralAverageCalculationForOneStudent()
        {
            Subject math1 = new Subject("Mathematics", new int[] { 10, 9 });
            Subject sport1 = new Subject("Sport", new int[] { 7, 5 });
            Subject[] subjects1 = { math1, sport1 };
            Student zorand = new Student { name = "Zorand", subjectAndGrades = subjects1 };

            Student[] allClass = { zorand };

            Assert.AreEqual(7.75m, CalculateGeneralAveragePerStudent(zorand));
        }

        [TestMethod]
        public void TestsTheAverageCalculationPerStudentPerOneSubject()
        {
            Subject math1 = new Subject("Mathematics", new int[] { 10, 9 });
            Subject sport1 = new Subject("Sport", new int[] { 7, 5 });
            Subject[] subjects1 = { math1, sport1 };
            Student zorand = new Student { name = "Zorand", subjectAndGrades = subjects1 };

            Student[] allClass = { zorand};

            Assert.AreEqual(9.5m, CalculateAveragePerSubjectPerStudent(math1));
            //Assert.AreEqual(6, CalculateAveragePerSubjectPerStudent(sport1));
        }

        [TestMethod]
        public void TestsIfBuildingTheAverageArrayForTwoStudentsWorks()
        {
            Subject maths = new Subject("Mathematics", new int[] { 10, 9 });
            Subject sports = new Subject("Sport", new int[] { 7, 5 });
            Subject[] subjects = { maths, sports };
            Student ion = new Student { name = "Ion", subjectAndGrades = subjects };

            Subject math = new Subject("Mathematics", new int[] { 7, 5 });
            Subject sport = new Subject("Sport", new int[] { 10, 8 });
            Subject[] subject = { math, sport };
            Student vasile = new Student { name = "Vasile", subjectAndGrades = subject };

            Student[] allClass = { ion, vasile };
            Average[] averageArray = BuildAverageArray(allClass);

            Average[] expected = { new Average("Ion", 7.75m), new Average("Vasile", 7.5m) };

            CollectionAssert.AreEqual(expected, averageArray);
        }

        [TestMethod]
        public void TestsTheSortForTheAverageStructArray()
        {
            Subject math1 = new Subject("Mathematics", new int[] { 5, 5 });
            Subject sport1 = new Subject("Sport", new int[] { 10, 4 });
            Subject[] subject1 = { math1, sport1 };
            Student gheorghe = new Student { name = "Gheorghe", subjectAndGrades = subject1 };

            Subject math2 = new Subject("Mathematics", new int[] { 10, 9 });
            Subject sport2 = new Subject("Sport", new int[] { 7, 5 });
            Subject[] subject2 = { math2, sport2 };
            Student ion = new Student { name = "Ion", subjectAndGrades = subject2 };

            Subject math3 = new Subject("Mathematics", new int[] { 7, 5 });
            Subject sport3 = new Subject("Sport", new int[] { 10, 8 });
            Subject[] subject3 = { math3, sport3 };
            Student vasile = new Student { name = "Vasile", subjectAndGrades = subject3 };
        

            Student[] allClass = { gheorghe, ion, vasile };
            Average[] averageArray = SelectionSortForGeneralAverage(ref allClass);

            Average[] expected = { new Average("Ion", 7.75m), new Average("Vasile", 7.5m), new Average("Gheorghe", 6) };
            CollectionAssert.AreEqual(expected, averageArray);
        }

        public Average[] SelectionSortForGeneralAverage(ref Student[] fullClass)
        {
            Average[] allClassWithAverage = BuildAverageArray(fullClass);
            for (int i = 0; i < allClassWithAverage.Length - 1; i++)
                for (int j = i + 1; j < allClassWithAverage.Length; j++)
                    if (allClassWithAverage[j].average > allClassWithAverage[i].average)
                        SwapForAverage(ref allClassWithAverage[i], ref allClassWithAverage[j]);
            return allClassWithAverage;
        }

        public Average[] BuildAverageArray(Student[] fullClass)
        {
            Average[] students = new Average[fullClass.Length];    
            for (int i = 0; i < fullClass.Length; i++)
            {
                students[i].name = fullClass[i].name;
                students[i].average = CalculateGeneralAveragePerStudent(fullClass[i]);
            }
            return students;
        }

        static void SwapForAverage(ref Average a, ref Average b)
        {
            Average temp = a;
            a = b;
            b = temp;
        }

        public decimal CalculateGeneralAveragePerStudent(Student student)
        {
            decimal sum = 0;
            for (int i = 0; i < student.subjectAndGrades.Length; i++)
                sum += CalculateAveragePerSubjectPerStudent(student.subjectAndGrades[i]);
            return sum / student.subjectAndGrades.Length;
        }
        
        public decimal CalculateAveragePerSubjectPerStudent(Subject subject)
        {
            int sum = 0;
            for(int i = 0; i < subject.grade.Length; i++)
                sum += subject.grade[i];
            return (decimal)sum / subject.grade.Length;
        }

        public void SelectionSort(ref Student[] theClass)
        {
            for (int i = 0; i < theClass.Length - 1; i++)
                for (int j = i + 1; j < theClass.Length; j++)
                  if (theClass[j].name.CompareTo(theClass[i].name) < 0)
                        Swap(ref theClass[i], ref theClass[j]);
        }

        public void QuickSort(ref Student[] theClass, int left, int right)
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

        public string[] BuildsStudentArray(Student[] fullClass)
        {
            string[] studentsNames = new string[fullClass.Length];
            for (int i = 0; i < fullClass.Length; i++)
            {
                studentsNames[i] = fullClass[i].name;
            }
            return studentsNames;
        }

        public struct Average
        {
            public string name;
            public decimal average;
            public Average(string name, decimal average)
            {
                this.name = name;
                this.average = average;
            }
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
