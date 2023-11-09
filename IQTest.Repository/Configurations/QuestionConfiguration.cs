using IQTest.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQTest.Repository.Configurations
{
    internal class QuestionConfiguration : IEntityTypeConfiguration<Question> //Question entity mizdeki id lerin primary key olduğunu
        // id nin birer birer artacağını vs tanımlıyoruz
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Questions).IsRequired(); // null olamaz

            builder.ToTable("Questions");
        }
    }
}
