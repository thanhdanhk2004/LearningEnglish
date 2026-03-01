using FlashcardService.Domain.EntitiesFrashcard;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashcardService.Infrastructure.Configuration
{
    public class FlashcardConfiguration : IEntityTypeConfiguration<Flashcard>
    {
        public void Configure(EntityTypeBuilder<Flashcard> builder)
        {
            builder.ToTable("Flashcards");
            builder.HasKey(f => f.FlashcardId);

            builder.Property(f => f.FlashcardName).IsRequired().HasMaxLength(128);
            builder.Property(f => f.FlashcardDescription).IsRequired(false).HasMaxLength(2000);
        }
    }
}
