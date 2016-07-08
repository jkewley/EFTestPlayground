using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFTest
{
    public class ExternalMemberLoginHistory
    {
        public ExternalMemberLoginHistory() {
            TimeStamp = DateTime.Now;
        }

        public virtual ExternalMember ExternalMember { get; set; }

        [Column("ReferenceMemberIdentifier")]
        [Required]
        [Index("ExternalMember")]
        public int ExternalMemberID { get; set; }

        [Key]
        public int ExternalMemberLoginHistoryID { get; set; }

        [Required]
        public string Payload { get; set; }

        [Required]
        public DateTime TimeStamp { get; set; }
    }
}