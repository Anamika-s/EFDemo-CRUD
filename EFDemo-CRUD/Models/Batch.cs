using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo_CRUD.Models
{
    [Table("tblBatches")]
    public class Batch
    {
        [Key]
        
        public int  BatchCode { get; set; }

        public string Comment { get; set; }
        [Range(20,40)]
        [Required]
        [Column(Order =5)]
        public int Age { get; set; }
        
        [Required]
        [StringLength(20)]
        [MinLength(10)]
        [Column("BatchName")]
        public string? Name { get; set; }
        
        [Required]
        [Column("TrainerName")]
        public string Trainer { get; set; }
        
        [Required]
        public string? Description { get; set; }
        
        public DateTime? StartDate { get; set; }

        
    }
}
