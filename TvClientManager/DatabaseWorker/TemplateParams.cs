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
    
    public partial class TemplateParams
    {
        public System.Guid Id { get; set; }
        public System.Guid TemplateId { get; set; }
        public System.Guid TypeId { get; set; }
        public string ClientId { get; set; }
        public string Title { get; set; }
    
        public virtual TemplateParamsType TemplateParamsType { get; set; }
        public virtual Templates Templates { get; set; }
        public virtual Clients Clients { get; set; }
    }
}
