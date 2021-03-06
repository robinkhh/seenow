//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace SeeNow.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class announcement_log
    {
        [DisplayName("管理員帳號")]
        [Required(ErrorMessage = "公告編號不可空白")]
        public string manager_id { get; set; }
        [DisplayName("公告編號")]
        [Required(ErrorMessage = "公告編號不可空白")]
        public int id { get; set; }
        [DisplayName("公告標題")]
        [Required(ErrorMessage = "公告編號不可空白")]
        public string title { get; set; }
        [DisplayName("公告內容")]
        public string content { get; set; }
        [DisplayName("釋出時間")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public Nullable<System.DateTime> publish_time { get; set; }
        [DisplayName("優先順序")]
        public Nullable<int> priority { get; set; }
        [DisplayName("異動狀態")]
        public string status { get; set; }
        [DisplayName("異動時間")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public System.DateTime datetime { get; set; }
    
        public virtual announcement announcement { get; set; }
        public virtual manager manager { get; set; }
    }
}
