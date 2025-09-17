using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace OrgManager.WinForms.Domain
{
    public class OrgNode
    {
        public int Id { get; set; }


        [Required]
        public OrgNodeType Type { get; set; }


        // 4-úrovňová hierarchia zabezpečíme stromom cez ParentId
        public int? ParentId { get; set; }
        public OrgNode? Parent { get; set; }
        public ICollection<OrgNode> Children { get; set; } = new List<OrgNode>();


        [Required, MaxLength(50)]
        public string Code { get; set; } = null!;


        [Required, MaxLength(200)]
        public string Name { get; set; } = null!;


        // Vedúci je zamestnanec firmy
        public int? LeaderEmployeeId { get; set; }
        public Employee? Leader { get; set; }


        [NotMapped]
        public string Display_orig => $"[{Code}] {Name}";

        [NotMapped]
        public string Display
        {
            get
            {
                var leaderName = Leader != null
                    ? $" (Vedúci: {Leader.FirstName} {Leader.LastName})"
                    : "";
                return $"[{Code}] {Name}{leaderName}";
            }
        }
    }
}