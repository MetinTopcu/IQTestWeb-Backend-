using IQTest.Core.DTOs;
using IQTest.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQTest.Core.Services
{
    public interface IQuestionService : IService<Question>
    {
        public Task<CustomResponseDto<QuestionsWithCorrectWrongDto>> GetQuestionsWithCorrectWrong(int questionId);
    }
}
