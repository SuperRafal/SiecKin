//Created by Wojciech Bugaj
using SiecKin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiecKin.Service.Filmy
{
    public class FilmyService
    {
        private SiecKinEntities dc;

        public FilmyService()
        {
            dc = new SiecKinEntities();
        }

        //Metody informacyjne

        public string ZwrocTytul(int id_filmu)
        {
            var query = from f in dc.Filmy
                        where f.id_filmu == id_filmu
                        select f.tytul;
            return query.ToString();
        }
        public string ZwrocRezysera(int id_filmu)
        {
            var query = from f in dc.Filmy
                        where f.id_filmu == id_filmu
                        select f.rezyser;
            return query.ToString();
        }
        public string ZwrocGatunek(int id_filmu)
        {
            var query = from f in dc.Filmy
                        where f.id_filmu == id_filmu
                        select f.gatunek;
            return query.ToString();
        }
        public string ZwrocKrajProdukcji(int id_filmu)
        {
            var query = from f in dc.Filmy
                        where f.id_filmu == id_filmu
                        select f.kraj_produkcji;
            return query.ToString();
        }
        public int ZwrocOgrWiekowe(int id_filmu)
        {
            var query = from f in dc.Filmy
                        where f.id_filmu == id_filmu
                        select f.ogr_wiekowe;
            return Convert.ToInt32(query);
        }
        public string ZwrocOpis(int id_filmu)
        {
            var query = from f in dc.Filmy
                        where f.id_filmu == id_filmu
                        select f.opis;
            return query.ToString();
        }
    }
}