using FlashcardService.Domain.EntitiesFrashcard;
using FlashcardService.Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashcardService.Infrastructure.Context
{
    public class DBContextFlashcard:DbContext
    {
        public DBContextFlashcard(DbContextOptions<DBContextFlashcard> options) : base(options) { }
        public DBContextFlashcard() { }

        public virtual DbSet<Flashcard> Flashcards { get; set; }
        public virtual DbSet<Vocabulary> Vocabularies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FlashcardConfiguration());
            modelBuilder.ApplyConfiguration(new VocabularyConfiguration());
        }
    }
}
