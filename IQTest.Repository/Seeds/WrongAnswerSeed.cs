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
    internal class WrongAnswerSeed : IEntityTypeConfiguration<WrongAnswer>  //AppDbContext'i kirletlememek için burada yapıyoruz
    {
        public void Configure(EntityTypeBuilder<WrongAnswer> builder)
        {
            //seed data sırasında id leri kendimiz vereceğiz uygulamanın başka yerlerinde bu işlemi yapmıyoruz
            builder.HasData(new WrongAnswer { Id = 1, WrongAns = "15", QuestionId= 1 },
                new WrongAnswer { Id = 2, WrongAns = "21", QuestionId = 1 },
                new WrongAnswer { Id = 3, WrongAns = "17", QuestionId = 1 },
                new WrongAnswer { Id = 4, WrongAns = "Correct Answer Not Present", QuestionId = 1 },

                new WrongAnswer { Id = 5, WrongAns = "7", QuestionId = 2 },
                new WrongAnswer { Id = 6, WrongAns = "10", QuestionId = 2 },
                new WrongAnswer { Id = 7, WrongAns = "Correct Answer Not Present", QuestionId = 2 },

                new WrongAnswer { Id = 8, WrongAns = "1st", QuestionId = 3 },
                new WrongAnswer { Id = 9, WrongAns = "3rd", QuestionId = 3 },
                new WrongAnswer { Id = 10, WrongAns = "4th", QuestionId = 3 },
                new WrongAnswer { Id = 11, WrongAns = "Correct Answer Not Present", QuestionId = 3 },

                new WrongAnswer { Id = 12, WrongAns = "Apple", QuestionId = 4 },
                new WrongAnswer { Id = 13, WrongAns = "Orange", QuestionId = 4 },
                new WrongAnswer { Id = 14, WrongAns = "Cherry", QuestionId = 4 },
                new WrongAnswer { Id = 15, WrongAns = "Correct Answer Not Present", QuestionId = 4 },

                new WrongAnswer { Id = 16, WrongAns = "The newspaper", QuestionId = 5 },
                new WrongAnswer { Id = 17, WrongAns = "The oil lamp", QuestionId = 5 },
                new WrongAnswer { Id = 18, WrongAns = "The kindling", QuestionId = 5 },
                new WrongAnswer { Id = 19, WrongAns = "Correct Answer Not Present", QuestionId = 5 },

                new WrongAnswer { Id = 20, WrongAns = "Typhoon", QuestionId = 6 },
                new WrongAnswer { Id = 21, WrongAns = "Hurricane", QuestionId = 6 },
                new WrongAnswer { Id = 22, WrongAns = "Tornado", QuestionId = 6 },
                new WrongAnswer { Id = 23, WrongAns = "Correct Answer Not Present", QuestionId = 6 },

                new WrongAnswer { Id = 24, WrongAns = "17", QuestionId = 7 },
                new WrongAnswer { Id = 25, WrongAns = "19", QuestionId = 7 },
                new WrongAnswer { Id = 26, WrongAns = "20", QuestionId = 7 },
                new WrongAnswer { Id = 27, WrongAns = "Correct Answer Not Present", QuestionId = 7 },

                new WrongAnswer { Id = 28, WrongAns = "42", QuestionId = 8 },
                new WrongAnswer { Id = 29, WrongAns = "43", QuestionId = 8 },
                new WrongAnswer { Id = 30, WrongAns = "44", QuestionId = 8 },
                new WrongAnswer { Id = 31, WrongAns = "Correct Answer Not Present", QuestionId = 8 },

                new WrongAnswer { Id = 32, WrongAns = "False", QuestionId = 9 },
                new WrongAnswer { Id = 33, WrongAns = "Cannot be determined", QuestionId = 9 },
                new WrongAnswer { Id = 34, WrongAns = "None of the above", QuestionId = 9 },
                new WrongAnswer { Id = 35, WrongAns = "Correct Answer Not Present", QuestionId = 9 },

                new WrongAnswer { Id = 36, WrongAns = "11", QuestionId = 10 },
                new WrongAnswer { Id = 37, WrongAns = "12", QuestionId = 10 },
                new WrongAnswer { Id = 38, WrongAns = "13", QuestionId = 10 },
                new WrongAnswer { Id = 39, WrongAns = "Correct Answer Not Present", QuestionId = 10 },

                new WrongAnswer { Id = 40, WrongAns = "Circle", QuestionId = 11 },
                new WrongAnswer { Id = 41, WrongAns = "Square", QuestionId = 11 },
                new WrongAnswer { Id = 42, WrongAns = "Triangle", QuestionId = 11 },
                new WrongAnswer { Id = 43, WrongAns = "Correct Answer Not Present", QuestionId = 11 },

                new WrongAnswer { Id = 44, WrongAns = "225", QuestionId = 12 },
                new WrongAnswer { Id = 45, WrongAns = "250", QuestionId = 12 },
                new WrongAnswer { Id = 46, WrongAns = "300", QuestionId = 12 },
                new WrongAnswer { Id = 47, WrongAns = "Correct Answer Not Present", QuestionId = 12 },

                new WrongAnswer { Id = 48, WrongAns = "River", QuestionId = 13 },
                new WrongAnswer { Id = 49, WrongAns = "Country", QuestionId = 13 },
                new WrongAnswer { Id = 50, WrongAns = "State", QuestionId = 13 },
                new WrongAnswer { Id = 51, WrongAns = "Correct Answer Not Present", QuestionId = 13 },

                new WrongAnswer { Id = 52, WrongAns = "Touch", QuestionId = 14 },
                new WrongAnswer { Id = 53, WrongAns = "Taste", QuestionId = 14 },
                new WrongAnswer { Id = 54, WrongAns = "Hear", QuestionId = 14 },
                new WrongAnswer { Id = 55, WrongAns = "Correct Answer Not Present", QuestionId = 14 },

                new WrongAnswer { Id = 56, WrongAns = "26", QuestionId = 15 },
                new WrongAnswer { Id = 57, WrongAns = "24", QuestionId = 15 },
                new WrongAnswer { Id = 58, WrongAns = "23", QuestionId = 15 },
                new WrongAnswer { Id = 59, WrongAns = "Correct Answer Not Present", QuestionId = 15 },

                new WrongAnswer { Id = 60, WrongAns = "Hexagon", QuestionId = 16 },
                new WrongAnswer { Id = 61, WrongAns = "Triangle", QuestionId = 16 },
                new WrongAnswer { Id = 62, WrongAns = "Correct Answer Not Present", QuestionId = 16 },

                new WrongAnswer { Id = 63, WrongAns = "Country", QuestionId = 17 },
                new WrongAnswer { Id = 64, WrongAns = "State", QuestionId = 17 },
                new WrongAnswer { Id = 65, WrongAns = "City", QuestionId = 17 },
                new WrongAnswer { Id = 66, WrongAns = "Correct Answer Not Present", QuestionId = 17 },

                new WrongAnswer { Id = 67, WrongAns = "Prudent", QuestionId = 18 },
                new WrongAnswer { Id = 68, WrongAns = "Measured", QuestionId = 18 },
                new WrongAnswer { Id = 69, WrongAns = "Careful", QuestionId = 18 },
                new WrongAnswer { Id = 70, WrongAns = "Correct Answer Not Present", QuestionId = 18 },

                new WrongAnswer { Id = 71, WrongAns = "False", QuestionId = 19 },
                new WrongAnswer { Id = 72, WrongAns = "Correct Answer Not Present", QuestionId = 19 },

                new WrongAnswer { Id = 73, WrongAns = "Mother", QuestionId = 20 },
                new WrongAnswer { Id = 74, WrongAns = "Daughter", QuestionId = 20 },
                new WrongAnswer { Id = 75, WrongAns = "Aunt", QuestionId = 20 },
                new WrongAnswer { Id = 76, WrongAns = "Correct Answer Not Present", QuestionId = 20 },

                new WrongAnswer { Id = 77, WrongAns = "Wednesday", QuestionId = 21 },
                new WrongAnswer { Id = 78, WrongAns = "Thursday", QuestionId = 21 },
                new WrongAnswer { Id = 79, WrongAns = "Saturday", QuestionId = 21 },
                new WrongAnswer { Id = 80, WrongAns = "Correct Answer Not Present", QuestionId = 21 },

                new WrongAnswer { Id = 81, WrongAns = "Note", QuestionId = 22 },
                new WrongAnswer { Id = 82, WrongAns = "Novel", QuestionId = 22 },
                new WrongAnswer { Id = 83, WrongAns = "Business Card", QuestionId = 22 },
                new WrongAnswer { Id = 84, WrongAns = "Correct Answer Not Present", QuestionId = 22 },

                new WrongAnswer { Id = 85, WrongAns = "2", QuestionId = 23 },
                new WrongAnswer { Id = 86, WrongAns = "24", QuestionId = 23 },
                new WrongAnswer { Id = 87, WrongAns = "6 Card", QuestionId = 23 },
                new WrongAnswer { Id = 88, WrongAns = "Correct Answer Not Present", QuestionId = 23 },

                new WrongAnswer { Id = 89, WrongAns = "Acute", QuestionId = 24 },
                new WrongAnswer { Id = 90, WrongAns = "Obtuse", QuestionId = 24 },
                new WrongAnswer { Id = 91, WrongAns = "Correct Answer Not Present", QuestionId = 24 },

                new WrongAnswer { Id = 92, WrongAns = "True", QuestionId = 25 },
                new WrongAnswer { Id = 93, WrongAns = "Correct Answer Not Present", QuestionId = 25 },

                new WrongAnswer { Id = 94, WrongAns = "12351235", QuestionId = 26 },
                new WrongAnswer { Id = 95, WrongAns = "1700", QuestionId = 26 },
                new WrongAnswer { Id = 96, WrongAns = "83", QuestionId = 26 },
                new WrongAnswer { Id = 97, WrongAns = "Correct Answer Not Present", QuestionId = 26 },

                new WrongAnswer { Id = 98, WrongAns = "U.S.", QuestionId = 27 },
                new WrongAnswer { Id = 99, WrongAns = "Canada", QuestionId = 27 },
                new WrongAnswer { Id = 100, WrongAns = "Both", QuestionId = 27},
                new WrongAnswer { Id = 101, WrongAns = "Correct Answer Not Present", QuestionId = 27 },

                new WrongAnswer { Id = 102, WrongAns = "A mountain", QuestionId = 28 },
                new WrongAnswer { Id = 103, WrongAns = "A tree", QuestionId = 28 },
                new WrongAnswer { Id = 104, WrongAns = "A river", QuestionId = 28 },
                new WrongAnswer { Id = 105, WrongAns = "Correct Answer Not Present", QuestionId = 28 },

                new WrongAnswer { Id = 106, WrongAns = "30", QuestionId = 29 },
                new WrongAnswer { Id = 107, WrongAns = "40", QuestionId = 29 },
                new WrongAnswer { Id = 108, WrongAns = "45", QuestionId = 29 },
                new WrongAnswer { Id = 109, WrongAns = "Correct Answer Not Present", QuestionId = 29 },

                new WrongAnswer { Id = 110, WrongAns = "The NYC train", QuestionId = 30 },
                new WrongAnswer { Id = 111, WrongAns = "Neither", QuestionId = 30 },
                new WrongAnswer { Id = 112, WrongAns = "Both", QuestionId = 30 },
                new WrongAnswer { Id = 113, WrongAns = "Correct Answer Not Present", QuestionId = 30 },

                new WrongAnswer { Id = 114, WrongAns = "First", QuestionId = 31 },
                new WrongAnswer { Id = 115, WrongAns = "Third", QuestionId = 31 },
                new WrongAnswer { Id = 116, WrongAns = "Eighth", QuestionId = 31 },
                new WrongAnswer { Id = 117, WrongAns = "Correct Answer Not Present", QuestionId = 31 },

                new WrongAnswer { Id = 118, WrongAns = "Green Straw", QuestionId = 32 },
                new WrongAnswer { Id = 119, WrongAns = "Green wood", QuestionId = 32 },
                new WrongAnswer { Id = 120, WrongAns = "Green stone", QuestionId = 32 },
                new WrongAnswer { Id = 121, WrongAns = "Correct Answer Not Present", QuestionId = 32 },

                new WrongAnswer { Id = 122, WrongAns = "100", QuestionId = 33 },
                new WrongAnswer { Id = 123, WrongAns = "200", QuestionId = 33 },
                new WrongAnswer { Id = 124, WrongAns = "25", QuestionId = 33 },
                new WrongAnswer { Id = 125, WrongAns = "Correct Answer Not Present", QuestionId = 33 },

                new WrongAnswer { Id = 126, WrongAns = "SPOT", QuestionId = 34 },
                new WrongAnswer { Id = 127, WrongAns = "TOPS", QuestionId = 34 },
                new WrongAnswer { Id = 128, WrongAns = "POST", QuestionId = 34 },
                new WrongAnswer { Id = 129, WrongAns = "Correct Answer Not Present", QuestionId = 34 },

                new WrongAnswer { Id = 130, WrongAns = "3", QuestionId = 35 },
                new WrongAnswer { Id = 131, WrongAns = "14", QuestionId = 35 },
                new WrongAnswer { Id = 132, WrongAns = "17", QuestionId = 35 },
                new WrongAnswer { Id = 133, WrongAns = "Correct Answer Not Present", QuestionId = 35 },

                new WrongAnswer { Id = 134, WrongAns = "A toy", QuestionId = 36 },
                new WrongAnswer { Id = 135, WrongAns = "A car", QuestionId = 36 },
                new WrongAnswer { Id = 136, WrongAns = "A book", QuestionId = 36 },
                new WrongAnswer { Id = 137, WrongAns = "Correct Answer Not Present", QuestionId = 36 },

                new WrongAnswer { Id = 138, WrongAns = "3 hours", QuestionId = 37 },
                new WrongAnswer { Id = 139, WrongAns = "1,5 hours ", QuestionId = 37 },
                new WrongAnswer { Id = 140, WrongAns = "2 hours", QuestionId = 37 },
                new WrongAnswer { Id = 141, WrongAns = "Correct Answer Not Present", QuestionId = 37 },

                new WrongAnswer { Id = 142, WrongAns = "10", QuestionId = 38 },
                new WrongAnswer { Id = 143, WrongAns = "11", QuestionId = 38 },
                new WrongAnswer { Id = 144, WrongAns = "21", QuestionId = 38 },
                new WrongAnswer { Id = 145, WrongAns = "Correct Answer Not Present", QuestionId = 38 },

                new WrongAnswer { Id = 146, WrongAns = "5 hours", QuestionId = 39 },
                new WrongAnswer { Id = 147, WrongAns = "15 hours", QuestionId = 39 },
                new WrongAnswer { Id = 148, WrongAns = "25 hours", QuestionId = 39 },
                new WrongAnswer { Id = 149, WrongAns = "Correct Answer Not Present", QuestionId = 39 },

                new WrongAnswer { Id = 150, WrongAns = "1", QuestionId = 40 },
                new WrongAnswer { Id = 151, WrongAns = "2", QuestionId = 40 },
                new WrongAnswer { Id = 152, WrongAns = "7", QuestionId = 40 },
                new WrongAnswer { Id = 153, WrongAns = "Correct Answer Not Present", QuestionId = 40 },

                new WrongAnswer { Id = 154, WrongAns = "10", QuestionId = 41 },
                new WrongAnswer { Id = 155, WrongAns = "14", QuestionId = 41 },
                new WrongAnswer { Id = 156, WrongAns = "21", QuestionId = 41 },
                new WrongAnswer { Id = 157, WrongAns = "Correct Answer Not Present", QuestionId = 41 },

                new WrongAnswer { Id = 158, WrongAns = "Automobile", QuestionId = 42 },
                new WrongAnswer { Id = 159, WrongAns = "Java", QuestionId = 42 },
                new WrongAnswer { Id = 160, WrongAns = "Python", QuestionId = 42 },
                new WrongAnswer { Id = 161, WrongAns = "Correct Answer Not Present", QuestionId = 42 },

                new WrongAnswer { Id = 162, WrongAns = "Sushi", QuestionId = 43 },
                new WrongAnswer { Id = 163, WrongAns = "Skyscraper", QuestionId = 43 },
                new WrongAnswer { Id = 164, WrongAns = "The letter O", QuestionId = 43 },
                new WrongAnswer { Id = 165, WrongAns = "Correct Answer Not Present", QuestionId = 43 },

                new WrongAnswer { Id = 166, WrongAns = "10", QuestionId = 44 },
                new WrongAnswer { Id = 167, WrongAns = "20", QuestionId = 44 },
                new WrongAnswer { Id = 168, WrongAns = "2", QuestionId = 44 },
                new WrongAnswer { Id = 169, WrongAns = "Correct Answer Not Present", QuestionId = 44 },

                new WrongAnswer { Id = 170, WrongAns = "2", QuestionId = 45 },
                new WrongAnswer { Id = 171, WrongAns = "4", QuestionId = 45 },
                new WrongAnswer { Id = 172, WrongAns = "6", QuestionId = 45 },
                new WrongAnswer { Id = 173, WrongAns = "Correct Answer Not Present", QuestionId = 45 },

                new WrongAnswer { Id = 174, WrongAns = "Ray is taller than Peter.", QuestionId = 46 },
                new WrongAnswer { Id = 175, WrongAns = "Ray is shorter than Peter.", QuestionId = 46 },
                new WrongAnswer { Id = 176, WrongAns = "Peter is the same height as Ray.", QuestionId = 46 },

                new WrongAnswer { Id = 177, WrongAns = "True", QuestionId = 47 },
                new WrongAnswer { Id = 178, WrongAns = "Cannot be determined", QuestionId = 47 },
                new WrongAnswer { Id = 179, WrongAns = "None of the above", QuestionId = 47 },
                new WrongAnswer { Id = 180, WrongAns = "Correct Answer Not Present", QuestionId = 47 },

                new WrongAnswer { Id = 181, WrongAns = "4", QuestionId = 48 },
                new WrongAnswer { Id = 182, WrongAns = "6", QuestionId = 48 },
                new WrongAnswer { Id = 183, WrongAns = "7", QuestionId = 48 },
                new WrongAnswer { Id = 184, WrongAns = "Correct Answer Not Present", QuestionId = 48 },

                new WrongAnswer { Id = 185, WrongAns = "Responsible", QuestionId = 49 },
                new WrongAnswer { Id = 186, WrongAns = "Careful", QuestionId = 49 },
                new WrongAnswer { Id = 187, WrongAns = "Wary", QuestionId = 49 },
                new WrongAnswer { Id = 188, WrongAns = "Correct Answer Not Present", QuestionId = 49 },

                new WrongAnswer { Id = 189, WrongAns = "False", QuestionId = 50 },
                new WrongAnswer { Id = 190, WrongAns = "Cannot be determined", QuestionId = 57 },
                new WrongAnswer { Id = 191, WrongAns = "None of the above", QuestionId = 50 },
                new WrongAnswer { Id = 192, WrongAns = "Correct Answer Not Present", QuestionId = 50 },

                new WrongAnswer { Id = 193, WrongAns = "E", QuestionId = 51 },
                new WrongAnswer { Id = 194, WrongAns = "T", QuestionId = 51 },
                new WrongAnswer { Id = 195, WrongAns = "N", QuestionId = 51 },
                new WrongAnswer { Id = 196, WrongAns = "Correct Answer Not Present", QuestionId = 51 },

                new WrongAnswer { Id = 197, WrongAns = "City", QuestionId = 52 },
                new WrongAnswer { Id = 198, WrongAns = "Animal", QuestionId = 52 },
                new WrongAnswer { Id = 199, WrongAns = "Country", QuestionId = 52 },
                new WrongAnswer { Id = 200, WrongAns = "Correct Answer Not Present", QuestionId = 52 },

                new WrongAnswer { Id = 201, WrongAns = "36", QuestionId = 53 },
                new WrongAnswer { Id = 202, WrongAns = "49", QuestionId = 53 },
                new WrongAnswer { Id = 203, WrongAns = "100", QuestionId = 53 },
                new WrongAnswer { Id = 204, WrongAns = "Correct Answer Not Present", QuestionId = 53 },

                new WrongAnswer { Id = 205, WrongAns = "Animal", QuestionId = 54 },
                new WrongAnswer { Id = 206, WrongAns = "City", QuestionId = 54 },
                new WrongAnswer { Id = 207, WrongAns = "River", QuestionId = 54 },
                new WrongAnswer { Id = 208, WrongAns = "Correct Answer Not Present", QuestionId = 54 },

                new WrongAnswer { Id = 209, WrongAns = "20", QuestionId = 55 },
                new WrongAnswer { Id = 210, WrongAns = "28", QuestionId = 55 },
                new WrongAnswer { Id = 211, WrongAns = "32", QuestionId = 55 },
                new WrongAnswer { Id = 212, WrongAns = "Correct Answer Not Present", QuestionId = 55 },

                new WrongAnswer { Id = 213, WrongAns = "Resolute", QuestionId = 56 },
                new WrongAnswer { Id = 214, WrongAns = "Tenacity", QuestionId = 56 },
                new WrongAnswer { Id = 215, WrongAns = "Insolent", QuestionId = 56 },
                new WrongAnswer { Id = 216, WrongAns = "Correct Answer Not Present", QuestionId = 56 },

                new WrongAnswer { Id = 217, WrongAns = "19", QuestionId = 57 },
                new WrongAnswer { Id = 218, WrongAns = "21", QuestionId = 57 },
                new WrongAnswer { Id = 219, WrongAns = "22", QuestionId = 57 },
                new WrongAnswer { Id = 220, WrongAns = "Correct Answer Not Present", QuestionId = 57 },

                new WrongAnswer { Id = 221, WrongAns = "Leopard", QuestionId = 58 },
                new WrongAnswer { Id = 222, WrongAns = "Cougar", QuestionId = 58 },
                new WrongAnswer { Id = 223, WrongAns = "Lion", QuestionId = 58 },
                new WrongAnswer { Id = 224, WrongAns = "Correct Answer Not Present", QuestionId = 58 },

                new WrongAnswer { Id = 225, WrongAns = "N", QuestionId = 59 },
                new WrongAnswer { Id = 226, WrongAns = "T", QuestionId = 59 },
                new WrongAnswer { Id = 227, WrongAns = "H", QuestionId = 59 },
                new WrongAnswer { Id = 228, WrongAns = "Correct Answer Not Present", QuestionId = 59 },

                new WrongAnswer { Id = 229, WrongAns = "15", QuestionId = 60 },
                new WrongAnswer { Id = 230, WrongAns = "20", QuestionId = 60 },
                new WrongAnswer { Id = 231, WrongAns = "30", QuestionId = 60 },
                new WrongAnswer { Id = 232, WrongAns = "Correct Answer Not Present", QuestionId = 60 },

                new WrongAnswer { Id = 233, WrongAns = "Left", QuestionId = 61 },
                new WrongAnswer { Id = 234, WrongAns = "Right", QuestionId = 61 },
                new WrongAnswer { Id = 235, WrongAns = "Backward", QuestionId = 61 },
                new WrongAnswer { Id = 236, WrongAns = "Correct Answer Not Present", QuestionId = 61 },

                new WrongAnswer { Id = 237, WrongAns = "Some Birds are Bats", QuestionId = 62 },
                new WrongAnswer { Id = 238, WrongAns = "Some Beasts are Bats", QuestionId = 62 },
                new WrongAnswer { Id = 239, WrongAns = "Some Blooms are Bats", QuestionId = 62 },
                new WrongAnswer { Id = 240, WrongAns = "Correct Answer Not Present", QuestionId = 62 },

                new WrongAnswer { Id = 241, WrongAns = "1", QuestionId = 63 },
                new WrongAnswer { Id = 242, WrongAns = "2", QuestionId = 63 },
                new WrongAnswer { Id = 243, WrongAns = "3", QuestionId = 63 },
                new WrongAnswer { Id = 244, WrongAns = "Correct Answer Not Present", QuestionId = 63 },

                new WrongAnswer { Id = 245, WrongAns = "48 cents", QuestionId = 64 },
                new WrongAnswer { Id = 246, WrongAns = "32 cents", QuestionId = 64 },
                new WrongAnswer { Id = 247, WrongAns = "16 cents", QuestionId = 64 },
                new WrongAnswer { Id = 248, WrongAns = "Correct Answer Not Present", QuestionId = 64 },

                new WrongAnswer { Id = 249, WrongAns = "271", QuestionId = 65 },
                new WrongAnswer { Id = 250, WrongAns = "471", QuestionId = 65 },
                new WrongAnswer { Id = 251, WrongAns = "742", QuestionId = 65 },
                new WrongAnswer { Id = 252, WrongAns = "Correct Answer Not Present", QuestionId = 65 },

                new WrongAnswer { Id = 253, WrongAns = "June", QuestionId = 66 },
                new WrongAnswer { Id = 254, WrongAns = "July", QuestionId = 66 },
                new WrongAnswer { Id = 255, WrongAns = "August", QuestionId = 66 },
                new WrongAnswer { Id = 256, WrongAns = "Correct Answer Not Present", QuestionId = 66 },

                new WrongAnswer { Id = 257, WrongAns = "Sunday", QuestionId = 67 },
                new WrongAnswer { Id = 258, WrongAns = "Tuesday", QuestionId = 67 },
                new WrongAnswer { Id = 259, WrongAns = "Wednesday", QuestionId = 67 },
                new WrongAnswer { Id = 260, WrongAns = "Correct Answer Not Present", QuestionId = 67 },

                new WrongAnswer { Id = 261, WrongAns = "5", QuestionId = 68 },
                new WrongAnswer { Id = 262, WrongAns = "2", QuestionId = 68 },
                new WrongAnswer { Id = 263, WrongAns = "Correct Answer Not Present", QuestionId = 68 },

                new WrongAnswer { Id = 264, WrongAns = "3", QuestionId = 69 },
                new WrongAnswer { Id = 265, WrongAns = "4", QuestionId = 69 },
                new WrongAnswer { Id = 266, WrongAns = "Correct Answer Not Present", QuestionId = 69 },

                new WrongAnswer { Id = 267, WrongAns = "28", QuestionId = 70 },
                new WrongAnswer { Id = 268, WrongAns = "30", QuestionId = 70 },
                new WrongAnswer { Id = 269, WrongAns = "31", QuestionId = 70 },
                new WrongAnswer { Id = 270, WrongAns = "Correct Answer Not Present", QuestionId = 70 },

                new WrongAnswer { Id = 271, WrongAns = "40", QuestionId = 71 },
                new WrongAnswer { Id = 272, WrongAns = "48", QuestionId = 71 },
                new WrongAnswer { Id = 273, WrongAns = "56", QuestionId = 71 },
                new WrongAnswer { Id = 274, WrongAns = "Correct Answer Not Present", QuestionId = 71 },

                new WrongAnswer { Id = 275, WrongAns = "2", QuestionId = 72 },
                new WrongAnswer { Id = 276, WrongAns = "6", QuestionId = 72 },
                new WrongAnswer { Id = 277, WrongAns = "Correct Answer Not Present", QuestionId = 72 },

                new WrongAnswer { Id = 278, WrongAns = "Hexagon", QuestionId = 73 },
                new WrongAnswer { Id = 279, WrongAns = "Both have the same", QuestionId = 73 },
                new WrongAnswer { Id = 280, WrongAns = "Neither", QuestionId = 73 },
                new WrongAnswer { Id = 281, WrongAns = "Correct Answer Not Present", QuestionId = 73 },

                new WrongAnswer { Id = 282, WrongAns = "Feathers", QuestionId = 74 },
                new WrongAnswer { Id = 283, WrongAns = "Stones", QuestionId = 74 },
                new WrongAnswer { Id = 284, WrongAns = "Neither", QuestionId = 74 },
                new WrongAnswer { Id = 285, WrongAns = "Correct Answer Not Present", QuestionId = 74 },

                new WrongAnswer { Id = 286, WrongAns = "WOOW", QuestionId = 75 },
                new WrongAnswer { Id = 287, WrongAns = "MOOM", QuestionId = 75 },
                new WrongAnswer { Id = 288, WrongAns = "POOL", QuestionId = 75 },
                new WrongAnswer { Id = 289, WrongAns = "Correct Answer Not Present", QuestionId = 75 },

                new WrongAnswer { Id = 290, WrongAns = "Red", QuestionId = 76 },
                new WrongAnswer { Id = 291, WrongAns = "Yellow", QuestionId = 76 },
                new WrongAnswer { Id = 292, WrongAns = "Lost", QuestionId = 76 },
                new WrongAnswer { Id = 293, WrongAns = "Correct Answer Not Present", QuestionId = 76 },

                new WrongAnswer { Id = 294, WrongAns = "55", QuestionId = 77 },
                new WrongAnswer { Id = 295, WrongAns = "70", QuestionId = 77 },
                new WrongAnswer { Id = 296, WrongAns = "50", QuestionId = 77 },
                new WrongAnswer { Id = 297, WrongAns = "Correct Answer Not Present", QuestionId = 77 },

                new WrongAnswer { Id = 298, WrongAns = "Cheese", QuestionId = 78 },
                new WrongAnswer { Id = 299, WrongAns = "Meat", QuestionId = 78 },
                new WrongAnswer { Id = 300, WrongAns = "Eggs", QuestionId = 78 },
                new WrongAnswer { Id = 301, WrongAns = "Correct Answer Not Present", QuestionId = 78 },

                new WrongAnswer { Id = 302, WrongAns = "A toy", QuestionId = 79 },
                new WrongAnswer { Id = 303, WrongAns = "A book", QuestionId = 79 },
                new WrongAnswer { Id = 304, WrongAns = "A song", QuestionId = 79 },
                new WrongAnswer { Id = 305, WrongAns = "Correct Answer Not Present", QuestionId = 79 }

            );
        }
    }
}
