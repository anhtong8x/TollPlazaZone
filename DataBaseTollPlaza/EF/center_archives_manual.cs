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
    
    public partial class center_archives_manual
    {
        public int id { get; set; }
        public Nullable<byte> type { get; set; }
        public string lance_id { get; set; }
        public Nullable<int> user_id { get; set; }
        public Nullable<byte> session_id { get; set; }
        public Nullable<System.DateTime> start_boarding_time { get; set; }
        public Nullable<System.DateTime> end_boarding_time { get; set; }
    }
}