
namespace ExamResultApp;
internal class Program
{
    private static void Main(string[] args)
    {
        
        DateTime date1 = new DateTime(2015, 12, 26);
        DateTime date2 = new DateTime(2015, 12, 27);
        DateTime date3 = new DateTime(2015, 12, 28);
        DateTime date4 = new DateTime(2015, 12, 29);
        DateTime date5 = new DateTime(2015, 12, 30);

        ExamResult examResult1 = new ExamResult(1, "Marcelo", Exams.ENGLISH, Score.A, date1);
        ExamResult examResult2 = new ExamResult(1, "Antonio", Exams.PHYSICS, Score.B, date2);
        ExamResult examResult3 = new ExamResult(3, "Soares", Exams.ENGLISH, Score.A, date3);
        ExamResult examResult4 = new ExamResult(2, "Marcelo", Exams.ENGLISH, Score.A, date1);
        ExamResult examResult5 = new ExamResult(1, "Marcelo", Exams.ENGLISH, Score.A, date1);

        var examResults = new[] { examResult1,examResult2,examResult3,examResult4, examResult5};

        var sorted = examResults.OrderBy(i => i);

        foreach (var examResult in sorted)
        {
            Console.WriteLine(examResult.Name + ", " + examResult.Date + ", " + examResult.ID);
        }
    }
}