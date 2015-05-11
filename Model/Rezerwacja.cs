//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SiecKin.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rezerwacja
    {
        public int id_rezerwacji { get; set; }
        public int id_kina { get; set; }
        public int id_sali { get; set; }
        public int id_rzedu { get; set; }
        public int nr_miejsca { get; set; }
        public int id_seansu { get; set; }
        public System.DateTime data_zlozenia { get; set; }
        public Nullable<int> id_klienta { get; set; }
        public Nullable<int> id_pracownika { get; set; }
        public int id_typu_biletu { get; set; }
        public Nullable<System.DateTime> data_odbioru { get; set; }
    
        public virtual Klient Klient { get; set; }
        public virtual Pracownik Pracownik { get; set; }
        public virtual Rzad Rzad { get; set; }
        public virtual Seans Seans { get; set; }
        public virtual TypBiletu TypBiletu { get; set; }
    }
}