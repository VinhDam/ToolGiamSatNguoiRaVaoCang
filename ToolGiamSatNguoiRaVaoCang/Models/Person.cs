using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ToolGiamSatNguoiRaVaoCang.Data;

namespace ToolGiamSatNguoiRaVaoCang.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public string? CCCD { get; set; }
        public string? Description { get; set; }

        public int? ZoneId { get; set; }
        [ForeignKey("ZoneId")]
        public Zone? Zone { get; set; }

        public int? CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        public Company? Company { get; set; }

        public int? ShiftId { get; set; }
        [ForeignKey("ShiftId")]
        public Shift? Shift { get; set; }
        public bool Status { get; set; }
        public int? PriorityId { get; set; }
        [ForeignKey("PriorityId")]
        public IssuePriority Priority { get; set; }
        public string UserCreate { get; set; }
        public string UserUpdate { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
