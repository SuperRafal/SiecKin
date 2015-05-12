using SiecKin.Model;
using SiecKin.Service.Kina;
using SiecKin.Service.Seanse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiecKin.Service.Rezerwacje
{
    public class RezerwacjeFacade
    {
        public RezerwacjeFacade ()
	    {
            service = new RezerwacjeService();
	    }
        private RezerwacjeService service;

        public void DodajRezerwacje(Rezerwacja r)
        {
            service.DodajRezerwacje(r);
        }

        public void UsunRezerwacje(Rezerwacja r)
        {
            service.UsunRezerwacje(r);
        }

        public void WyznaczId(Rezerwacja r)
        {
            service.WyznaczId(r);
        }

        public void OdbierzRezerwacje(Rezerwacja r)
        {
            service.OdbierzRezerwacje(r);
        }

        public List<Rezerwacja> RezerwacjeNaSeans(int id)
        {
            return service.RezerwacjeNaSeans(id);
        }

        public List<Rezerwacja> RezerwacjeUzytkownika(int id)
        {
            return service.RezerwacjeUzytkownika(id);
        }

        public Rezerwacja ZwrocRezerwacje(int id)
        {
            return service.ZwrocRezerwacje(id);
        }

        public void UstawSeans(Rezerwacja r, Seans s)
        {
            service.UstawSeans(r, s);
        }

        public void UstawTypBiletu(Rezerwacja r, TypBiletu t)
        {
            service.UstawTypBiletu(r, t);
        }

        public void UstawMiejsce(Rezerwacja r, Rzad rz, int m)
        {
            service.UstawMiejsce(r, rz, m);
        }

        public void UstawRezerwujacego(Rezerwacja r, Klient k)
        {
            service.UstawRezerwujacego(r, k);
        }

        public void UstawRezerwujacego(Rezerwacja r, Pracownik p)
        {
            service.UstawRezerwujacego(r, p);
        }

        public void ZlozRezerwacje(Rezerwacja r)
        {
            service.ZlozRezerwacje(r);
        }

        public Rezerwacja NowaRezerwacja()
        {
            return service.NowaRezerwacja();
        }

        public List<string> ZwrocMiasta()
        {
            KinaService s = new KinaService();
            return s.ZwrocMiasta();
        }

        public List<string> AdresyKinWMiescie(string miasto)
        {
            KinaService s = new KinaService();
            return s.AdresyKinWMiescie(miasto);
        }

        public List<Seans> SeanseKinoDzien(int id, DateTime data)
        {
            SeanseService s = new SeanseService();
            return s.SeanseKinoDzien(id, data);
        }

        public int ZwrocKino(string m, string u)
        {
            KinaService s = new KinaService();
            return s.ZwrocKino(m, u);
        }
    }
}