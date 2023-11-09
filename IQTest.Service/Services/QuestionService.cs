using AutoMapper;
using IQTest.Core.DTOs;
using IQTest.Core.Models;
using IQTest.Core.Repositories;
using IQTest.Core.Services;
using IQTest.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQTest.Service.Services
{
    public class QuestionService : Service<Question>, IQuestionService
    {
        private readonly IQuestionRepository _questionRepository;
        private readonly IMapper _mapper;

        public QuestionService(IGenericRepository<Question> repository, IUnitOfWork unitOfWork, IMapper mapper, IQuestionRepository questionRepository) : base(repository, unitOfWork)
        {
            _mapper = mapper;
            _questionRepository = questionRepository;
        }

        public async Task<CustomResponseDto<QuestionsWithCorrectWrongDto>> GetQuestionsWithCorrectWrong(int questionId)
        {
            var questions = _questionRepository.GetQuestionsWithCorrectWrong(questionId);

            var questionDto = _mapper.Map<QuestionsWithCorrectWrongDto>(questions);

            return CustomResponseDto<QuestionsWithCorrectWrongDto>.Success(200,questionDto);
        }
    }
}
