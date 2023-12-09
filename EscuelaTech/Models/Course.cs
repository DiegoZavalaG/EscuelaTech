using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EscuelaTech.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string? Title { get; set; }
        public string? MasterName { get; set; }
        public string? MasterLastName1 { get; set; }
        public string? MasterLastName2 { get; set; }


        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
