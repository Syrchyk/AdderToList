﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    public class People
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone {  get; set; }
        public DateTime Birthday { get; set; }
        public Gender PeopleGender { get; set; }
    }
    public enum Gender
    {
        Male,
        Female
    }
}
