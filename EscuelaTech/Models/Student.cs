
namespace EscuelaTech.Models
{
   

        public class Student
        {
            public int ID { get; set; }
            public string? LastName1 { get; set; }
            public string? LastName2 { get; set; }
            public string? Name { get; set; }
            public DateTime EnrollmentDate { get; set; }

            public ICollection<Enrollment> Enrollments { get; set; }
        }
    
}
