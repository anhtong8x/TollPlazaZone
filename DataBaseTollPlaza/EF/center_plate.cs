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
    
    public partial class center_plate
    {
        public int id { get; set; }
        public string lpn { get; set; }
        public Nullable<byte> classify_type { get; set; }
        public Nullable<decimal> ticket_value { get; set; }
        public string fullimage_filename { get; set; }
        public string plateimage_filename { get; set; }
        public Nullable<bool> isPriority { get; set; }
        public string barcode { get; set; }
        public string classify_profile { get; set; }
        public string owner { get; set; }
        public string address { get; set; }
        public Nullable<System.DateTime> registration_date { get; set; }
        public string registration_number { get; set; }
        public Nullable<int> loading_capacity { get; set; }
        public Nullable<int> seat_capacity { get; set; }
        public Nullable<System.DateTime> validity_start_date { get; set; }
        public Nullable<System.DateTime> validity_end_date { get; set; }
        public string ticket_type { get; set; }
        public Nullable<bool> is_violation { get; set; }
        public string note { get; set; }
        public Nullable<byte> status { get; set; }
        public Nullable<bool> is_display { get; set; }
        public Nullable<System.DateTime> created_Date { get; set; }
        public Nullable<byte> userid { get; set; }
        public Nullable<byte> approver_id { get; set; }
    }
}
