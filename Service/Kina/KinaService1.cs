//Created by Wojciech Bugaj
using SiecKin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiecKin.Service.Kina
{
    public class KinaService1
    {
        private SiecKinEntities dc;

        public KinaService1()
        {
            dc = new SiecKinEntities();
        }

        public int ZwrocKino(string miasto, string adres)
        {
            var query = from k in dc.Kina
                        where k.miejscowosc == miasto && k.ulica == adres
                        select k.id_kina;

            return Convert.ToInt32(query);
        }
    }
}