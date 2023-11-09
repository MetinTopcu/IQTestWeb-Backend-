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
    public class WrongAnswerService : Service<WrongAnswer>, IWrongAnswerService
    {
        private readonly IWrongAnswerRepository _repository;
        private readonly IMapper _mapper;

        public WrongAnswerService(IGenericRepository<WrongAnswer> repository, IUnitOfWork unitOfWork, IMapper mapper, IWrongAnswerRepository _repository1) : base(repository, unitOfWork)
        {
            _mapper = mapper;
            _repository = _repository1;
        }
    }
}
