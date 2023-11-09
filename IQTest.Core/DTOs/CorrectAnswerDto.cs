using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQTest.Core.DTOs
{
    public class CorrectAnswerDto
    {
        public int Id { get; set; }
        public string CorrectAns { get; set; }
        public int QuestionId { get; set; }

    }
}
