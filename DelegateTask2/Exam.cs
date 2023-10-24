using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTask2
{
    internal class Exam
    {
        public string Subject { get; set; }
        public int ExamDuration { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Exam(string subject, double examDuration, DateTime startDate)
        {
            Subject = subject;
            ExamDuration = examDuration;
            StartDate = startDate;

            DateTime endDate = startDate.AddHours(examDuration);

            EndDate = endDate;
        }

        public override string ToString()
        {
            return $"Subject name: {Subject}, Exam Duration: {ExamDuration} hours, StartDate: {StartDate}, EndDate{EndDate}";
        }
        
    }
}
