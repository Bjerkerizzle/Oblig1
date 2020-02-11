#nullable enable
using System;
using System.Collections.Generic;
using System.Text;

namespace Oblig1
{
    class Person
    {
        public  int Id { get; set; }
        public  string FirstName { get; set; }
        public  string LastName { get; set; }
        public  int BirthYear { get; set; }
        public int DeathYear { get; set; }
        public Person Father { get; set; }
        public Person Mother { get; set; }
        public Person Child1 { get; set; }
        public Person Child2 { get; set; }
        public Person Child3 { get; set; }
        
    public void Show() {
        if (FirstName != null)
        {
            Console.WriteLine("\r\nFirstname: " + FirstName);
        }

        if (LastName != null)
        {
            Console.WriteLine("Lastname: " + LastName);
        }
        if (BirthYear != 0)
        {
            Console.WriteLine("Birthyear: " + BirthYear);
        }
        if (DeathYear != 0)
        {
            Console.WriteLine("Deathyear: " + DeathYear);
        }
        if (Father != null)
        {
            Console.WriteLine("Father: " + Father.FirstName);
        }
        if (Mother != null)
        {
            Console.WriteLine("Mother: " + Mother.FirstName);
        }        
        if (Child1 != null)
        {
            Console.WriteLine("Child 1: " + Child1.FirstName);
        }        
        if (Child2 != null)
        {
            Console.WriteLine("Child 2: " + Child2.FirstName);
        }        
        if (Child3 != null)
        {
            Console.WriteLine("Child 3: " + Child3.FirstName);
        }
        if (Id != 0)
        {
            Console.WriteLine("Id: " + Id + "\r\n");
        }
        }
    }
}
