//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataBaseTollPlaza.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class center_staff_error
    {
        public int id { get; set; }
        public Nullable<short> staff_id { get; set; }
        public string error_name { get; set; }
        public Nullable<System.DateTime> date_work { get; set; }
        public Nullable<int> session_id { get; set; }
        public Nullable<int> error_id { get; set; }
        public Nullable<decimal> penalty { get; set; }
        public Nullable<decimal> abundant { get; set; }
        public Nullable<int> center_archives_id { get; set; }
        public string lpn { get; set; }
    }
}
