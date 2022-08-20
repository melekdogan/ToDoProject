using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoProject.Managers
{
    internal class ConsoleManager
    {
        CardManager cardManager = new CardManager();

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

        #region Ask For 
    }
}
