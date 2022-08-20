using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoProject.Entities
{
    internal class Person
    {
        internal int Id { get; set; }
        internal string FullName { get; set; } = "";

        internal Line Line { get; set; }

    }


}
