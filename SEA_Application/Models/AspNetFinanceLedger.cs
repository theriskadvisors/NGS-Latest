//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SEA_Application.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AspNetFinanceLedger
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AspNetFinanceLedger()
        {
            this.AspNetClass_FeeType = new HashSet<AspNetClass_FeeType>();
            this.AspNetFeeTypes = new HashSet<AspNetFeeType>();
            this.AspNetStudent_PaymentDetail = new HashSet<AspNetStudent_PaymentDetail>();
        }
    
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Balance { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsGroup { get; set; }
        public Nullable<bool> TakeAble { get; set; }
        public int Head { get; set; }
        public Nullable<double> StartingBalance { get; set; }
        public string ShowIndividual { get; set; }
        public Nullable<int> SessionID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AspNetClass_FeeType> AspNetClass_FeeType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AspNetFeeType> AspNetFeeTypes { get; set; }
        public virtual AspNetFinanceLedger AspNetFinanceLedgers1 { get; set; }
        public virtual AspNetFinanceLedger AspNetFinanceLedger1 { get; set; }
        public virtual AspNetSession AspNetSession { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AspNetStudent_PaymentDetail> AspNetStudent_PaymentDetail { get; set; }
    }
}
