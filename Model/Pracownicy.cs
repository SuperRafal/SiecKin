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
    
    public partial class Pracownik
    {
        public Pracownik()
        {
            this.Rezerwacje = new HashSet<Rezerwacja>();
        }
    
        public int id_pracownika { get; set; }
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public string login { get; set; }
        public string haslo { get; set; }
    
        public virtual ICollection<Rezerwacja> Rezerwacje { get; set; }
    }
}
