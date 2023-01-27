using System.ComponentModel.DataAnnotations;

namespace StudentInfoWebAPI.Data
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string FullName { get; set; }

        [StringLength(30)]
        public string EMail { get; set; }

        [StringLength(15)]
        public string Phone { get; set; }
        public List<Computer> Computers { get; set; }

        [StringLength(20)]
        public College College { get; set; }
        public int CollegeId { get; set; }
        public bool IsSuccess { get; set; }

        [Range(20, 40)]
        public int Age { get; set; }

    }
}
