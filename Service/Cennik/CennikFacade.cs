using SiecKin.Model;
using SiecKin.Service.Cennik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiecKin.Service.Cennik
{
    public class CennikFacade
    {
        public CennikFacade()
        {
            service = new CennikService();
        }

        private CennikService service;

        public List<TypBiletu> WyswietlCennik()
        {
            return service.WyswietlCennik();
        }

        public void ZmienParametry(TypBiletu b, decimal cena, string rodzaj, DateTime obowiazuje_do)
        {
            service.ZmienParametry(b, cena, rodzaj, obowiazuje_do);
        }

        public void ZmienCene(TypBiletu b, decimal cena)
        {
            service.ZmienCene(b, cena);
        }

        public void ZmienRodzaj(TypBiletu b, string rodzaj)
        {
            service.ZmienRodzaj(b, rodzaj);
        }

        public void ZmienDate(TypBiletu b, DateTime obowiazuje_do)
        {
            service.ZmienDate(b, obowiazuje_do);
        }
      

        public void UsunBilet(TypBiletu b)
        {
            service.UsunBilet(b);
        }

        public void DodajBilet(TypBiletu b)
        {
            service.DodajBilet(b);
        }
    }
}