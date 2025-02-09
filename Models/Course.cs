﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;


namespace TestProject1.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string? Title { get; set; }
        public int Credits { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}


