
//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace yumak
{

using System;
    using System.Collections.Generic;
    
public partial class UretimPlanlama
{

    public int ID { get; set; }

    public Nullable<int> ProjeID { get; set; }

    public Nullable<int> ProjeDetayID { get; set; }

    public string IhtiyacDuyulanOzelTakim { get; set; }

    public Nullable<System.DateTime> OzelTakimlarSiparisTarihi { get; set; }

    public Nullable<System.DateTime> OzelTakimlarTeslimTarihi { get; set; }

    public Nullable<System.DateTime> DenemeUretimTarihi { get; set; }

    public Nullable<System.DateTime> KaliteNumuneOnayTarihi { get; set; }

    public Nullable<bool> TamamlanmaDurumu { get; set; }

}

}
