//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace So_Do_Tu_Duy.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class PROJECT
    {
        public int idProject { get; set; }
        public string note { get; set; }
        public byte[] img { get; set; }
    
        public virtual DRAWOBJ DRAWOBJ { get; set; }
    }
}