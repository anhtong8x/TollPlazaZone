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
    
    public partial class station_paramater
    {
        public int id { get; set; }
        public Nullable<byte> station_id { get; set; }
        public string lane_id { get; set; }
        public Nullable<int> user_id { get; set; }
        public Nullable<int> session_current { get; set; }
        public Nullable<int> time_scan_status { get; set; }
        public string com_plc { get; set; }
        public Nullable<int> veconvis_use { get; set; }
        public string camera_lpn_ip { get; set; }
        public Nullable<int> camera_lpn_port { get; set; }
        public string veconvis_id { get; set; }
        public string veconvis_laneid { get; set; }
        public Nullable<int> veconvis_lane_index { get; set; }
        public Nullable<int> veconvis_lpn_index { get; set; }
        public Nullable<int> veconvis_image_index { get; set; }
        public string veconvis_lpn_path { get; set; }
        public string server_lpn_path { get; set; }
        public string dictionary_lpn_path { get; set; }
        public Nullable<int> camera_lane_use { get; set; }
        public string camera_lane_ip { get; set; }
        public Nullable<int> camera_lane_port { get; set; }
        public string camera_lane_user { get; set; }
        public string camera_lane_pass { get; set; }
        public Nullable<int> camera_lane_status { get; set; }
        public string server_lane_path { get; set; }
        public string dictionary_lane_path { get; set; }
        public string board_mesage_ip { get; set; }
        public Nullable<int> board_mesage_port { get; set; }
        public string board_mesage_user { get; set; }
        public string board_mesage_pass { get; set; }
        public string etc_ip { get; set; }
        public string etc_user { get; set; }
        public string etc_pass { get; set; }
        public Nullable<int> etc_port_command { get; set; }
        public Nullable<int> etc_port_status { get; set; }
        public string win_ip { get; set; }
        public string win_led_ip { get; set; }
        public string win_user { get; set; }
        public string win_pass { get; set; }
        public Nullable<int> win_port { get; set; }
        public string wim_ip { get; set; }
        public Nullable<int> wim_port { get; set; }
        public Nullable<byte> created_by { get; set; }
        public Nullable<System.DateTime> created_date { get; set; }
        public string server_lpn_path_backup { get; set; }
        public string server_lane_path_backup { get; set; }
        public string dictionary_lpn_path_backup { get; set; }
        public string dictionary_lane_path_backup { get; set; }
        public string led_com_port { get; set; }
        public string server_user { get; set; }
        public string server_pass { get; set; }
        public string server_drive { get; set; }
        public string backup_server_user { get; set; }
        public string backup_server_pass { get; set; }
        public string backup_server_drive { get; set; }
        public string recog_user { get; set; }
        public string recog_pass { get; set; }
        public string recog_drive { get; set; }
    }
}