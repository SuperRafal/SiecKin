using SiecKin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiecKin.Service.Pracownicy
{
    public partial class PracownicyService
    {
        private SiecKinEntities dc;
        public PracownicyService()
        {
            dc = new SiecKinEntities();
        }
        public void DodajPracownika(Pracownik p)
        {
            dc.Pracownicy.Add(p);
            dc.SaveChanges();
        }
        public void UsunPracownika(Pracownik p)
        {
            dc.Pracownicy.Remove(p);
            dc.SaveChanges();
        }
        public void ObliczID(Pracownik p)
        {
            p.id_pracownika = dc.Pracownicy.Count() + 1;
        }
        public Pracownik ZwrocPracownika(int id)
        {
            var query = from p in dc.Pracownicy
                        where p.id_pracownika == id
                        select p;
            return query.ToList().ElementAt(0);
        }
        public List<int> ZwrocPracownikow()
        {
            var query = from p in dc.Pracownicy
                        select p.id_pracownika;
            return query.ToList();
        }
        public void EdytujDane(Pracownik p,string haslo,string imie,string nazwisko,string login)
        {
            p.haslo = haslo;
            p.imie = imie;
            p.nazwisko = nazwisko;
            p.login = login;
        }
    }
}