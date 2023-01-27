using System.ComponentModel.DataAnnotations;

namespace StudentInfoWebAPI.Data
{
    public class College
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(25)]
        public string Name { get; set; }
        public int Capacity { get; set; }

        [Range(0, 100)]
        public int SuccessRate { get; set; }
        //public List<Student> Students { get; set; }





    }
}
