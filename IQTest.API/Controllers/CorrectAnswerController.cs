using AutoMapper;
using IQTest.Core.DTOs;
using IQTest.Core.Models;
using IQTest.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IQTest.API.Controllers
{
    [Authorize]
    public class CorrectAnswerController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly ICorrectAnswerService _service;

        public CorrectAnswerController(ICorrectAnswerService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var correctAnswers = await _service.GetAllAsync();

            var correctAnswersDto = _mapper.Map<List<CorrectAnswerDto>>(correctAnswers.ToList());

            return CreateActionresult(CustomResponseDto<List<CorrectAnswerDto>>.Success(200, correctAnswersDto));
        }

        //id belirtiyoruz ki api/correctanswers/5  5 id li veriyi getirir.
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var correctAnswers = await _service.GetByIdAsync(id);

            var correctAnswersDto = _mapper.Map<CorrectAnswerDto>(correctAnswers);

            return CreateActionresult(CustomResponseDto<CorrectAnswerDto>.Success(200, correctAnswersDto));
        }

        [HttpPost]
        public async Task<IActionResult> Save(CorrectAnswerDto correctAnswersDto)
        {
            var correctAnswers = await _service.AddAsync(_mapper.Map<CorrectAnswer>(correctAnswersDto));

            var correctAnswersDtos = _mapper.Map<CorrectAnswerDto>(correctAnswers);

            return CreateActionresult(CustomResponseDto<CorrectAnswerDto>.Success(201, correctAnswersDtos));
        }

        [HttpPut]
        public async Task<IActionResult> Update(CorrectAnswerDto correctanswerDto)
        {
            await _service.UpdateAsync(_mapper.Map<CorrectAnswer>(correctanswerDto));

            return CreateActionresult(CustomResponseDto<NoContentDto>.Success(204));
        }


        [HttpDelete("{id}")]  //id belirtiyoruz ki api/correctanswers/5  5 id li veriyi siler.
        public async Task<IActionResult> Remove(int id)
        {
            var correctAnswer = await _service.GetByIdAsync(id);

            await _service.RemoveAsync(correctAnswer);

            return CreateActionresult(CustomResponseDto<NoContentDto>.Success(204));
        }

    }
}
