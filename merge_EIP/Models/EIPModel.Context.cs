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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FormModelEntities : DbContext
    {
        public FormModelEntities()
            : base("name=FormModelEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Backlog> Backlog { get; set; }
        public virtual DbSet<BusinessTrip> BusinessTrip { get; set; }
        public virtual DbSet<Calendar> Calendar { get; set; }
        public virtual DbSet<dayOff> dayOff { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Funding> Funding { get; set; }
        public virtual DbSet<gameRecord> gameRecord { get; set; }
        public virtual DbSet<messageBoard> messageBoard { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Position> Position { get; set; }
        public virtual DbSet<punchIn> punchIn { get; set; }
        public virtual DbSet<rePunchin> rePunchin { get; set; }
        public virtual DbSet<workOvertime> workOvertime { get; set; }
        public virtual DbSet<watchCount> watchCount { get; set; }
        public virtual DbSet<tOrder> tOrder { get; set; }
        public virtual DbSet<tOrderDetail> tOrderDetail { get; set; }
        public virtual DbSet<tShop> tShop { get; set; }
    }
}
