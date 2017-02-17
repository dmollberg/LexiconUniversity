using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LexiconUniversity.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseId { get; set; }  //Should be named just Id in general -- [Key] above to mark a field as primarykey without Id in it.

        public string Name { get; set; }
        public int Credits { get; set; }

        // Navigation property
        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}