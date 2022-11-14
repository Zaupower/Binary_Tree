using NUnit.Framework;
using ExamResultAp;
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

        [Test, Combinatorial]
        public void CompareTo_SameNameSameDateDifferentID_UseID(
            [Values(1,2,3)]int id,
            [Values(2014, 2015, 2016)] int year)
        {
            ID = id;
            Date = new DateTime(year,12, 26);
            Name = "Marcelo";
            Exam = Exams.ENGLISH;
            Score = Score.A;
            ExamResult examResultLess = new ExamResult(ID, Name, Exam, Score, Date);
            int compareResult = examResult.CompareTo(examResultLess);
            Assert.AreEqual(compareResult, getNextExpected());
        }
        private int counter = -1;
        private int getNextExpected()
        {
            counter++;
            int[] expected = {1,1,-1,1,0,-1,1,-1,-1,0 };
            return expected[counter];
        }
    } 
}
