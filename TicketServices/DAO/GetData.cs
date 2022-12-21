using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace TicketServices.DAO
{
    public class GetData
    {
        iTicketDBEntities tEntity=new iTicketDBEntities();
        /// <summary>
        /// GetUsers
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Name"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        public List<SUser> GetUsers(int Id, string Name,string Password)
        {
            Password =Password.Trim();
            Password = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(Password));
            List<SUser> iuserList=new List<SUser>();
            if (Id>0)
            {
                iuserList = tEntity.SUsers.Where(x=>x.Id==Id).ToList();
            }
            else
            {
                iuserList = tEntity.SUsers.ToList();
                if(!string.IsNullOrEmpty(Name))
                {
                    iuserList=iuserList.Where(x=>x.UserName.Equals(Name)).ToList();
                }
                if (!string.IsNullOrEmpty(Password))
                {
                    iuserList = iuserList.Where(x => x.Password.Equals(Password)).ToList();
                }
                
            }
            return iuserList;
        }
        /// <summary>
        /// GetBugs
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Name"></param>
        /// <param name="IsResolved"></param>
        /// <returns></returns>
        public List<Bug> GetBugs(int Id, string Name, bool? IsResolved)
        {
            List<Bug> iBugList = new List<Bug>();
            if (Id > 0)
            {
                iBugList = tEntity.Bugs.Where(x => x.Id == Id && x.IsActive == true).ToList();
            }
            else
            {
                iBugList = tEntity.Bugs.Where(x=>x.IsActive==true).ToList();
                if (!string.IsNullOrEmpty(Name))
                {
                    iBugList = iBugList.Where(x => x.Name == Name).ToList();
                }
                if (IsResolved!=null)
                {
                    iBugList = iBugList.Where(x => x.IsResolved == IsResolved).ToList();
                }

            }
            return iBugList;
        }

        /// <summary>
        /// GetTickets
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="TicketTypeId"></param>
        /// <param name="IsResolved"></param>
        /// <returns></returns>
        public List<Ticket> GetTickets(int Id, int? TicketTypeId, bool? IsResolved)
        {
            List<Ticket> iTicket = new List<Ticket>();
            if (Id > 0)
            {
                iTicket = tEntity.Tickets.Where(x => x.Id == Id && x.Active == true).ToList();
            }
            else
            {
                iTicket = tEntity.Tickets.Where(x => x.Active == true).ToList();
                if (TicketTypeId!=null)
                {
                    iTicket = iTicket.Where(x => x.TicketTypeId == TicketTypeId).ToList();
                }
                if (IsResolved != null)
                {
                    iTicket = iTicket.Where(x => x.IsResolved == IsResolved).ToList();
                }

            }
            return iTicket;
        }
    }
}