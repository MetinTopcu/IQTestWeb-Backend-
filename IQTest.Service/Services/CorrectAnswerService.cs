using AutoMapper;
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
    public class CorrectAnswerService : Service<CorrectAnswer>, ICorrectAnswerService
    {
        private readonly ICorrectAnswerRepository _repository;

        private readonly IMapper _mapper;

        public CorrectAnswerService(IGenericRepository<CorrectAnswer> repository, IUnitOfWork unitOfWork, IMapper mapper, ICorrectAnswerRepository _repository1) : base(repository, unitOfWork)
        {
            _mapper = mapper;
            _repository = _repository1;
        }
    }
}
