using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TE_CFA.Models
{
    public class Trainee
    {
        [Key]
        public int Id { get;set;}
        [Required]
        public string Name { get;set;}
        [Required]
        public string Designation { get;set;}

        [Required]
        [Display(Name="Date of Join")]
        public DateTime DOJ { get; set; }

    }
}
