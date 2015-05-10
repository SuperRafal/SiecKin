//Created by Wojciech Bugaj
using SiecKin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiecKin.Service.Filmy
{
    public class FilmyFacade
    {
        private FilmyService service;

        public FilmyFacade()
        {
            service = new FilmyService();
        }

        public string ZwrocTytul(int id_seansu)
        {
            return service.ZwrocTytul(id_seansu);
        }
        public string ZwrocRezysera(int id_seansu)
        {
            return service.ZwrocRezysera(id_seansu);
        }
        public string ZwrocGatunek(int id_seansu)
        {
            return service.ZwrocGatunek(id_seansu);
        }
        public string ZwrocKrajProdukcji(int id_seansu)
        {
            return service.ZwrocKrajProdukcji(id_seansu);
        }
        public int ZwrocOgrWiekowe(int id_seansu)
        {
            return service.ZwrocOgrWiekowe(id_seansu);
        }
        public string ZwrocOpis(int id_seansu)
        {
            return service.ZwrocOpis(id_seansu);
        }
    }
}