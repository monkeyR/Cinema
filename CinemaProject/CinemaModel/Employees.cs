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
    
    public partial class Employees
    {
        public Employees()
        {
            this.Shifts = new HashSet<Shifts>();
            this.Transations = new HashSet<Transations>();
        }
    
        public int employeeID { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public int position { get; set; }
        public Nullable<bool> isFired { get; set; }
        public Nullable<System.DateTime> firedDate { get; set; }
    
        public virtual ICollection<Shifts> Shifts { get; set; }
        public virtual ICollection<Transations> Transations { get; set; }
    }
}
