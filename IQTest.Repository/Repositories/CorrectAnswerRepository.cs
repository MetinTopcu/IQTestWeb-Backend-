using IQTest.Core.Models;
using IQTest.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQTest.Repository.Repositories
{
    public class CorrectAnswerRepository : GenericRepository<CorrectAnswer>, ICorrectAnswerRepository
    {
        public CorrectAnswerRepository(AppDbContext context) : base(context)
        {
        }
    }
}
