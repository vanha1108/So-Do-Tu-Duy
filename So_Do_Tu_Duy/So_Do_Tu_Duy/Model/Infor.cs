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
    
    public partial class Infor
    {
        public int ID { get; set; }
        public Nullable<double> LocationX { get; set; }
        public Nullable<double> LocationY { get; set; }
        public Nullable<double> Witdh { get; set; }
        public Nullable<double> Height { get; set; }
        public string Description { get; set; }
    
        public virtual Shape Shape { get; set; }
    }
}
