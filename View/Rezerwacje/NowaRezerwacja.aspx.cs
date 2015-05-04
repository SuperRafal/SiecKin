using SiecKin.Model;
using SiecKin.Service.Kina;
using SiecKin.Service.Rezerwacje;
using System;
using System.Collections.Generic;
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
            this.Label4.Text = d.ToShortDateString();
            
        }
        protected void test_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int i = this.PlaceHolderDaty.Controls.IndexOf(b);
            this.Label4.Text += "<br/> kliknales button nr " + i.ToString();
        }
    }
}