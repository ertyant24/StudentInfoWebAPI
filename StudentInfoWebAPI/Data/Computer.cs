using System.ComponentModel.DataAnnotations;

namespace StudentInfoWebAPI.Data
{
    public class Computer
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string BrandName { get; set; }

        [StringLength(20)]
        public string OS { get; set; }
        public bool IsActive { get; set; }
        public List<Student> Students { get; set; }

    }
}
