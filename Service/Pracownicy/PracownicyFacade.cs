using SiecKin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiecKin.Service.Pracownicy
{
    public partial class PracownicyFacade
    {
        private PracownicyService service;

        public PracownicyFacade()
        {
            service = new PracownicyService();
        }
        public void DodajPracownika(Pracownik p)
        {
            service.DodajPracownika(p);
        }
        public void UsunPracownika(Pracownik p)
        {
            service.UsunPracownika(p);
        }
        public void ObliczID(Pracownik p)
        {
            service.ObliczID(p);
        }
        public Pracownik ZwrocPracownika(int id)
        {
            return service.ZwrocPracownika(id);
        }
        public List<int> ZwrocPracownikow()
        {
            return service.ZwrocPracownikow();
        }
        public void EdytujDane(Pracownik p, string haslo, string imie, string nazwisko, string login)
        {
            service.EdytujDane(p, haslo, imie, nazwisko, login);
        }
    }
}