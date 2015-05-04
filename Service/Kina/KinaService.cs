using SiecKin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiecKin.Service.Kina
{
    public class KinaService
    {
        private SiecKinEntities dc;

        public KinaService()
        {
            dc = new SiecKinEntities();
        }

        public List<string> ZwrocMiasta()
        {
            var query = from k in dc.Kina
                        select k.miejscowosc;
            //return query.AsEnumerable().Distinct();
            return query.ToList().Distinct().ToList();
        }

        public List<string> AdresyKinWMiescie(string miasto)
        {
            var query = from k in dc.Kina
                        where k.miejscowosc == miasto
                        select k.ulica;
            return query.ToList();
        }
    }
}