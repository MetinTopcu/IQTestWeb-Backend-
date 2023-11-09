using IQTest.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQTest.Repository.Seeds
{
    internal class CorrectAnswerSeed : IEntityTypeConfiguration<CorrectAnswer> //AppDbContext'i kirletlememek için burada yapıyoruz
    {
        public void Configure(EntityTypeBuilder<CorrectAnswer> builder)
        {
            //seed data sırasında id leri kendimiz vereceğiz uygulamanın başka yerlerinde bu işlemi yapmıyoruz

            builder.HasData(new CorrectAnswer { Id = 1, CorrectAns = "19", QuestionId = 1 },
                new CorrectAnswer { Id = 2, CorrectAns = "5", QuestionId = 2 },
                new CorrectAnswer { Id = 3, CorrectAns = "2nd", QuestionId = 3 },
                new CorrectAnswer { Id = 4, CorrectAns = "Muffin", QuestionId = 4 },
                new CorrectAnswer { Id = 5, CorrectAns = "The match", QuestionId = 5 },
                new CorrectAnswer { Id = 6, CorrectAns = "Light", QuestionId = 6 },
                new CorrectAnswer { Id = 7, CorrectAns = "18", QuestionId = 7 },
                new CorrectAnswer { Id = 8, CorrectAns = "41", QuestionId = 8 },
                new CorrectAnswer { Id = 9, CorrectAns = "True", QuestionId = 9 },
                new CorrectAnswer { Id = 10, CorrectAns = "10", QuestionId = 10 },
                new CorrectAnswer { Id = 11, CorrectAns = "Cylinder", QuestionId = 11 },
                new CorrectAnswer { Id = 12, CorrectAns = "100", QuestionId = 12 },
                new CorrectAnswer { Id = 13, CorrectAns = "Animal", QuestionId = 13 },
                new CorrectAnswer { Id = 14, CorrectAns = "Think", QuestionId = 14 },
                new CorrectAnswer { Id = 15, CorrectAns = "25", QuestionId = 15 },
                new CorrectAnswer { Id = 16, CorrectAns = "Rectangle", QuestionId = 16 },
                new CorrectAnswer { Id = 17, CorrectAns = "Company", QuestionId = 17 },
                new CorrectAnswer { Id = 18, CorrectAns = "Careless", QuestionId = 18 },
                new CorrectAnswer { Id = 19, CorrectAns = "True", QuestionId = 19 },
                new CorrectAnswer { Id = 20, CorrectAns = "Nephew", QuestionId = 20 },
                new CorrectAnswer { Id = 21, CorrectAns = "Friday", QuestionId = 21 },
                new CorrectAnswer { Id = 22, CorrectAns = "Statue", QuestionId = 22 },
                new CorrectAnswer { Id = 23, CorrectAns = "12", QuestionId = 23 },
                new CorrectAnswer { Id = 24, CorrectAns = "Equilateral", QuestionId = 24 },
                new CorrectAnswer { Id = 25, CorrectAns = "False", QuestionId = 25 },
                new CorrectAnswer { Id = 26, CorrectAns = "100", QuestionId = 26 },
                new CorrectAnswer { Id = 27, CorrectAns = "Nowhere", QuestionId = 27 },
                new CorrectAnswer { Id = 28, CorrectAns = "A hole", QuestionId = 28 },
                new CorrectAnswer { Id = 29, CorrectAns = "36", QuestionId = 29 },
                new CorrectAnswer { Id = 30, CorrectAns = "The LA train", QuestionId = 30 },
                new CorrectAnswer { Id = 31, CorrectAns = "Forth", QuestionId = 31 },
                new CorrectAnswer { Id = 32, CorrectAns = "Glass", QuestionId = 32 },
                new CorrectAnswer { Id = 33, CorrectAns = "50", QuestionId = 33 },
                new CorrectAnswer { Id = 34, CorrectAns = "POTS", QuestionId = 34 },
                new CorrectAnswer { Id = 35, CorrectAns = "21", QuestionId = 35 },
                new CorrectAnswer { Id = 36, CorrectAns = "A coffin", QuestionId = 36 },
                new CorrectAnswer { Id = 37, CorrectAns = "1 hour", QuestionId = 37 },
                new CorrectAnswer { Id = 38, CorrectAns = "20", QuestionId = 38 },
                new CorrectAnswer { Id = 39, CorrectAns = "20 hours", QuestionId = 39 },
                new CorrectAnswer { Id = 40, CorrectAns = "None, it was Noah", QuestionId = 40 },
                new CorrectAnswer { Id = 41, CorrectAns = "7", QuestionId = 41 },
                new CorrectAnswer { Id = 42, CorrectAns = "Racecar", QuestionId = 42 },
                new CorrectAnswer { Id = 43, CorrectAns = "The letter K", QuestionId = 43 },
                new CorrectAnswer { Id = 44, CorrectAns = "5", QuestionId = 44 },
                new CorrectAnswer { Id = 45, CorrectAns = "8", QuestionId = 45 },
                new CorrectAnswer { Id = 46, CorrectAns = "Cannot determine", QuestionId = 46 },
                new CorrectAnswer { Id = 47, CorrectAns = "False", QuestionId = 47 },
                new CorrectAnswer { Id = 48, CorrectAns = "5", QuestionId = 48 },
                new CorrectAnswer { Id = 49, CorrectAns = "Audacious", QuestionId = 49 },
                new CorrectAnswer { Id = 50, CorrectAns = "True", QuestionId = 50 },
                new CorrectAnswer { Id = 51, CorrectAns = "S", QuestionId = 51 },
                new CorrectAnswer { Id = 52, CorrectAns = "Ocean", QuestionId = 52 },
                new CorrectAnswer { Id = 53, CorrectAns = "64", QuestionId = 53 },
                new CorrectAnswer { Id = 54, CorrectAns = "Country", QuestionId = 54 },
                new CorrectAnswer { Id = 55, CorrectAns = "24", QuestionId = 55 },
                new CorrectAnswer { Id = 56, CorrectAns = "Reliable", QuestionId = 56 },
                new CorrectAnswer { Id = 57, CorrectAns = "20", QuestionId = 57 },
                new CorrectAnswer { Id = 58, CorrectAns = "Elephant", QuestionId = 58 },
                new CorrectAnswer { Id = 59, CorrectAns = "E", QuestionId = 59 },
                new CorrectAnswer { Id = 60, CorrectAns = "25", QuestionId = 60 },
                new CorrectAnswer { Id = 61, CorrectAns = "Forward", QuestionId = 61 },
                new CorrectAnswer { Id = 62, CorrectAns = "Some Bats are Beasts", QuestionId = 62 },
                new CorrectAnswer { Id = 63, CorrectAns = "All of them", QuestionId = 63 },
                new CorrectAnswer { Id = 64, CorrectAns = "24 cents", QuestionId = 64 },
                new CorrectAnswer { Id = 65, CorrectAns = "467", QuestionId = 65 },
                new CorrectAnswer { Id = 66, CorrectAns = "Tom", QuestionId = 66 },
                new CorrectAnswer { Id = 67, CorrectAns = "Monday", QuestionId = 67 },
                new CorrectAnswer { Id = 68, CorrectAns = "-1", QuestionId = 68 },
                new CorrectAnswer { Id = 69, CorrectAns = "2", QuestionId = 69 },
                new CorrectAnswer { Id = 70, CorrectAns = "29", QuestionId = 70 },
                new CorrectAnswer { Id = 71, CorrectAns = "64", QuestionId = 71 },
                new CorrectAnswer { Id = 72, CorrectAns = "4", QuestionId = 72 },
                new CorrectAnswer { Id = 73, CorrectAns = "Octagon", QuestionId = 73 },
                new CorrectAnswer { Id = 74, CorrectAns = "Both are the same", QuestionId = 74 },
                new CorrectAnswer { Id = 75, CorrectAns = "NOON", QuestionId = 75 },
                new CorrectAnswer { Id = 76, CorrectAns = "Wet", QuestionId = 76 },
                new CorrectAnswer { Id = 77, CorrectAns = "25", QuestionId = 77 },
                new CorrectAnswer { Id = 78, CorrectAns = "Lettuce", QuestionId = 78 },
                new CorrectAnswer { Id = 79, CorrectAns = "A joke", QuestionId = 79 }
            );


        }
    }
}
