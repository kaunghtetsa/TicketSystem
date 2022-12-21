using System;

namespace TicketServices.DAO
{
    public class UpdateData
    {
        iTicketDBEntities tEntity = new iTicketDBEntities();
        public void UpdateUsers(int Id, string Name, string Password, int UserTypeID, int UpdatedBy)
        {
            Password = Password.Trim();
            Password = System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String(Password));

            SUser iuser = new SUser();
            iuser = tEntity.SUsers.Find(Id);
            iuser.UserName = Name;
            iuser.Password = Password;
            iuser.UserTypeID = UserTypeID;
            iuser.UpdatedBy = UpdatedBy;
            iuser.UpdatedOn = DateTime.Now;
            iuser.Active = true;
            tEntity.SaveChanges();
        }
        public void UpdateBugs(int Id, string Name, string Des, string Summary, int UpdatedBy)
        {
            Bug iBug = new Bug();
            iBug = tEntity.Bugs.Find(Id);
            iBug.Name = Name;
            iBug.Summary = Summary;
            iBug.Description = Des;
            iBug.UpdatedBy = UpdatedBy;
            iBug.UpdatedOn = DateTime.Now;
            iBug.IsResolved = false;
            iBug.IsActive = true;
            tEntity.SaveChanges();
        }

        public void UpdateTickets(int Id, int TicketTypeId, string Des, bool? IsResolved, int UpdatedBy)
        {
            Ticket iTicket = new Ticket();
            iTicket = tEntity.Tickets.Find(Id);
            iTicket.TicketTypeId = TicketTypeId;
            iTicket.Description = Des;
            iTicket.UpdatedBy = UpdatedBy;
            iTicket.UpdatedOn = DateTime.Now;
            iTicket.IsResolved = false;
            iTicket.Active = true;
            tEntity.SaveChanges();
        }
    }
}