using SiecKin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiecKin.Service.Cennik
{
    public class CennikService
    {
        public CennikService()
        {
            dc = new SiecKinEntities();
        }

        private SiecKinEntities dc;

        public List<TypBiletu> WyswietlCennik()
        {
            var query = from b in dc.Cennik
                        select b;
            return query.ToList();
        }

        public void ZmienParametry(TypBiletu b, decimal cena, string rodzaj, Nullable<System.DataTime> obowiazuje_do)
        {
            b.cena = cena;
            b.rodzaj = rodzaj;
            b.obowiazuje_od = DateTime.Now;
            b.obowiazuje_do = obowiazuje_do;
        }

        public void ZmienCene(TypBiletu b, decimal cena)
        {
            b.cena = cena;
            b.obowiazuje_od = DateTime.Now;
        }

        public void ZmienRodzaj(TypBiletu b, string rodzaj)
        {
            b.rodzaj = rodzaj;
            b.obowiazuje_od = DateTime.Now;
        }

        public void ZmienDate(TypBiletu b, Nullable<System.DataTime> obowiazuje_do)
        {
            b.obowiazuje_do = obowiazuje_do;
            b.obowiazuje_od = DateTime.Now;
        }
      

        public void UsunBilet(TypBiletu b)
        {
            dc.Cennik.Remove(b);
            dc.SaveChanges();
        }

        public void DodajBilet(TypBiletu b)
        {
            dc.Cennik.Add(b);
            dc.SaveChanges();
        }
    }
}