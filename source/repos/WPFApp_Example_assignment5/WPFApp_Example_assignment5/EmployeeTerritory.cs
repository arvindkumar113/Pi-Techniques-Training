//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPFApp_Example_assignment5
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmployeeTerritory
    {
        public int EmployeeID { get; set; }
        public string TerritoryID { get; set; }
    
        public virtual Territory Territory { get; set; }
    }
}
