using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoProject.Entities;

namespace ToDoProject.Managers
{
    internal class PersonManager
    {
        #region People List
        List<Person> people = new List<Person>()
        {
            new Person()
            {
                Id = 1,
                FullName="Melek Doğan",
                Line=Line.InProgress
            },
            new Person()
            {
                Id=2,
                FullName="Simge Tatlı",
                Line=Line.TODO
            },

            new Person()
            {
                Id=3,
                FullName="Özhan Üzmez",
                Line=Line.InProgress
            },
            new Person()
            {
                Id=4,
                FullName="Maria Yorgancı",
                Line=Line.TODO
            },
            new Person()
            {
                Id=5,
                FullName="Sefa Gülbahar",
                Line=Line.Done
            },
             new Person()
            {
                 Id=6,
                FullName="Melis Demirel",
                Line=Line.InProgress
            },
            new Person()
            {
                Id=7,
                FullName="Simge Tarhan",
                Line=Line.TODO
            },
            new Person()
            {
                Id=8,
                FullName="Eren Demir",
                Line=Line.Done
            },
            new Person()
            {
                Id=9,
                FullName="Orhan Ürkmez",
                Line=Line.InProgress
            },
            new Person()
            {
                Id=10,
                FullName="Meryem Tulumbacı",
                Line=Line.TODO
            },
            new Person()
            {
                Id=11,
                FullName="Melike Bahar",
                Line=Line.Done
            },
            new Person()
            {
                Id=12,
                FullName="Kıvılcım Erel",
                Line=Line.Done
            }
        };
        #endregion

        #region Get All People
        internal List<Person> GetPeople()
        {
            return people;
        }

        #endregion

        #region Get Person By Fullname
        internal Person GetPersonByFullName(string fullname)
        {
           return people.Where(p => p.FullName == fullname).FirstOrDefault();
        }
        #endregion

    }
}
