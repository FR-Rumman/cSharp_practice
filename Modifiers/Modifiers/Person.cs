using System;
using System.Collections.Generic;
using System.Text;

namespace Modifiers
{
    public class Person
    {
        private DateTime _birthdate;
        //public void SetBirthdate(DateTime birthdate)
        //{
        //    _birthdate = birthdate;
        //}
        //public DateTime GetBirthdate()
        //{
        //    return _birthdate;
        //}

        public int  MyProperty { get; set; }

        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }
        public DateTime Birthdate { get; private set; }
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }
    }
}
