//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseWorker
{
    using System;
    using System.Collections.Generic;
    
    public partial class Currencies
    {
        public Currencies()
        {
            this.IsMain = 0;
            this.Clients = new HashSet<Clients>();
            this.Payments = new HashSet<Payments>();
        }
    
        public System.Guid Id { get; set; }
        public string IsDelete { get; set; }
        public string CreateDate { get; set; }
        public string ModifiedDate { get; set; }
        public string Title { get; set; }
        public int Code { get; set; }
        public byte IsMain { get; set; }
        public double Cource { get; set; }
    
        public virtual ICollection<Clients> Clients { get; set; }
        public virtual ICollection<Payments> Payments { get; set; }
    }
}
