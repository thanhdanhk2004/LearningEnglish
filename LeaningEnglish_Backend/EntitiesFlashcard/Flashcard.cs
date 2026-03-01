using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashcardService.Domain.EntitiesFlashcard
{
    public class Flashcard
    {
        public Guid FlashcardId { get; set; }
        public string FlashcardName {  get; set; }
        public string FlashcardDescription {  get; set; }
        public bool FlashcardType {  get; set; }
        public Flashcard(string flashcardName, string flashcardDescription, bool flashcardType)
        {
            FlashcardId = Guid.NewGuid();
            FlashcardName = flashcardName;
            FlashcardDescription = flashcardDescription;
            FlashcardType = flashcardType;
        }
    }
}
