using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfp_birthday_manager
{
    class Person
    {
        private string name { get; set; }
        private string lastName { get; set; }
        private DateTime birthday { get; set; }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        public int NextBirthday;

        public void ToNextBirthday(Person p)
        {
            DateTime today = DateTime.Today;
            DateTime next = new DateTime(today.Year, p.Birthday.Month, p.Birthday.Day);

            if (next < today)
                next = next.AddYears(1);

            int numDays = (next - today).Days;

            p.NextBirthday = numDays;
        }

        //public void ToNextBirthday(DateTime personsBirthday)
        //{
        //    DateTime nextBirthday = new DateTime(DateTime.Today.Year, personsBirthday.Month, personsBirthday.Day);

        //    Console.WriteLine("Days to next birthday: " + (nextBirthday.Subtract(DateTime.Today).TotalDays));
        //    Console.WriteLine("=============================================================");
        //}

        public override string ToString()
        {
            return string.Format("Name: {0} Last Name: {1} Birthday: {2} Next Birthday: {3}", Name, LastName, Birthday, NextBirthday);
        }

    }
}
