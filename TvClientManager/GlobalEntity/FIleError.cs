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
    
    public partial class FIleError
    {
        public int Id { get; set; }
        public System.DateTime ErrorDate { get; set; }
        public string Details { get; set; }
        public string FileId { get; set; }
    
        public virtual Files Files { get; set; }
    }
}
