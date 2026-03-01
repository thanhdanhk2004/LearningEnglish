using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashcardService.Domain.EntitiesFlashcard
{
    public class Vocabulary
    {
        public Guid VobId { get; set; }
        public string Terminology { get; set; }
        public string Define { get; set; }
        public string Type {  get; set; }
        public string Image {  get; set; }

        public Vocabulary(string Terminology, string Define)
        {
            this.VobId = Guid.NewGuid();
            this.Terminology = Terminology;
            this.Define = Define;
        }
    }
}
