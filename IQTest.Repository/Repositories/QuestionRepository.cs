using IQTest.Core.Models;
using IQTest.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQTest.Repository.Repositories
{
    public class QuestionRepository : GenericRepository<Question>, IQuestionRepository
    {
        public QuestionRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Question> GetQuestionsWithCorrectWrong(int questionId)
        {
            return await _context.Questions.Include(x => x.WrongAnswer).Where(x => x.Id == questionId).SingleOrDefaultAsync();
        }
    }
}
