using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFTest
{
    public class ExternalMemberExtension
    {
        [Key]
        public int ExternalMemberExtensionID { get; set; }

        [Index("ExternalMember")]
        public int ExternalMemberID { get; set; }

        public WellknownExtension Type { get; set; }

        [MaxLength(100)]
        public string Value { get; set; }
    }

    public enum WellknownExtension
    {
        BioIQProgramCode = 10
    }
}