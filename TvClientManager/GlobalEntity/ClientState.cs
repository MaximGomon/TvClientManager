//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GlobalEntity
{
    using System;
    using System.Collections.Generic;
    
    public partial class ClientState
    {
        public System.Guid Id { get; set; }
        public string IsDelete { get; set; }
        public string CreateDate { get; set; }
        public string ModifiedDate { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
    
        public virtual TvClients Clients { get; set; }
    }
}
