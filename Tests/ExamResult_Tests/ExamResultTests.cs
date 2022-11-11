using NUnit.Framework;
using ExamResultApp;
using System.Xml.Linq;
using NUnit.Framework.Internal;

namespace ExamResultAppTests
{
    [TestFixture]
    public class ExamResultTests
    {
        public int ID;
        public string Name;
        public Exams Exam;
        public Score Score;
        public DateTime Date;

        public ExamResult examResult;
        
        public ExamResult examResultGreater;

        [SetUp]
        public void SetUp()
        {
            ID = 2;
            Date = new DateTime(2015, 12, 26);
            Name = "Marcelo";
            Exam = Exams.ENGLISH;
            Score = Score.A;
            Date = new DateTime(2015, 12, 26);
            examResult = new ExamResult(ID, Name, Exam, Score, Date);
            
            //Date = new DateTime(2015, 12, 26);
            //Name = "Marcelo";
            //Exam = Exams.ENGLISH;
            //Score = Score.A;
            //Date = new DateTime(2015, 12, 26);
            //examResultGreater = new ExamResult(ID, Name, Exam, Score, Date);
        }

        [TearDown]
        public void Postcondition()
        {
            Date = new DateTime(2015, 12, 26);
            Name = "Marcelo";
            Exam = Exams.ENGLISH;
            Score = Score.A;
            Date = new DateTime(2015, 12, 26);

            examResult = new ExamResult(ID, Name, Exam, Score, Date);

        }

        [Test]
        public void ExamResult_Properties_Equal()
        {
            Assert.AreEqual(examResult.ID, ID);
            Assert.AreEqual(examResult.Name, Name);
            Assert.AreEqual(examResult.Exam, Exam);
            Assert.AreEqual(examResult.Score, Score);
            Assert.AreEqual(examResult.Date, Date);
        }

        [Test]
        [TestCase(1, 2015,12,26, "Marcelo", Exams.ENGLISH, Score.A, 1)]
        [TestCase(2, 2015, 12, 26, "Marcelo", Exams.ENGLISH, Score.A, 0)]
        [TestCase(3, 2015, 12, 26, "Marcelo", Exams.ENGLISH, Score.A, -1)]
        public void CompareTo_SameNameSameDateGreaterID_UseID(
            int id, int year,int month, int day,
            string name, Exams exam,Score score,int expected)
        {
            ID = id;
            Date = new DateTime(year,month, day);
            Name = name;
            Exam = exam;
            Score = score;
            ExamResult examResultLess = new ExamResult(ID, Name, Exam, Score, Date);
            int compareResult = examResult.CompareTo(examResultLess);
            Assert.AreEqual(compareResult, expected);
        }        
    } 
}
