using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoProject.Entities;

namespace ToDoProject.Managers
{
    internal class ConsoleManager
    {
        CardManager cardManager = new CardManager();
        PersonManager personManager = new PersonManager();
        #region Get Card List By Lines
        internal void ListCards()
        {
            Console.WriteLine("TODO LINE");
            foreach (var item in cardManager.GetCardsByLine(Line.TODO))
            {
                Console.WriteLine($"{item.Title}\n{item.Content}\n{item.Size}");
            }
            Console.WriteLine("********************************************");

            Console.WriteLine("IN PROGRESS LINE");
            foreach (var item in cardManager.GetCardsByLine(Line.InProgress))
            {
                Console.WriteLine($"{item.Title}\n{item.Content}\n{item.Size}");
            }
            Console.WriteLine("********************************************");


            Console.WriteLine("DONE LINE");
            foreach (var item in cardManager.GetCardsByLine(Line.Done))
            {
                Console.WriteLine($"{item.Title}\n{item.Content}\n{item.Size}");
            }
            Console.WriteLine("********************************************");
        }
        #endregion

        #region Get All People
        internal void ListPeople()
        {
            Console.WriteLine("Kişiler");
            foreach(var person in personManager.GetPeople())
            {
                    Console.WriteLine("********************************************");
                    Console.WriteLine($"{person.Id}\n{person.FullName}\n{person.Line}");
            }
        }
        #endregion

        #region Ask For Action
        void AskForAction()
        {
            Console.WriteLine($"Lütfen yapmak istediğiniz işlemi seçiniz :) \n*******************************************\n(1) Board Listelemek\n(2) Board'a Kart Eklemek\n(3) Board'dan Kart Silmek\n(4) Kart Taşımak");
            var answer = Console.ReadLine();
            switch (answer)
            {
                case "1":
                    ListCards();
                    break;
                case "2":
                    AddCardToBoard();
                    break;
                case "3":
                    //return Action.DeleteCardFromBoard;
                case "4":
                    //return Action.MoveCardToLine;
                default:
                    throw new Exception("Geçersiz Seçim");
            }
            
        }
        #endregion
        
        #region Add Card To Board
        internal void AddCardToBoard()
        {
            Card card = new Card();
            Console.WriteLine(" Başlık Giriniz                                    : ");
            card.Title=Console.ReadLine();
            Console.WriteLine(" İçerik Giriniz                                    : ");
            card.Content=Console.ReadLine();
            Console.WriteLine(" Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)    : ");
            card.Size=SizeManager.GetSizeEnum(Console.ReadLine());
            ListPeople();
            Console.WriteLine(" Kişi Seçiniz (Tam adını eksiksiz ve doğru yazınız): ");
            card.Person= personManager.GetPersonByFullName(Console.ReadLine());
            card.Line = Line.TODO;
            cardManager.AddCard(card);
            ListCards();

        }
        #endregion

    }
    internal enum Action
        {
            ListBoard = 1,
            AddCardToBoard,
            DeleteCardFromBoard,
            MoveCardToLine
        }
}
