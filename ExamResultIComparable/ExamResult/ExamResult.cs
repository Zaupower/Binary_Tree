namespace ExamResultApp
{
    public class ExamResult : IComparable<ExamResult>
    {
        public int ID;
        public string Name;
        public Exams Exam;
        public Score Score;
        public DateTime Date;

        public ExamResult(int ID, string Name, Exams Exam, Score Score, DateTime Date)
        {
            this.ID = ID;
            this.Name = Name;
            this.Exam = Exam;
            this.Score = Score;
            this.Date = Date;
        }
        public int CompareTo(ExamResult other)
        {
            int resName = this.Name.CompareTo(other.Name);
            if(resName == 0)
            {
                int resDate = this.Date.CompareTo(other.Date);
                if (resDate == 0)
                {
                    int resID = this.ID.CompareTo(other.ID);
                    return resID;
                }
                return resDate;
            }
            return resName;
        }

        public override string ToString()
        {
            return "Name: "+ this.Name + ", Date: " + Date + ", ID: " + ID;
        }
    }
}
