//Created by Wojciech Bugaj
using SiecKin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiecKin.Service.Seanse
{
    public partial class SeanseService
    {
        private SiecKinEntities dc;

        public SeanseService()
        {
            dc = new SiecKinEntities();
        }

        public System.DateTime ZwrocDate(int year, int month, int day)
        {
            //Wersja wstępna, do kontroli.
            //Przekształca datę podaną jako dzień, miesiąc i rok w 'int' na datę w formacie 'System.DateTime';

            System.DateTime date = new System.DateTime(year, month, day);
            return date;
        }

        public List<int> ZwrocSeanseWszystkie(int kino, System.DateTime data)
        {
            //Zwraca seanse bazując na podanej dacie i kinie
            var query = from s in dc.Seanse
                        where s.id_kina == kino && s.data_rozpoczecia == data
                        select s.id_seansu;
            return query.ToList();

        }
        public List<int> ZwrocSeanseDlaFilmu(int kino, System.DateTime data, int film)
        {
            //Zwraca seanse dla konkretnego filmu bazując na dacie i kinie
            var query = from s in dc.Seanse
                        where s.id_kina == kino && s.data_rozpoczecia == data && s.id_filmu == film
                        select s.id_seansu;
            return query.ToList();

        }

        //Informacyjne
        public int ZwrocIDfilmu(int id_seansu)
        {
            var query = from s in dc.Seanse
                        where s.id_seansu == id_seansu
                        select s.id_filmu;
            return Convert.ToInt32(query);
        }
        public int ZwrocIDsali(int id_seansu)
        {
            var query = from s in dc.Seanse
                        where s.id_seansu == id_seansu
                        select s.id_sali;
            return Convert.ToInt32(query);
        }
        public int ZwrocIDkina(int id_seansu)
        {
            var query = from s in dc.Seanse
                        where s.id_seansu == id_seansu
                        select s.id_kina;
            return Convert.ToInt32(query);
        }
        public System.DateTime ZwrocDateRozpoczecia(int id_seansu)
        {
            var query = from s in dc.Seanse
                        where s.id_seansu == id_seansu
                        select s.data_rozpoczecia;
            return Convert.ToDateTime(query);
        }
        public int ZwrocCzasTrwania(int id_seansu)
        {
            var query = from s in dc.Seanse
                        where s.id_seansu == id_seansu
                        select s.czas_trwania;
            return Convert.ToInt32(query);
        }

    }
}