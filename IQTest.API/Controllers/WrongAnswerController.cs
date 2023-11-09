using AutoMapper;
using IQTest.Core.DTOs;
using IQTest.Core.Models;
using IQTest.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IQTest.API.Controllers
{
    public class WrongAnswerController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IWrongAnswerService _service;

        public WrongAnswerController(IWrongAnswerService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]   
        public async Task<IActionResult> All()
        {
            var wrongans = await _service.GetAllAsync();
            var wrongansdto = _mapper.Map<List<WrongAnswerDto>>(wrongans.ToList());

            return CreateActionresult(CustomResponseDto<List<WrongAnswerDto>>.Success(200, wrongansdto));

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var wrongans = await _service.GetByIdAsync(id);
            var wrongansdto = _mapper.Map<List<WrongAnswerDto>>(wrongans);

            return CreateActionresult(CustomResponseDto<List<WrongAnswerDto>>.Success(200, wrongansdto));

        }


        [HttpPost]
        public async Task<IActionResult> Save(WrongAnswerDto wrongansDto)
        {
            var questions = await _service.AddAsync(_mapper.Map<WrongAnswer>(wrongansDto));

            var wrongansDtos = _mapper.Map<WrongAnswerDto>(questions);

            return CreateActionresult(CustomResponseDto<WrongAnswerDto>.Success(201, wrongansDtos));
        }

        [HttpPut]
        public async Task<IActionResult> Update(WrongAnswerDto wrongansDto)
        {
            await _service.UpdateAsync(_mapper.Map<WrongAnswer>(wrongansDto));

            return CreateActionresult(CustomResponseDto<NoContentDto>.Success(204));
        }


        [HttpDelete("{id}")]  //id belirtiyoruz ki api/wrongans/5  5 id li veriyi siler.
        public async Task<IActionResult> Remove(int id)
        {
            var wrongans = await _service.GetByIdAsync(id);

            await _service.RemoveAsync(wrongans);

            return CreateActionresult(CustomResponseDto<NoContentDto>.Success(204));
        }
    }
}
