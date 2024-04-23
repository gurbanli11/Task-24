using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionTask.Models
{
    public class Exam
    {
        public string Subject { get; set; }
        public int ExamDuration { get; set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }

        public void Start()
        {
            StartDate = DateTime.Now;
            EndDate = StartDate.AddHours(ExamDuration);
        }
    }
}
