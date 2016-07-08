using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFTest
{
    public class ExternalMember
    {
        public ExternalMember() {
            Extensions = new List<ExternalMemberExtension>();
            Clients = new List<Client>();
            Roles = new List<Role>();
        }

        [InverseProperty("Members")]
        public virtual List<Client> Clients { get; set; }

        /// <summary>
        ///     Date when the External Member was created
        /// </summary>
        public DateTime Created { get; }

        /// <summary>
        ///     External member records may contain additional metadata (e.g. BioIQ's ProgramCode)
        /// </summary>
        public virtual List<ExternalMemberExtension> Extensions { get; set; }

        [Key]
        public int ExternalMemberID { get; set; }

        /// <summary>
        ///     The identity of the member in the external system
        /// </summary>
        [Index("IDPID"), MaxLength(25), Required]
        public string IDPID { get; set; }

        /// <summary>
        ///     Timestamp of last login attempt by this user
        /// </summary>
        public DateTime LastLogin { get; set; }

        /// <summary>
        ///     The identity of the linked Member account in the eDoc4u system
        /// </summary>
        public int MemberID { get; set; }

        /// <summary>
        ///     The partner who we are linked to
        /// </summary>
        public PartnerType Partner { get; set; }

        public virtual List<Role> Roles { get; set; }

        /// <summary>
        ///     The ID of the SSO partner if this is an SSO relationship (it may not be : Allscripts, for example)
        /// </summary>
        public int SSOPartnerID { get; set; }
    }

    public enum PartnerType
    {
        Allscripts = 10,
        NavMD = 20,
        BioIQ = 30
    }
}