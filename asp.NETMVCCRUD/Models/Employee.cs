//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace asp.NETMVCCRUD.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Employee
    {
        public int EmployeeID { get; set; }
        [Required(ErrorMessage ="This Field is Required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "This Field is Required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "This Field is Required")]
        public string Position { get; set; }
        public string Office { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<int> Salary { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd")]
        public Nullable<System.DateTime> DateAdded { get; set; }
    }
}
