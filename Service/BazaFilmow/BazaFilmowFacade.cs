using SiecKin.Model;
using SiecKin.Service.Film;
using SiecKin.Service.Format;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiecKin.Service.BazaFilmow
{
    public class BazaFilmowFacade
    {
        private BazaFilmowService service;

        public BazaFilmowFacade()
        {
            service = new BazaFilmowService();
        }
		
		public List<Film> WyswietlBaze()
        {
            return service.WyswietlBaze();
        }
					
		 public string ZwrocTytul(int id_filmu)
        {
            return service.ZwrocTytul(id_filmu);
        }
        public string ZwrocRezysera(int id_filmu)
        {
            return service.ZwrocRezysera(id_filmu);
        }
        public string ZwrocGatunek(int id_filmu)
        {
            return service.ZwrocGatunek(id_filmu);
        }
        public string ZwrocKrajProdukcji(int id_filmu)
        {
            return service.ZwrocKrajProdukcji(id_filmu);
        }
        public int ZwrocOgrWiekowe(int id_filmu)
        {
            return service.ZwrocOgrWiekowe(id_filmu);
        }
        public string ZwrocOpis(int id_filmu)
        {
            return service.ZwrocOpis(id_filmu);
        }
		
		public void ZmienInformacje(Film f, int id_filmu, string tytul, string rezyser, string gatunek, string kraj_produkcji,
									int ogr_wiekowe, System.DateTime grany_od, Nullable<System.DateTime> grany_do, string opis )
        {
			service.ZmienInformacje(f, id_filmu, tytul, rezyser, gatunek, kraj_produkcji, ogr_wiekowe, grany_od, grany_do, opis);
		}
		public void ZmienId(Film f, int id_filmu) 
		{
			service.ZmienId(f, id_filmu);
		}
		public void ZmienTytul(Film f, string tytul)  
		{
			service.ZmienTytul(f, tytul);
		}
		public void ZmienGatunek(Film f, string gatunek)  
		{
			service.ZmienGatunek(f, gatunek);
		}
		public void ZmienKraj(Film f, string kraj_produkcji
		{
			service.ZmienKraj(f, kraj_produkcji);
		}
		public void ZmienOgr_wiekowe(Film f, int ogr_wiekowe)  
		{
			service.ZmienOgr_wiekowe(f, ogr_wiekowe);
		}
		public void ZmienRozp_emisji(Film f, System.DateTime grany_od)  
		{
			service.ZmienRozp_emisji(f, grany_od);
		}
		public void ZmienZak_emisji(Film f, Nullable<System.DateTime> grany_do) 
		{
			service.ZmienZak_emisji(f, grany_do);
		}
		public void ZmienOpis(Film f, string opis) 
		{
			service.ZmienOpis(f, opis);
		}
		public void UsunFilm(Film f)
        {
            service.UsunFilm(f);
        }
		public void DodajFilm(Film f)
        {
            service.DodajFilm(f);
        }
		public List<Format> WyswietlFormaty()
        {
            return service.WyswietlFormaty();
        }
		public string ZwrocFormat(int id_formatu)
        {
            return service.ZwrocFormat(id_formatu);
        }
		public string ZwrocWer_jezykowa(int id_formatu)
        {
            return service.ZwrocWer_jezykowa(id_formatu);
        }
		public void UsunFormat(Format f)
        {
            service.UsunFormat(f);
        }
		public void DodajFormat(Format f)
        {
            service.DodajFormat(f);
        }
	}
}	
		
		
	
		
		
		
		