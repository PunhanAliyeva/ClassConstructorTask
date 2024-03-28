using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassConstructorTask
{
    public class Exam
    {
        public string ExamName;
        public int Score;

        public Exam(string examName, int score)
        {
            ExamName = examName;
            Score = score;
        }
    }
}
