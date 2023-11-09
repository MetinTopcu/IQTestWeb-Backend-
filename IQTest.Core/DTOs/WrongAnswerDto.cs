using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQTest.Core.DTOs
{
    public class WrongAnswerDto
    {
        public int Id { get; set; }
        public string WrongAns { get; set; }
        public int QuestionId { get; set; }

    }
}
