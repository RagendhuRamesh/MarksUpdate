using System;
using System.Collections.Generic;

namespace MarksUpdate.Models
{
    public partial class Student
    {
        public int StudentId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? ClassId { get; set; }
        public int? Marks { get; set; }

      public virtual Class? Class { get; set; }
    }
}
