//Mateusz Brud part
using SiecKin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiecKin.Service.Seanse
{
    public partial class SeanseService
    {
        public List<Seans> SeanseKinoDzien(int id, DateTime data)
        {
           var query = from s in dc.Seanse
                       where s.id_kina == id && data.Year == s.data_rozpoczecia.Year && data.Month == s.data_rozpoczecia.Month && data.Day == s.data_rozpoczecia.Day 
                       select s;
            return query.ToList();
           

        }
    }
}