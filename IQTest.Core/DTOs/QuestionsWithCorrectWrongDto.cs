﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQTest.Core.DTOs
{
    public class QuestionsWithCorrectWrongDto:QuestionDto
    {
        public List<WrongAnswerDto> Wrong { get; set; }
    }
}
