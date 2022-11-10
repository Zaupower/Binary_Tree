using NUnit.Framework;
using ExamResultApp;
using System.Xml.Linq;

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
            ID = 1;
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
        public void CompareTo_SameNameAndDateAndGreaterID_UseID()
        {
            ID = 2;
            Date = new DateTime(2015, 12, 26);
            Name = "Marcelo";
            Exam = Exams.ENGLISH;
            Score = Score.A;
            Date = new DateTime(2015, 12, 26);
            ExamResult examResultLess = new ExamResult(ID, Name, Exam, Score, Date);

            Assert.Less(examResult.CompareTo(examResultLess), 0);
        }
    } 
}
