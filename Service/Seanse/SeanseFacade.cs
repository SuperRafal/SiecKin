using SiecKin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiecKin.Service.Seanse
{
    public class SeanseFacade
    {
        private SeanseService service;

        public SeanseFacade()
        {
            service = new SeanseService();
        }
        public System.DateTime ZwrocDate(int year, int month, int day)
        {
            return service.ZwrocDate(year, month, day);
        }
        public List<int> ZwrocSeanseWszystkie(int id_kina, System.DateTime data)
        {
            return service.ZwrocSeanseWszystkie(id_kina, data);
        }
        public List<int> ZwrocSeanseDlaFilmu(int id_kina, System.DateTime data, int id_filmu)
        {
            return service.ZwrocSeanseDlaFilmu(id_kina, data, id_filmu);
        }
        public int ZwrocIDfilmu(int id_seansu)
        {
            return service.ZwrocIDfilmu(id_seansu);
        }
        public int ZwrocIDsali(int id_seansu)
        {
            return service.ZwrocIDsali(id_seansu);
        }
        public int ZwrocIDkina(int id_seansu)
        {
            return service.ZwrocIDkina(id_seansu);
        }
        public System.DateTime ZwrocDateRozpoczecia(int id_seansu)
        {
            return service.ZwrocDateRozpoczecia(id_seansu);
        }
        public int ZwrocCzasTrwania(int id_seansu)
        {
            return service.ZwrocCzasTrwania(id_seansu);
        }
   
    }
}