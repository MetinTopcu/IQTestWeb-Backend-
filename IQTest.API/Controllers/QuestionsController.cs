using AutoMapper;
using IQTest.Core.DTOs;
using IQTest.Core.Models;
using IQTest.Core.Services;
using IQTest.Service.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IQTest.API.Controllers
{
    [Authorize(Roles ="admin,user")]
    public class QuestionsController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IQuestionService _service;

        public QuestionsController(IMapper mapper, IQuestionService questionService)
        {
            _service = questionService;
            _mapper = mapper;
        }

        [HttpGet("[action]/{questionId}")] // action, GetQuestionsWithCorrectWrong direk metodun ismini almasını sağlıyor api/questions/GetQuestionsWithCorrectWrong/
        public async Task<IActionResult> GetQuestionsWithCorrectWrong(int questionId) {

            return CreateActionresult(await _service.GetQuestionsWithCorrectWrong(questionId));
        }


        [HttpGet]
        public async Task<IActionResult> All()
        {
            var questions = await _service.GetAllAsync();

            var questionsDtos = _mapper.Map<List<QuestionDto>>(questions.ToList());

            return CreateActionresult(CustomResponseDto<List<QuestionDto>>.Success(200, questionsDtos));
        }

        //id belirtiyoruz ki api/questions/5  5 id li veriyi getirir.
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var questions = await _service.GetByIdAsync(id);

            var questionsDtos = _mapper.Map<QuestionDto>(questions);

            return CreateActionresult(CustomResponseDto<QuestionDto>.Success(200, questionsDtos));
        }

        [HttpPost]
        public async Task<IActionResult> Save(QuestionDto questionDto)
        {
            var questions = await _service.AddAsync(_mapper.Map<Question>(questionDto));

            var questionsDtos = _mapper.Map<QuestionDto>(questions);

            return CreateActionresult(CustomResponseDto<QuestionDto>.Success(201, questionsDtos));
        }

        [HttpPut]
        public async Task<IActionResult> Update(QuestionUpdateDto questionDto)
        {
            await _service.UpdateAsync(_mapper.Map<Question>(questionDto));

            return CreateActionresult(CustomResponseDto<NoContentDto>.Success(204));
        }


        [HttpDelete("{id}")]  //id belirtiyoruz ki api/questions/5  5 id li veriyi siler.
        public async Task<IActionResult> Remove(int id)
        {
            var question = await _service.GetByIdAsync(id);

            await _service.RemoveAsync(question);

            return CreateActionresult(CustomResponseDto<NoContentDto>.Success(204));
        }
    }
}
