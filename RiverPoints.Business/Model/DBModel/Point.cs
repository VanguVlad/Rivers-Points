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
    
    public partial class Point
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int FKRiverID { get; set; }
        public Nullable<int> NextPointId { get; set; }
        public Nullable<int> PreviosPointId { get; set; }
    }
}
