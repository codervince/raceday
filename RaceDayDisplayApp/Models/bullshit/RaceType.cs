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
    
    public partial class RaceType
    {
        public RaceType()
        {
            this.Race = new HashSet<Race>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> CountryId { get; set; }
        public Nullable<bool> isGroup { get; set; }
    
        public virtual Country Country { get; set; }
        public virtual ICollection<Race> Race { get; set; }
    }
}
