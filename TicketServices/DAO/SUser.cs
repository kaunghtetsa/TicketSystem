//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TicketServices.DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class SUser
    {
        public SUser()
        {
            this.Bugs = new HashSet<Bug>();
            this.Tickets = new HashSet<Ticket>();
        }
    
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int UserTypeID { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public int UpdatedBy { get; set; }
        public bool Active { get; set; }
    
        public virtual ICollection<Bug> Bugs { get; set; }
        public virtual UserType UserType { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
