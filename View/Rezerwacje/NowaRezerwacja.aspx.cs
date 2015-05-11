using SiecKin.Model;
using SiecKin.Service.Kina;
using SiecKin.Service.Rezerwacje;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiecKin.View.Rezerwacje
{
    public partial class NowaRezerwacja : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            facade = new RezerwacjeFacade();
            r = facade.NowaRezerwacja();
            
            ListaMiast = facade.ZwrocMiasta();
            if (Page.IsPostBack == false)
            {
                this.DropDownListMiasta.DataSource = this.ListaMiast;
                this.DropDownListMiasta.DataBind();
                this.DropDownListKina.DataSource = facade.AdresyKinWMiescie(this.DropDownListMiasta.SelectedItem.Text);
                this.DropDownListKina.DataBind();
            }

            int i = 0;
            foreach (Button b in this.PlaceHolderDaty.Controls)
            {
                DateTime d = DateTime.Now;
                d = d.AddDays(i);
                //b.Text = d.ToShortDateString();
                b.Text = d.ToShortDateString() + Environment.NewLine + d.DayOfWeek.ToString();
                i++;
                //
                b.Click += new EventHandler(test_click);
            }
            
            
        }

        private RezerwacjeFacade facade;
        private Rezerwacja r;
        private List<string> ListaMiast;
        private List<Seans> ListaSeansow;

        protected void DropDownListMiasta_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.DropDownListKina.DataSource = facade.AdresyKinWMiescie(this.DropDownListMiasta.SelectedItem.Text);
            this.DropDownListKina.DataBind();

        }

        protected void DataClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            //string[] s = b.Text.Split(' ');
            int i = this.PlaceHolderDaty.Controls.IndexOf(b);
            DateTime d = DateTime.Now;
            d = d.AddDays(i);
            //this.Label4.Text = d.ToShortDateString();
            int id = facade.ZwrocKino(this.DropDownListMiasta.SelectedItem.Text, this.DropDownListKina.SelectedItem.Text);
            //this.Label4.Text += "<br />" + id.ToString();
            this.ListaSeansow = facade.SeanseKinoDzien(id, d);
            //this.Label4.Text += "<br />" + this.ListaSeansow.Count.ToString();
            this.PokazSeanse();
        }
        protected void test_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int i = this.PlaceHolderDaty.Controls.IndexOf(b);
            //this.Label4.Text += "<br/> kliknales button nr " + i.ToString();
        }




        protected void ButtonDalej_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/View/Rezerwacje/WyborMiejsca.aspx");
        }
        
        private void PokazSeanse()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Film");
            dt.Columns.Add("Godzina");
            foreach (Seans s in ListaSeansow)
            {
                DataRow dr = dt.NewRow();
                dr["Film"] = s.Film.tytul;
                dr["Godzina"] = s.data_rozpoczecia.ToShortTimeString();
                dt.Rows.Add(dr);
            }
            this.GridView1.DataSource = dt;
           
            this.GridView1.DataBind();
            foreach (GridViewRow r in this.GridView1.Rows)
            {
                CheckBox c = (CheckBox)r.FindControl("CheckBox1");
                
            }

            
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.Label4.Text = "poszlo";
        }
      


    }
}