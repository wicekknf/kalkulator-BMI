using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Person
    {
        public string FirstName;
        public string LastName;
        private DateTime dateOfBirth;
        private string contactNumber;
        public static int Count = 0;

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            Count++;
        }

        public Person(DateTime dateOfBirth, string firstName, string lastName) : this(firstName, lastName)
        {
            this.dateOfBirth = dateOfBirth;
        }

        public string ContactNumber
        {
            get { return contactNumber; }
            set {
                if (value.Length < 9)
                {
                    Console.WriteLine("Invalid phone number");
                } else
                {
                    contactNumber = value;
                }
                
            }
        }


        public DateTime DateOfBirth
        {
            get { return dateOfBirth;}
            set
            {
                if (value > DateTime.Now)
                {
                    Console.WriteLine("Inwalid date of birth");
                } else
                {
                    dateOfBirth = value;
                }
            }
        }

        //public void SetDateOfBirth (DateTime date) {
        //        if (date > DateTime.Now)
        //        {
        //            Console.WriteLine("Invalid date of birth");
        //        }
        //        else
        //        {
        //             dateOfBirth = date;
        //        }
        //    }
        //public DateTime GetDateOfBirth() => dateOfBirth;


        public void SayHi()
        {
            Console.WriteLine($"Hi! my name is {FirstName} {dateOfBirth}");
        }
    }

}
