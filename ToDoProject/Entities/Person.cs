using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoProject.Entities
{
    internal class People
    {
        List<Person> people = new List<Person>()
        {
            new Person()
            {
                FullName="Melek Doğan",
                Line=Line.InProgress
            },
            new Person()
            {
                FullName="Simge Tatlı",
                Line=Line.TODO
            },
            new Person()
            {
                FullName="Kıvılcım Erel",
                Line=Line.Done
            },
            new Person()
            {
                FullName="Özhan Üzmez",
                Line=Line.InProgress
            },
            new Person()
            {
                FullName="Maria Yorgancı",
                Line=Line.TODO
            },
            new Person()
            {
                FullName="Sefa Gülbahar",
                Line=Line.Done
            },
             new Person()
            {
                FullName="Melis Demirel",
                Line=Line.InProgress
            },
            new Person()
            {
                FullName="Simge Tarhan",
                Line=Line.TODO
            },
            new Person()
            {
                FullName="Eren Demir",
                Line=Line.Done
            },
            new Person()
            {
                FullName="Orhan Ürkmez",
                Line=Line.InProgress
            },
            new Person()
            {
                FullName="Meryem Tulumbacı",
                Line=Line.TODO
            },
            new Person()
            {
                FullName="Melike Bahar",
                Line=Line.Done
            },

        };
    }
    internal class Person
    {
        internal string FullName { get; set; } = "";

        internal Line Line { get; set; }

    }


}
