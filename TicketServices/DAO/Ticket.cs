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
    
    public partial class Ticket
    {
        public int Id { get; set; }
        public int TicketTypeId { get; set; }
        public string Description { get; set; }
        public bool IsResolved { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public int UpdatedBy { get; set; }
        public bool Active { get; set; }
    
        public virtual SUser SUser { get; set; }
        public virtual TicketType TicketType { get; set; }
    }
}
