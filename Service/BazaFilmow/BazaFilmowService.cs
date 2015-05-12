using SiecKin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace SiecKin.Service.BazaFilmow
{
    public class BazaFilmowService
    {
        public BazaFilmowService()
        {
            dc = new SiecKinEntities();
        }
		
		public List<Film> WyswietlBaze()
        {
            var query = from f in dc.BazaFilmow
                        select f;
            return query.ToList();
        }
		
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
		
		public void ZmienInformacje(Film f, int id_filmu, string tytul, string rezyser, string gatunek, string kraj_produkcji,
									int ogr_wiekowe, System.DateTime grany_od, Nullable<System.DateTime> grany_do, string opis )
        {
            f.id_filmu = id_filmu;
            f.tytul = tytul;
			f.rezyser = rezyser;
            f.gatunek = gatunek;
			f.kraj_produkcji = kraj_produkcji;
            f.ogr_wiekowe = ogr_wiekowe;
            f.grany_od = grany_od;
            f.grany_do = grany_do;
			f.opis = opis;
        }
		public void ZmienId(Film f, int id_filmu)   { f.id_filmu = id_filmu; }
		public void ZmienTytul(Film f, string tytul)   { f.tytul = tytul; }	
		public void ZmienGatunek(Film f, string gatunek)   { f.gatunek = gatunek; }
		public void ZmienKraj(Film f, string kraj_produkcji)   { f.tytul = kraj_produkcji; }
		public void ZmienOgr_wiekowe(Film f, int ogr_wiekowe)   { f.ogr_wiekowe = ogr_wiekowe; }
		public void ZmienRozp_emisji(Film f, System.DateTime grany_od)   { f.grany_od = grany_od; }
		public void ZmienZak_emisji(Film f, Nullable<System.DateTime> grany_do)   { f.grany_do = grany_do; }
		public void ZmienOpis(Film f, string opis)   { f.opis = opis; }
		
		public void UsunFilm(Film f)
        {
            dc.Film.Remove(f);
            dc.SaveChanges();
        }
		
		public void DodajFilm(Film f)
        {
            dc.Film.Add(f);
            dc.SaveChanges();
        }
		
		public List<Format> WyswietlFormaty()
        {
            var query = from f in dc.Format
                        select f;
            return query.ToList();
        }
		
		public string ZwrocFormat(int id_formatu)
        {
            var query = from f in dc.Format
                        where f.id_formatu == id_formatu
                        select f.format ;
            return query.ToString();
        }
		
		public string ZwrocWer_jezykowa(int id_formatu)
        {
            var query = from f in dc.Format
                        where f.id_formatu == id_formatu
                        select f.wersja_jezykowa  ;
            return query.ToString();
        }
		
		public void UsunFormat(Format f)
        {
            dc.Format.Remove(f);
            dc.SaveChanges();
        }
		
		public void DodajFormat(Format f)
        {
            dc.Format.Add(f);
            dc.SaveChanges();
        }
	}
}
		
		
		