using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoProject.Entities
{
    internal class Card
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public string Content { get; set; } = "";
        public Size Size { get; set; }
        public Line Line { get; set; }
        public Person Person { get; set; }
    }
}
