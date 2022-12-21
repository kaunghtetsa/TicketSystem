using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Xml.Linq;

namespace TicketServices.DAO
{
    public class CreateData
    {
        iTicketDBEntities tEntity=new iTicketDBEntities();
        public void CreateUsers(string Name, string Password, int UserTypeID, int UpdatedBy)
        {
            Password = Password.Trim();
            Password = System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String(Password));

            SUser iuser = new SUser();
            iuser.UserName = Name;
            iuser.Password = Password;
            iuser.UserTypeID = UserTypeID;
            iuser.UpdatedBy = UpdatedBy;
            iuser.UpdatedOn=DateTime.Now;
            iuser.Active = true;
            tEntity.SUsers.Add(iuser);
            tEntity.SaveChanges();
        }
        public void CreateBugs(string Name, string Des,string Summary, int UpdatedBy)
        {
            Bug iBug = new Bug();
            iBug.Name = Name;
            iBug.Summary = Summary;
            iBug.Description = Des;
            iBug.UpdatedBy = UpdatedBy;
            iBug.UpdatedOn = DateTime.Now;
            iBug.IsResolved = false;
            iBug.IsActive = true;
            tEntity.Bugs.Add(iBug);
            tEntity.SaveChanges();
        }

        public void CreateTickets(int TicketTypeId,string Des, bool? IsResolved, int UpdatedBy)
        {
            Ticket iTicket = new Ticket();
            iTicket.TicketTypeId = TicketTypeId;
            iTicket.Description = Des;
            iTicket.UpdatedBy = UpdatedBy;
            iTicket.UpdatedOn = DateTime.Now;
            iTicket.IsResolved = false;
            iTicket.Active = true;
            tEntity.Tickets.Add(iTicket);
            tEntity.SaveChanges();
        }
    }
}