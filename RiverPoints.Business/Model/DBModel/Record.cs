//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RiverPoints.Business.Model.DBModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Record
    {
        public int Id { get; set; }
        public decimal Speed { get; set; }
        public decimal Diameter { get; set; }
        public decimal volume { get; set; }
        public Nullable<System.DateTime> EnterDate { get; set; }
        public decimal FKUserId { get; set; }
        public Nullable<System.DateTime> TimeSaved { get; set; }
        public Nullable<int> FkPointId { get; set; }
    }
}
