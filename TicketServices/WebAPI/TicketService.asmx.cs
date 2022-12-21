using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using TicketServices.DAO;

namespace TicketServices.WebAPI
{
    /// <summary>
    /// Summary description for TicketService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class TicketService : System.Web.Services.WebService
    {
        CreateData cdata =new CreateData();
        UpdateData udata = new UpdateData();
        GetData gdata = new GetData();

        #region create
        [WebMethod]
        public void CreateUsers(string AuthenticationCode, string Name, string Password, int UserTypeID, int UpdatedBy)
        {
            if(AuthenticationCode != "khsiskaunghtetsan123!@#")
            {
                return;
            }
            cdata.CreateUsers(Name, Password, UserTypeID, UpdatedBy);
        }

        [WebMethod]
        public void CreateBugs(string AuthenticationCode, string Name, string Des, string Summary, int UpdatedBy)
        {
            if (AuthenticationCode != "khsiskaunghtetsan123!@#")
            {
                return;
            }
            cdata.CreateBugs(Name, Des, Summary, UpdatedBy);
        }
        [WebMethod]
        public void CreateTickets(string AuthenticationCode, int TicketTypeId, string Des, bool? IsResolved, int UpdatedBy)
        {
            if (AuthenticationCode != "khsiskaunghtetsan123!@#")
            {
                return;
            }
            cdata.CreateTickets(TicketTypeId, Des, IsResolved, UpdatedBy);
        }


        #endregion create

        #region update
        [WebMethod]
        public void UpdateUsers(string AuthenticationCode,int Id, string Name, string Password, int UserTypeID, int UpdatedBy)
        {
            if (AuthenticationCode != "khsiskaunghtetsan123!@#")
            {
                return;
            }
            udata.UpdateUsers(Id,Name, Password, UserTypeID, UpdatedBy);
        }

        [WebMethod]
        public void UpdateBugs(string AuthenticationCode, int Id, string Name, string Des, string Summary, int UpdatedBy)
        {
            if (AuthenticationCode != "khsiskaunghtetsan123!@#")
            {
                return;
            }
            udata.UpdateBugs(Id, Name, Des, Summary, UpdatedBy);
        }
        [WebMethod]
        public void UpdateTickets(string AuthenticationCode, int Id, int TicketTypeId, string Des, bool? IsResolved, int UpdatedBy)
        {
            if (AuthenticationCode != "khsiskaunghtetsan123!@#")
            {
                return;
            }
            udata.UpdateTickets(Id, TicketTypeId, Des, IsResolved, UpdatedBy);
        }

        #endregion create

        #region get
        [WebMethod]
        public void GetUsers(string AuthenticationCode, int Id, string Name, string Password)
        {
            if (AuthenticationCode != "khsiskaunghtetsan123!@#")
            {
                return;
            }
            gdata.GetUsers(Id, Name, Password);
        }

        [WebMethod]
        public void GetBugs(string AuthenticationCode, int Id, string Name, bool? Resolved)
        {
            if (AuthenticationCode != "khsiskaunghtetsan123!@#")
            {
                return;
            }
            gdata.GetBugs(Id, Name, Resolved);
        }
        [WebMethod]
        public void GetTickets(string AuthenticationCode, int Id, int TicketTypeId,bool? IsResolved)
        {
            if (AuthenticationCode != "khsiskaunghtetsan123!@#")
            {
                return;
            }
            gdata.GetTickets(Id, TicketTypeId, IsResolved);
        }

        #endregion create
    }
}
