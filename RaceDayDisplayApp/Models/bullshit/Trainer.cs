//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RaceDayDisplayApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Trainer
    {
        public Trainer()
        {
            this.Runner = new HashSet<Runner>();
        }
    
        public int Id { get; set; }
        public Nullable<System.Guid> GUID { get; set; }
        public string Fullname { get; set; }
        public Nullable<int> HomeTrackId { get; set; }
    
        public virtual RaceCourse RaceCourse { get; set; }
        public virtual ICollection<Runner> Runner { get; set; }
    }
}
