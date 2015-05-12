using SiecKin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiecKin.Service.Klienci
{
    public partial class KlienciFacade
    {
        private KlienciService service;
        public KlienciFacade()
        {
            service = new KlienciService();
        }

        public void DodajKlienta(Klient k)
        {
            service.DodajKlienta(k);
        }
        public void UsunKlienta(Klient k)
        {
            service.UsunKlienta(k);
        }
        public void ObliczID(Klient k)
        {
            service.ObliczID(k);
        }
        public Klient ZwrocKlienta(int id)
        {
            return service.ZwrocKlienta(id);
        }
        public List<int> ZwrocKlientow()
        {
            return service.ZwrocKlientow();
        }
        public void EdytujDane(Klient k, string e_mail, string haslo, string imie, string nazwisko, string login, string nr_konta, string nr_telefonu)
        {
            service.EdytujDane(k, e_mail, haslo, imie, nazwisko, login, nr_konta, nr_telefonu);
        }

    }
}