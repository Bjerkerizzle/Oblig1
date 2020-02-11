using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Channels;

namespace Oblig1
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine(".______________________________________________.");
         Console.WriteLine("|           Det kongelige slektstre!           |");
         Console.WriteLine("|                                              |");
         Console.WriteLine("| Dette programmet viser en oversikt over      |");
         Console.WriteLine("| Norges kongefamilie, med informasjon om      |");
         Console.WriteLine("| fødsels- og dødsdatoer og familierelasjoner. |");
         Console.WriteLine("|                                              |");
         Console.WriteLine("| Skriv 'hjelp' for å vise alle kommandoer     |");
         Console.WriteLine("|______________________________________________|");
         while (true)
         {
             Console.Write("\r\nSkriv inn kommando:");
             var input = Console.ReadLine();
             var ListPeople = PersonList();

             if (input == "hjelp")
             {
                 ShowHelpText();
             }
             if (input == "liste")
             {
                 ShowAllPeople(ListPeople);
             }

             if (input.StartsWith("vis"))
             {
                 int id = Convert.ToInt32(input.Substring(4, 1));
                 ListPeople[id - 1].Show();
             }
         }
        }

        private static void ShowAllPeople(List<Person> listPeople)
        {
            for (var i = 0; i < listPeople.Count; i++)
            {
                listPeople[i].Show();
            }
        }
            private static void ShowHelpText()
            {
                Console.WriteLine("Skriv 'liste' for å se alle personer i slektstreet.");
                Console.WriteLine("Skriv 'vis [ID]' for å se informasjon om personen med ID nummeret du velger.");
            }
            public static List<Person> PersonList()
            {
                var sverreMagnus = new Person {Id = 1, FirstName = "Sverre Magnus", BirthYear = 2005, DeathYear = 0};
                var ingridAlexandra = new Person {Id = 2, FirstName = "Ingrid Alexandra", BirthYear = 2004, DeathYear = 0};
                var haakon = new Person {Id = 3, FirstName = "Haakon Magnus", BirthYear = 1973, DeathYear = 0};
                var metteMarit = new Person {Id = 4, FirstName = "Mette-Marit", BirthYear = 1973, DeathYear = 0};
                var marius = new Person {Id = 5, FirstName = "Marius", LastName = "Borg Høiby", BirthYear = 1997, DeathYear = 0};
                var harald = new Person {Id = 6, FirstName = "Harald", BirthYear = 1937, DeathYear = 0};
                var sonja = new Person {Id = 7, FirstName = "Sonja", BirthYear = 1937, DeathYear = 0};
                var olav = new Person {Id = 8, FirstName = "Olav", BirthYear = 1903, DeathYear = 1991};
               
                // Parent list
                sverreMagnus.Father = haakon;
                sverreMagnus.Mother = metteMarit;
                ingridAlexandra.Father = haakon;
                ingridAlexandra.Mother = metteMarit;
                marius.Mother = metteMarit;
                haakon.Father = harald;
                haakon.Mother = sonja;
                harald.Father = olav;
                
                // Child list
                metteMarit.Child1 = ingridAlexandra;
                metteMarit.Child2 = sverreMagnus;
                metteMarit.Child3 = marius;                
                haakon.Child1 = ingridAlexandra;
                haakon.Child2 = sverreMagnus;
                harald.Child1 = haakon;
                sonja.Child1 = haakon;
                olav.Child1 = harald;

                var list = new List<Person>
                {
                    sverreMagnus, ingridAlexandra, haakon, metteMarit, marius, harald, sonja, olav
                };
                return list;
            }
    }
}
