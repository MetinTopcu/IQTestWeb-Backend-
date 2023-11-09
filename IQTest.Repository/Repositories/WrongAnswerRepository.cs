using IQTest.Core.Models;
using IQTest.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQTest.Repository.Repositories
{
    public class WrongAnswerRepository : GenericRepository<WrongAnswer>, IWrongAnswerRepository
    {
        public WrongAnswerRepository(AppDbContext context) : base(context)
        {
        }
    }
}
