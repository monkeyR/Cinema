//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CinemaModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transations
    {
        public Transations()
        {
            this.TicketSales = new HashSet<TicketSales>();
        }
    
        public int transationID { get; set; }
        public Nullable<int> showID { get; set; }
        public System.DateTime transationDate { get; set; }
    
        public virtual Shows Shows { get; set; }
        public virtual ICollection<TicketSales> TicketSales { get; set; }
    }
}
