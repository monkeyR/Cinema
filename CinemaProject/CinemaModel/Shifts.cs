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
    
    public partial class Shifts
    {
        public int shiftID { get; set; }
        public int workpositionID { get; set; }
        public int employeeID { get; set; }
        public System.DateTime shiftWeek { get; set; }
        public string typeShift { get; set; }
    
        public virtual Employees Employees { get; set; }
        public virtual Workpositions Workpositions { get; set; }
    }
}
