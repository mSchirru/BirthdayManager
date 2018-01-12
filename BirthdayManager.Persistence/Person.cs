using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayManager.Persistence
{
    public class Person
    {
        private string name { get; set; }
        private string lastName { get; set; }
        private DateTime birthday { get; set; }
        private int nextBirthday { get; set; }

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

        public int NextBirthday
        {
            get { return nextBirthday; }
            set { nextBirthday = value; }
        }

        public void ToNextBirthday(Person p)
        {
            DateTime today = DateTime.Today;
            DateTime next = new DateTime(today.Year, p.Birthday.Month, p.Birthday.Day);

            if (next < today)
                next = next.AddYears(1);

            int numDays = (next - today).Days;

            p.NextBirthday = numDays;
        }


        public override string ToString()
        {
            return string.Format("Name: {0} Last Name: {1} Birthday: {2} Next Birthday: {3}", Name, LastName, Birthday, NextBirthday);
        }

    }
}
