using AutoMapper;
using IQTest.API.Controllers;
using IQTest.Core.DTOs;
using IQTest.Core.Models;
using IQTest.Core.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class WrongAnswerControllerTest
    {
        private readonly Mock<IWrongAnswerService> _mockService;
        private readonly WrongAnswerController _controller;
        private readonly IMapper _mapper;

        private List<WrongAnswer> wronganswers;

        public WrongAnswerControllerTest(IMapper mapper)
        {
            _mapper = mapper;
            _mockService = new Mock<IWrongAnswerService>();
            _controller = new WrongAnswerController(_mockService.Object,_mapper);

            wronganswers = new List<WrongAnswer>{{ new WrongAnswer { Id=1, QuestionId=1, WrongAns="wrongans1"} },
                { new WrongAnswer { Id=2, QuestionId=2, WrongAns="wrongans2"} },
                { new WrongAnswer { Id=3, QuestionId=3, WrongAns="wrongans3"} },
                { new WrongAnswer { Id=4, QuestionId=4, WrongAns="wrongans4"} },
                { new WrongAnswer { Id=5, QuestionId=5, WrongAns="wrongans5"} },
                { new WrongAnswer { Id=6, QuestionId=6, WrongAns="wrongans6"} },
            };
        }

        [Fact]
        public async void All_ActionExecutes_ReturnOkReulstWithProduct()
        {
            var wrongans = _mockService.Setup(x => x.GetAllAsync()).ReturnsAsync(wronganswers);

            var wrongansdto = _mapper.Map<List<WrongAnswerDto>>(wrongans);

            var result = await _controller.All();

            var okResult = Assert.IsType<OkObjectResult>(result);

            var returnProducts = Assert.IsAssignableFrom<IEnumerable<WrongAnswer>>(okResult.Value);

            Assert.Equal<int>(6, returnProducts.ToList().Count);
        }
    }
}
