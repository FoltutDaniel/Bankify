//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bankify
{
    using System;
    using System.Collections.Generic;
    
    public partial class LoginAccount
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoginAccount()
        {
            this.ClientAccount = new HashSet<ClientAccount>();
        }
    
        public int login_id { get; set; }
        public string login_username { get; set; }
        public string login_password { get; set; }
        public string account_type { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientAccount> ClientAccount { get; set; }
    }
}
