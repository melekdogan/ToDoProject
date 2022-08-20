using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoProject.Entities;

namespace ToDoProject.Managers
{
    internal class CardManager
    {
        public List<Card> Cards = new List<Card>();

        internal List<Card> GetCardsByLine(Line line)
        {
            return Cards.Where(c => c.Line == line).ToList();
        }

        internal void AddCard(Card card)
        {
            Cards.Add(card);
            Console.WriteLine("Card Added!");
        }
        internal void UpdateCard(Card card)
        {
            var cardToUpdate = Cards.Where(C => C.Id == card.Id).FirstOrDefault();
            cardToUpdate.Line = card.Line;
            cardToUpdate.Title = card.Title;
            cardToUpdate.Content = card.Content;
            cardToUpdate.Size = card.Size;

        }
        internal void DeleteCardByTitle(string title)
        {
            // Parametrede verilen herhangi bir başlık var mı yok mu bunu kontrol ediyorum.
            var isThereAny = Cards.Exists(c => c.Title == title);
            // eğer false dönerse (bu yok demektir) ekrana o başlığa sahip bir kartın bulunamadığını yazdırıyorum. 
            if (!isThereAny) Console.WriteLine("There isn't any card with the title you searched!");
            //Başlığı eşleşen tüm kartları siliyorum ve ekrana işlemin başarılı olduğu bilgisini yazdırıyorum.                 
            Cards.RemoveAll(c => c.Title == title);
            Console.WriteLine("Card/Cards been deleted successfully!");
        }
        internal void MoveCardToLine(Card cardToMove, Line line)
        {
            var card = Cards.Where(C => C.Id == cardToMove.Id).FirstOrDefault();
            card.Line = line;
        }
    }
}
