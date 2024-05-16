using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC.Models{
    [Table("Preson")]
    public class Preson{
        [Key]
        public string PresonId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
    
    }
}
//Le Thi Mai Anh-2021050076