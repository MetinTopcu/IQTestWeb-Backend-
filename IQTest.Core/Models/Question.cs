using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQTest.Core.Models
{
    public class Question : BaseEntity
    {

        public string Questions { get; set; }
        public CorrectAnswer CorrectAnswer { get; set; }

        public ICollection<WrongAnswer> WrongAnswer { get; set; }

    }
}
