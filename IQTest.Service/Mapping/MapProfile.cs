using AutoMapper;
using IQTest.Core.DTOs;
using IQTest.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQTest.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Question, QuestionDto>().ReverseMap(); //reversemap tersine de çevir kodudur.
            CreateMap<CorrectAnswer, CorrectAnswerDto>().ReverseMap();
            CreateMap<WrongAnswer, WrongAnswerDto>().ReverseMap();
            CreateMap<QuestionUpdateDto, Question>();
            CreateMap<Question, QuestionsWithCorrectWrongDto>();

        }
    }
}
