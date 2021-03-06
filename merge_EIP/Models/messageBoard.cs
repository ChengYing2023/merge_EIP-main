//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace merge_EIP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class messageBoard
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public messageBoard()
        {
            this.watchCount = new HashSet<watchCount>();
        }
    
        public int messageboardNumber { get; set; }
        [Display(Name = "員工編號")]
        public string employeeID { get; set; }
        [Display(Name = "姓名")]
        public string employeeName { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd hh:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = "發佈時間")]
        public System.DateTime messageDate { get; set; }
        [Display(Name = "標題")]
        public string messageTitle { get; set; }
        [Display(Name = "內文")]
        public string messageText { get; set; }
        [Display(Name = "狀態")]
        public string State { get; set; }
        [Display(Name = "指定對象")]
        public string assignPerson { get; set; }
        [Display(Name = "指定部門")]
        public string assignDepartment { get; set; }
        [Display(Name = "置頂")]
        public bool goTop { get; set; }
        [Display(Name = "顯示到行事曆")]
        public bool toCalendar { get; set; }

        [Display(Name = "指派時間")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-ddThh:mm}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> toMsgDate { get; set; }

    
        public virtual Employee Employee { get; set; }
        public virtual Employee Employee1 { get; set; }
        public virtual Department Department { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<watchCount> watchCount { get; set; }
    }
}
