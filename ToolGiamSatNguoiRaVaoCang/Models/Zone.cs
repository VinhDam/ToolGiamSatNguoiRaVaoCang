using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToolGiamSatNguoiRaVaoCang.Models
{
    public class Zone
    {
        [Key]
        public int Id { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? ZoneTypeId { get; set; }
        public bool Status { get; set; }
        public int? PriorityId { get; set; }
        [ForeignKey("PriorityId")]
        public IssuePriority Priority { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        [ForeignKey("ZoneTypeId")]
        public ZoneType? ZoneType { get; set; }
    }
}
