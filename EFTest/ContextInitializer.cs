using System;
using System.Data.Entity;

namespace EFTest
{
    public class ContextInitializer : DropCreateDatabaseAlways<ExternalMemberContext>
    {
        /// <summary>
        ///     A method that should be overridden to actually add data to the context for seeding.
        ///     The default implementation does nothing.
        /// </summary>
        /// <param name="context"> The context to seed. </param>
        protected override void Seed(ExternalMemberContext aContext) {
            Client aClient = new Client {
                Name = "Rudd"
            };
            Client aClient2 = new Client {
                Name = "Nelson Schematics"
            };
            Client aClient3 = new Client {
                Name = "Acklen Park Technologies"
            };

            Role aRole = new Role {
                Name = "Admin"
            };
            Role aRole2 = new Role {
                Name = "Admin"
            };
            Role aRole3 = new Role {
                Name = "Coach"
            };
            aContext.Roles.Add(aRole);
            aContext.Roles.Add(aRole2);
            aContext.Roles.Add(aRole3);

            ExternalMember aNewMember = new ExternalMember {
                IDPID = "ASDASF",
                LastLogin = DateTime.Now,
                MemberID = 12312,
                Partner = PartnerType.BioIQ,
                SSOPartnerID = 1
            };
            aNewMember.Extensions.Add(new ExternalMemberExtension {
                Type = WellknownExtension.BioIQProgramCode,
                Value = "Booooo"
            });
            ExternalMemberLoginHistory aHistory = new ExternalMemberLoginHistory {
                ExternalMember = aNewMember,
                Payload = "<Hello/>"
            };

            aClient.Members.Add(aNewMember);
            aClient2.Members.Add(aNewMember);

            ExternalMember aNewMember2 = new ExternalMember {
                IDPID = "{09482390-23457823589}",
                LastLogin = DateTime.Now,
                MemberID = 354353,
                Partner = PartnerType.Allscripts,
                SSOPartnerID = 2
            };
            ExternalMemberLoginHistory aHistory2 = new ExternalMemberLoginHistory {
                ExternalMember = aNewMember2,
                Payload = "<Hello/>"
            };

            aClient3.Members.Add(aNewMember2);

            aContext.LoginHistories.Add(aHistory);
            aContext.LoginHistories.Add(aHistory2);
            aContext.Clients.Add(aClient);
            aContext.Clients.Add(aClient2);
            aContext.Clients.Add(aClient3);

            aNewMember.Roles.Add(aRole);
            aNewMember.Roles.Add(aRole2);
            aNewMember2.Roles.Add(aRole3);

            aClient.Manager = aNewMember;
            aClient2.Manager = aNewMember;
            aClient3.Manager = aNewMember2;
            //aContext.ExternalMembers.Add(aNewMember);
            //aContext.LoginHistories.Add(aHistory);
            aContext.SaveChanges();
            aNewMember.Extensions.Add(new ExternalMemberExtension {
                Type = WellknownExtension.BioIQProgramCode,
                Value = "Yeeeees"
            });
            ExternalMemberLoginHistory aHistory3 = new ExternalMemberLoginHistory {
                ExternalMember = aNewMember,
                Payload = "<Hiya/>"
            };
            aContext.LoginHistories.Add(aHistory3);
            aClient.Manager = aNewMember;
            aClient2.Manager = aNewMember2;
            aContext.SaveChanges();
        }
    }
}