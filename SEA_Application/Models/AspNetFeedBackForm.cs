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
    
    public partial class AspNetFeedBackForm
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AspNetFeedBackForm()
        {
            this.AspNetPTM_ParentFeedback = new HashSet<AspNetPTM_ParentFeedback>();
            this.AspNetPTM_TeacherFeedback = new HashSet<AspNetPTM_TeacherFeedback>();
        }
    
        public int Id { get; set; }
        public string Question { get; set; }
        public Nullable<int> FormFor { get; set; }
        public Nullable<int> SessionID { get; set; }
    
        public virtual AspNetSession AspNetSession { get; set; }
        public virtual AspNetPTMFormRole AspNetPTMFormRole { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AspNetPTM_ParentFeedback> AspNetPTM_ParentFeedback { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AspNetPTM_TeacherFeedback> AspNetPTM_TeacherFeedback { get; set; }
    }
}
