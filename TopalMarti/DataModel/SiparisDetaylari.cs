//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TopalMarti.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class SiparisDetaylari
    {
        public int ID { get; set; }
        public int SatisID { get; set; }
        public int FirmaUrunID { get; set; }
        public int Adet { get; set; }
        public decimal BirimFiyat { get; set; }
        public Nullable<decimal> Tutar { get; set; }
        public bool Silindi { get; set; }
    
        public virtual Firma_Urunler Firma_Urunler { get; set; }
        public virtual Siparisler Siparisler { get; set; }
    }
}