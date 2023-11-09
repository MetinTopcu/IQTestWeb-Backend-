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
    internal class QuestionSeed : IEntityTypeConfiguration<Question> //AppDbContext'i kirletlememek için burada yapıyoruz
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            //seed data sırasında id leri kendimiz vereceğiz uygulamanın başka yerlerinde bu işlemi yapmıyoruz

            builder.HasData(new Question { Id = 1, Questions = "Which number logically follows this series? 4,6,9,6,14,6,...", CreatedDate = DateTime.Now }, 
                new Question{ Id = 2, Questions = "Choose a number, double it, add 10, halve it, and subtract your original number. The result is:", CreatedDate = DateTime.Now },
                new Question { Id = 3, Questions = "In a race, you pass the person in the 2nd place. What position are you in now?", CreatedDate = DateTime.Now },
                new Question { Id = 4, Questions = "Which word does not belong? Apple, Muffin, Orange, Cherry", CreatedDate = DateTime.Now },
                new Question { Id = 5, Questions = "If you had only one match and entered a dark room containing an oil lamp, some kindling wood, and a newspaper, which would you light first?", CreatedDate = DateTime.Now },
                new Question { Id = 6, Questions = "Which word does not belong? Typhoon, Hurricane, Tornado, Light" , CreatedDate = DateTime.Now },
                new Question { Id = 7, Questions = "What is the next number in the series: 10, 12, 14, 16,...?" , CreatedDate = DateTime.Now },
                new Question { Id = 8, Questions = "What is the number that is one more than one-tenth of one-fifth of one-half of 4,000?" },
                new Question { Id = 9, Questions = "If all Zips are Zoodles, and the Zoodle Zane is a Zip, then Zane is definitely a Zoodle. True or False?" , CreatedDate = DateTime.Now },
                new Question { Id = 10, Questions = "Which number should come next in this series? 25, 24, 22, 19, 15,..." , CreatedDate = DateTime.Now },
                new Question { Id = 11, Questions = "Which shape does not belong? Circle, Square, Triangle, Cylinder" , CreatedDate = DateTime.Now },
                new Question { Id = 12, Questions = "What is half of two-thirds of three-quarters of four-fifths of 500?" , CreatedDate = DateTime.Now },
                new Question { Id = 13, Questions = "If you rearrange the letters \"BARBIT\", you would have the name of a:" , CreatedDate = DateTime.Now },
                new Question { Id = 14, Questions = "Which one of the five is least like the other four?" , CreatedDate = DateTime.Now },
                new Question { Id = 15, Questions = "Which number should come next in this series? 37, 34, 31, 28" , CreatedDate = DateTime.Now },
                new Question { Id = 16, Questions = "If you remove one side from two identical squares and join them at the exposed points, what shape would you get?" , CreatedDate = DateTime.Now },
                new Question { Id = 17, Questions = "If you rearrange the letters \"OTOYTA\", you get the name of a:" , CreatedDate = DateTime.Now },
                new Question { Id = 18, Questions = "Choose the word most opposite to Cautious:" , CreatedDate = DateTime.Now },
                new Question { Id = 19, Questions = "If all Bloops are Razzies and all Razzies are Lazzies, then all Bloops are definitely Lazzies?" , CreatedDate = DateTime.Now },
                new Question { Id = 20, Questions = "Which one of the five makes the best comparison? Brother is to sister as niece is to:" , CreatedDate = DateTime.Now },
                new Question { Id = 21, Questions = "If the day after tomorrow is a Sunday, then what day is it today?" , CreatedDate = DateTime.Now },
                new Question { Id = 22, Questions = "Which of the following is least like the others?" , CreatedDate = DateTime.Now },
                new Question { Id = 23, Questions = "How many two-cent stamps are there in a dozen?" , CreatedDate = DateTime.Now },
                new Question { Id = 24, Questions = "Which of these is not a type of triangle based on its angles?" , CreatedDate = DateTime.Now },
                new Question { Id = 25, Questions = "If some Smaugs are Thors and some Thors are Thrains, then some Smaugs are definitely Thrains. This statement is:" , CreatedDate = DateTime.Now },
                new Question { Id = 26, Questions = "Ralph likes 25 but not 24; he likes 400 but not 300; he likes 144 but not 145. Which does he like?", CreatedDate = DateTime.Now },
                new Question { Id = 27, Questions = "A plane crashes on the border of the U.S. and Canada. Where do they bury the survivors?", CreatedDate = DateTime.Now },
                new Question { Id = 28, Questions = "The more you take from it, the larger it grows. What is it?", CreatedDate = DateTime.Now },
                new Question { Id = 29, Questions = "What is the missing number in the sequence: 4, 9, 16, 25, ?, 49", CreatedDate = DateTime.Now },
                new Question { Id = 30, Questions = "A train leaves from New York City heading towards Los Angeles at 100 mph. Three hours later, a train leaves LA heading towards NYC at 200 mph. Which train will be closer to NYC when they meet?", CreatedDate = DateTime.Now },
                new Question { Id = 31, Questions = "Which word is the odd one out: First, Second, Third, Forth, Fifth, Sixth, Seventh, Eighth?" , CreatedDate = DateTime.Now },
                new Question { Id = 32, Questions = "If a red house is made of red bricks and a blue house is made of blue bricks, what is a green house made of?" , CreatedDate = DateTime.Now },
                new Question { Id = 33, Questions = "What is half of a quarter of 400?" , CreatedDate = DateTime.Now },
                new Question { Id = 34, Questions = "If you reverse the word \"STOP\", what do you get?" , CreatedDate = DateTime.Now },
                new Question { Id = 35, Questions = "Which number is the odd one out: 3, 5, 11, 14, 17, 21?", CreatedDate = DateTime.Now },
                new Question { Id = 36, Questions = "The maker doesn't want it; the buyer doesn't use it; and the user doesn't see it. What is it?" , CreatedDate = DateTime.Now },
                new Question { Id = 37, Questions = "If a doctor gives you 3 pills and tells you to take one every half hour starting immediately, how long would it be before all the pills had been taken?", CreatedDate = DateTime.Now },
                new Question { Id = 38, Questions = "How many 9s are there between 1 and 100?", CreatedDate = DateTime.Now },
                new Question { Id = 39, Questions = "If it takes 8 men 10 hours to build a wall, how long would it take 4 men?", CreatedDate = DateTime.Now },
                new Question { Id = 40, Questions = "How many of each species did Moses take on the ark?", CreatedDate = DateTime.Now },
                new Question { Id = 41, Questions = "Select a number that is one-third of one-half of one-fifth of 210" , CreatedDate = DateTime.Now },
                new Question { Id = 42, Questions = "Which word spelled backwards will be the same as the original word?" , CreatedDate = DateTime.Now },
                new Question { Id = 43, Questions = "Which of the following can you find in the middle of Tokyo?" , CreatedDate = DateTime.Now },
                new Question { Id = 44, Questions = "Which number is one half of one quarter of one tenth of 400?" , CreatedDate = DateTime.Now },
                new Question { Id = 45, Questions = "If a circle is one, how many is an octagon?" , CreatedDate = DateTime.Now },
                new Question { Id = 46, Questions = "Mike is taller than Peter, and Ray is shorter than Mike. Which of the following statements would be more accurate?" , CreatedDate = DateTime.Now },
                new Question { Id = 47, Questions = "If more Winks are Pinkos and all Drabs are Durs, and some Pinkos are Drabs, then some Winks are definitely Durs. True or False?" , CreatedDate = DateTime.Now },
                new Question { Id = 48, Questions = "John needs 13 bottles of water from the store. John can only carry 3 at a time. What is the minimum number of trips John needs to make to the store?" , CreatedDate = DateTime.Now },
                new Question { Id = 49, Questions = "Choose the word most similar to Reckless:" , CreatedDate = DateTime.Now },
                new Question { Id = 50, Questions = "If you turn your left glove inside out, it will fit your right hand. True or False?" , CreatedDate = DateTime.Now },
                new Question { Id = 51, Questions = "What comes next in the series: O, T, T, F, F,...?" , CreatedDate = DateTime.Now },
                new Question { Id = 52, Questions = "If you rearrange the letters \"CIFAIPC\" you would have the name of a(n):" , CreatedDate = DateTime.Now },
                new Question { Id = 53, Questions = "What is the missing number in the sequence shown below? 1, 8, 27, ?, 125" , CreatedDate = DateTime.Now },
                new Question { Id = 54, Questions = "If you rearrange the letters \"SCTOLDNA\", you would have the name of a:" , CreatedDate = DateTime.Now }, 
                new Question { Id = 55, Questions = "Mary, who is sixteen years old, is four times older than her brother. How old will Mary be when she is twice as old as her brother?" , CreatedDate = DateTime.Now },
                new Question { Id = 56, Questions = "Choose the word most similar to Trustworthy:" , CreatedDate = DateTime.Now },
                new Question { Id = 57, Questions = "Which number represents the letter T in the series made of numbers 1-26?" , CreatedDate = DateTime.Now },
                new Question { Id = 58, Questions = "Which word does not belong with the others?" , CreatedDate = DateTime.Now },
                new Question { Id = 59, Questions = "What is the next letter in the sequence: O, T, T, F, F, S, S, ?" },
                new Question { Id = 60, Questions = "Fred will be twice as old as John in 5 years. If John is 10 years old, how old is Fred now?" , CreatedDate = DateTime.Now },
                new Question { Id = 61, Questions = "If Richard looks into a mirror and touches his left ear with his right hand, Richard's image seems to touch its right ear with its left hand. If Richard moves his left foot forward, the foot of Richard's image seems to move:" , CreatedDate = DateTime.Now },
                new Question { Id = 62, Questions = "If some Bats are Birds, all Birds are Beasts, and some Beasts are Blooms, then it's necessarily the case that:" , CreatedDate = DateTime.Now },
                new Question { Id = 63, Questions = "In a year, some months have 30 days, while others have 31. How many months have 28 days?" , CreatedDate = DateTime.Now },
                new Question { Id = 64, Questions = "If two pencils cost six cents, how much do eight pencils cost?" , CreatedDate = DateTime.Now },
                new Question { Id = 65, Questions = "If ROSE is coded as 6821, CHAIR is coded as 73456, then ARC is:" , CreatedDate = DateTime.Now },
                new Question { Id = 66, Questions = "Tom's mother has three children. The first was named April, the second was named May. What was the third child's name?" , CreatedDate = DateTime.Now },
                new Question { Id = 67, Questions = "If the day before yesterday was Saturday, what day is it today?" , CreatedDate = DateTime.Now },
                new Question { Id = 68, Questions = "What is the next number in the sequence? 9,8,6,3?" , CreatedDate = DateTime.Now },
                new Question { Id = 69, Questions = "If a circular pizza is divided into eighths, how many pieces make a quarter of the pizza?" , CreatedDate = DateTime.Now },
                new Question { Id = 70, Questions = "In a leap year, how many days does February have?" , CreatedDate = DateTime.Now },
                new Question { Id = 71, Questions = "What is the next number in the sequence: 2, 4, 8, 16, 32, ... ?" , CreatedDate = DateTime.Now },
                new Question { Id = 72, Questions = "If there is a bowl with six apples and you take away four, how many do you have?" , CreatedDate = DateTime.Now },
                new Question { Id = 73, Questions = "Which shape has more sides: a hexagon or an octagon?" , CreatedDate = DateTime.Now },
                new Question { Id = 74, Questions = "Which is heavier: a pound of feathers or a pound of stones?" , CreatedDate = DateTime.Now },
                new Question { Id = 75, Questions = "Which word, when written in capital letters, is the same forwards, backwards and upside down?" , CreatedDate = DateTime.Now },
                new Question { Id = 76, Questions = "If you drop a yellow hat in the Red Sea, what does it become?" , CreatedDate = DateTime.Now },
                new Question { Id = 77, Questions = "Divide 30 by half and add 10. What do you get?" , CreatedDate = DateTime.Now },
                new Question { Id = 78, Questions = "Which of the following words is the odd one out? Cheese, Meat, Eggs, Lettuce" , CreatedDate = DateTime.Now },
                new Question { Id = 79, Questions = "What can be cracked, made, told, and played?" , CreatedDate = DateTime.Now }
                );
        }
    }
}
