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
    
    public partial class Aspnet_Employee_Session
    {
        public string Id { get; set; }
        public Nullable<int> Emp_Id { get; set; }
        public Nullable<int> Session_Id { get; set; }
    
        public virtual AspNetEmployee AspNetEmployee { get; set; }
        public virtual AspNetSession AspNetSession { get; set; }
    }
}
