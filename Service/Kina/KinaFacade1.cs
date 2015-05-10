//Created by Wojciech Bugaj
using SiecKin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiecKin.Service.Kina
{
    public class KinaFacade1
    {
        private KinaService1 service;

        public KinaFacade1()
        {
            service = new KinaService1();
        }

        public int ZwrocKino(string miasto, string adres)
        {
            return service.ZwrocKino(miasto, adres);
        }
    }
}