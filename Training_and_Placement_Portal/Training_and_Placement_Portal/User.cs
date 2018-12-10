//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Training_and_Placement_Portal
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.Notices = new HashSet<Notice>();
            this.Posts = new HashSet<Post>();
            this.Registers = new HashSet<Register>();
            this.Status = new HashSet<Status>();
        }
    
        public int uid { get; set; }
        public string uuid { get; set; }
        public string fname { get; set; }
        public string mname { get; set; }
        public string lname { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
        public Nullable<System.DateTime> dob { get; set; }
        public Nullable<int> bid { get; set; }
        public string rollno { get; set; }
        public string password { get; set; }
        public Nullable<double> cpi { get; set; }
        public string backlog { get; set; }
        public string address { get; set; }
        public string security_q_a { get; set; }
        public string role { get; set; }
        public string active { get; set; }
        public string batch { get; set; }
        public string ssc { get; set; }
        public string hsc { get; set; }
        public string dtod { get; set; }
        public string interest { get; set; }
        public string imageurl { get; set; }
    
        public virtual Branch Branch { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Notice> Notices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Post> Posts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Register> Registers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Status> Status { get; set; }
    }
}
