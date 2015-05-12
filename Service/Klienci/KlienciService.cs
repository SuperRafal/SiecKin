using SiecKin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiecKin.Service.Klienci
{
    public partial class KlienciService
    {
        private SiecKinEntities dc;
        public KlienciService()
        {
            dc = new SiecKinEntities();
        }

        public void DodajKlienta(Klient k)
        {
            dc.Klienci.Add(k);
            dc.SaveChanges();
        }
        public void UsunKlienta(Klient k)
        {
            dc.Klienci.Remove(k);
            dc.SaveChanges();
        }
        public void ObliczID(Klient k)
        {
            k.id_klienta = dc.Klienci.Count() + 1;
        }

        public Klient ZwrocKlienta(int id)
        {
            var query = from k in dc.Klienci
                        where k.id_klienta == id
                        select k;
            return query.ToList().ElementAt(0);
        }
        public List<int> ZwrocKlientow()
        {
            var query = from k in dc.Klienci
                        select k.id_klienta;
            return query.ToList();
        }
        public void EdytujDane(Klient k, string e_mail, string haslo, string imie, string nazwisko, string login, string nr_konta, string nr_telefonu)
        {
            k.e_mail = e_mail;
            k.haslo = haslo;
            k.imie = imie;
            k.nazwisko = nazwisko;
            k.login = login;
            k.nr_konta = nr_konta;
            k.nr_telefonu = nr_telefonu;

        }
    }
}