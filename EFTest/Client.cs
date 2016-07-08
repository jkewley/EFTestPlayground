using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFTest
{
    public class Client
    {
        public Client() {
            Members = new List<ExternalMember>();
        }

        [Key]
        public int ClientID { get; set; }


        //[Column("ManagerExternalMemberID")]
        //[Index("ExternalMember")]
        //        [InverseProperty("ExternalMemberID")]
        [Required]
        public int ManagerID { get; set; }

        //        [Column("ManagerID")]
        //        [Index("ExternalMemberManager")]
        //        public int ExternalMemberID { get; set; }
        //
        [ForeignKey("ManagerID")]
        public virtual ExternalMember Manager { get; set; }

        public virtual List<ExternalMember> Members { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }
    }
}