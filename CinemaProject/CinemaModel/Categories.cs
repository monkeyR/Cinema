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
    
    public partial class Categories
    {
        public Categories()
        {
            this.Products = new HashSet<Products>();
            this.Products1 = new HashSet<Products>();
        }
    
        public int categoryID { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public bool mainCat { get; set; }
        public int parentCat { get; set; }
    
        public virtual ICollection<Products> Products { get; set; }
        public virtual ICollection<Products> Products1 { get; set; }
    }
}
