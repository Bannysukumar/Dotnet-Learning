using System.ComponentModel.DataAnnotations;

namespace Modules.Student
{
    public class Student
    {
        [Key]
        public int RollNumber { get; set; }
        public string StudentName { get; set; }
        public string StudentClass { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
        public int Age { get; set; }
    }
}