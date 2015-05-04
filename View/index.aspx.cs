using SiecKin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiecKin.View
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // stronka korzysta z Master Page dzieki temu modyfkiujemy tylko jednego diva - zawartosc strony, a menu, logo strony itd beda identyczne dla kazdej nowo zrobionej strony, stronke dodajemy jako item Web Form using Master Page
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           // this.Label1.Text = "moze zdazymy :P";
            Sala s = new Sala(); // mamy mapowanie a wiec tak robimy nowa sale, film, seans itd, klasy te znajduja sie w model -> SiecKinModel.edmx->SiecKinModel.tt
            SiecKinEntities dc = new SiecKinEntities(); // !!!! obiekt reprezentujacy baze, jego klasa w  model -> SiecKinModel.edmx->SiecKinModelContext.tt->SiecKinModel.Context.cs
            var query = from x in dc.Sale                           // zapytanie do bazy, jesli w tak napisanym zapytaniu zmodyfikujemy ktorys ze zwroconych obiektow i zrobimy dc.SaveChanges() to zmodyfikuje sie on rowniez w bazie
                        where x.id_kina == 1 && x.id_sali == 10
                        select x;
           s = query.ToList().ElementAt(0);  // przypisanie do obiektu klasy Sala obiektu zwroconego przez zapytanie; query.AsEnumerable().ElementAt(0) moze tez byc
            //this.Label1.Text = s.Kino.miejscowosc;
           //s.id_sali = 11;
          //  s.id_kina = 1;
           // s.ilosc_rzedow = 8;
           
          //  dc.Sale.Add(s); // tak dodajemy obiekt do tabelki
            //dc.Sale.Remove(s); // a tak go usuwamy
          //dc.SaveChanges(); // ale zeby to dzialalo musimy potwierdzic zmiany
           
           this.Label1.Text = s.Kino.miejscowosc + ' ' + s.Kino.ulica;
           
            this.GridView1.DataSource = dc.Sale.ToList(); // wazna kontrolka; przypisanie do niej zawartosci tabelki Sale; !! musi byc .ToList()
            this.GridView1.DataBind(); // to tez musi byc zeby kontrolka wyswietlala dane
            
        }
    }
}