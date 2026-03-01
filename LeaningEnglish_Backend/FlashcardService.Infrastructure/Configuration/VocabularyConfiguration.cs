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
    public class VocabularyConfiguration : IEntityTypeConfiguration<Vocabulary>
    {
        public void Configure(EntityTypeBuilder<Vocabulary> builder)
        {
            builder.ToTable("Vocabularies");
            builder.HasKey(v => v.VobId);

            builder.Property(v => v.Terminology).IsRequired(false);
            builder.Property(v => v.Define).IsRequired(false);

            builder.HasOne(v => v.flashcard)
                .WithMany(f => f.Vocabularies)
                .HasForeignKey(v => v.FlashcardId);
        }
    }
}
