﻿using System.ComponentModel.DataAnnotations;

namespace SampleAutomapper.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public string UserName { get; set; }
    }
}
