//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCproject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Movie
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string MoveDescription { get; set; }
        public int CategoryId { get; set; }
        public bool IsActive { get; set; }
    
        public virtual Category Category { get; set; }
    }
}