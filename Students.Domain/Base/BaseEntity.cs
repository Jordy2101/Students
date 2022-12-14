using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Students.Domain.Base
{
    public class BaseEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? IsActive { get; set; }
    }
}
