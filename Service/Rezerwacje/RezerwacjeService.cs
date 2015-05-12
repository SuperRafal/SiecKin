using SiecKin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiecKin.Service.Rezerwacje
{
    public class RezerwacjeService
    {
        public RezerwacjeService()
        {
            dc = new SiecKinEntities();
        }

        private SiecKinEntities dc;

        public void DodajRezerwacje(Rezerwacja r)
        {
            dc.Rezerwacje.Add(r);
            dc.SaveChanges();
        }

        public void UsunRezerwacje(Rezerwacja r)
        {
            dc.Rezerwacje.Remove(r);
            dc.SaveChanges();
        }
        
        public void WyznaczId(Rezerwacja r)
        {
            r.id_rezerwacji = dc.Rezerwacje.Count() + 1;
        }

        public void OdbierzRezerwacje(Rezerwacja r)
        {
            r.data_odbioru = DateTime.Now;
            dc.SaveChanges();
        }

        public List<Rezerwacja> RezerwacjeNaSeans(int id)
        {
            var query = from r in dc.Rezerwacje
                        where r.id_seansu == id
                        select r;
            return query.ToList();
        }

        public List<Rezerwacja> RezerwacjeUzytkownika(int id)
        {
            var query = from r in dc.Rezerwacje
                        where r.id_klienta == id
                        select r;
            return query.ToList();
        }

        public Rezerwacja ZwrocRezerwacje(int id)
        {
            var query = from r in dc.Rezerwacje
                        where r.id_rezerwacji == id
                        select r;
            return query.ToList().ElementAt(0);
        }

        public void UstawSeans(Rezerwacja r, Seans s)
        {
            r.Seans = s;
            r.id_seansu = s.id_seansu;
            r.id_kina = s.id_kina;
            r.id_sali = s.id_sali;
        }

        public void UstawTypBiletu(Rezerwacja r, TypBiletu t)
        {
            r.TypBiletu = t;
            r.id_typu_biletu = t.id_typu_biletu;
        }

        public void UstawMiejsce(Rezerwacja r, Rzad rz, int m)
        {
            r.nr_miejsca = m;
            r.Rzad = rz;
            r.id_rzedu = rz.id_rzedu;
        }

        public void UstawRezerwujacego(Rezerwacja r, Klient k)
        {
            r.Klient = k;
            r.id_klienta = k.id_klienta;
        }

        public void UstawRezerwujacego(Rezerwacja r, Pracownik p)
        {
            r.Pracownik = p;
            r.id_pracownika = p.id_pracownika;
        }

        public void ZlozRezerwacje(Rezerwacja r)
        {
            r.data_zlozenia = DateTime.Now;
            this.DodajRezerwacje(r);
        }

        public Rezerwacja NowaRezerwacja()
        {
            return new Rezerwacja();
        }




    }
}