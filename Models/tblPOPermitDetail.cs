//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZB_FEPMS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblPOPermitDetail
    {
        public tblPOPermitDetail()
        {
            this.Id = Guid.NewGuid();
        }

        public System.Guid Id { get; set; }
        public Nullable<System.Guid> POId { get; set; }
        public Nullable<System.Guid> PermitId { get; set; }
        public Nullable<decimal> AmountBeforePermit { get; set; }
        public Nullable<decimal> AmountAfterPermit { get; set; }
        public Nullable<decimal> AmountInUSDBeforePermit { get; set; }
        public Nullable<decimal> AmountInUSDAfterPermit { get; set; }
        public Nullable<decimal> AmountInBirrBeforePermit { get; set; }
        public Nullable<decimal> AmountInBirrAfterPermit { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
    
        public virtual tblPermit tblPermit { get; set; }
        public virtual tblPermit tblPermit1 { get; set; }
    }
}
