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

    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            this.Backlog = new HashSet<Backlog>();
            this.BusinessTrip = new HashSet<BusinessTrip>();
            this.Calendar = new HashSet<Calendar>();
            this.dayOff = new HashSet<dayOff>();
            this.Funding = new HashSet<Funding>();
            this.gameRecord = new HashSet<gameRecord>();
            this.messageBoard = new HashSet<messageBoard>();
            this.Order = new HashSet<Order>();
            this.Order1 = new HashSet<Order>();
            this.punchIn = new HashSet<punchIn>();
            this.rePunchin = new HashSet<rePunchin>();
            this.workOvertime = new HashSet<workOvertime>();
            this.messageBoard1 = new HashSet<messageBoard>();
            this.watchCount = new HashSet<watchCount>();
            this.tOrder = new HashSet<tOrder>();
            this.tOrderDetail = new HashSet<tOrderDetail>();
        }
    
        [Display(Name ="員工編號")]
        public string employeeID { get; set; }
        [Display(Name = "姓名")]
        public string Name { get; set; }
        [Display(Name = "性別")]
        public string Gender { get; set; }
        [Display(Name = "部門編號")]
        public string departmentID { get; set; }
        [Display(Name = "職位編號")]
        public string positionID { get; set; }
        [Display(Name = "到職日期")]
        public System.DateTime onBoard { get; set; }
        [Display(Name = "離職日期")]
        public Nullable<System.DateTime> terminationDate { get; set; }
        [Display(Name = "帳號")]
        public string Account { get; set; }
        [Display(Name = "密碼")]
        public string Password { get; set; }
        [Display(Name = "電話")]
        public string Telephone { get; set; }
        [Display(Name = "手機")]
        public string cellPhone { get; set; }
        [Display(Name = "地址")]
        public string Address { get; set; }
        [Display(Name = "緊急聯絡人")]
        public string emergencyContact { get; set; }
        [Display(Name = "緊急聯絡人電話")]
        public string emergencyContactphone { get; set; }


        [Display(Name = "確認密碼")]
        [Required(ErrorMessage = "請輸入確認密碼")]
        [DataType(DataType.Password)]
        public string Confirmpwd { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Backlog> Backlog { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BusinessTrip> BusinessTrip { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Calendar> Calendar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dayOff> dayOff { get; set; }
        public virtual Department Department { get; set; }
        public virtual Position Position { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Funding> Funding { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gameRecord> gameRecord { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<messageBoard> messageBoard { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<punchIn> punchIn { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rePunchin> rePunchin { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<workOvertime> workOvertime { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<messageBoard> messageBoard1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<watchCount> watchCount { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tOrder> tOrder { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tOrderDetail> tOrderDetail { get; set; }
    }
}