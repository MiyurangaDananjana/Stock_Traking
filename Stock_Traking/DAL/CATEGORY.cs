//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Stock_Traking.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class CATEGORY
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public Nullable<bool> isDelete { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
    }
}