//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace main
{
    using System;
    using System.Collections.Generic;
    
    public partial class mobile_images
    {
        public int mobildetaileId { get; set; }
        public string nameproduct { get; set; }
        public byte[] productimg1 { get; set; }
        public byte[] productimg2 { get; set; }
        public byte[] productimg3 { get; set; }
    
        public virtual mobildetaile mobildetaile { get; set; }
    }
}