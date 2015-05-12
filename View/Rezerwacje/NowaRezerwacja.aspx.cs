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
            
            ListaMiast = facade.ZwrocMiasta();
            if (Page.IsPostBack == false)
            {
                this.DropDownListMiasta.DataSource = this.ListaMiast;
                this.DropDownListMiasta.DataBind();
                this.DropDownListKina.DataSource = facade.AdresyKinWMiescie(this.DropDownListMiasta.SelectedItem.Text);
                this.DropDownListKina.DataBind();

                data = DateTime.Now;
                Session["data_seansu"] = data;
                //int id = facade.ZwrocKino(this.DropDownListMiasta.SelectedItem.Text, this.DropDownListKina.SelectedItem.Text);
                // this.ListaSeansow = facade.SeanseKinoDzien(id, data);
                this.PokazSeanse();

            }
            else
            {
                try
                {
                    data = (DateTime)Session["data_seansu"];
                }
                catch { }
            }
            
            int i = 0;
            foreach (Button b in this.PlaceHolderDaty.Controls)
            {
                DateTime d = DateTime.Now;
                d = d.AddDays(i);
                b.Text = d.ToShortDateString() + Environment.NewLine + d.DayOfWeek.ToString();
                i++;
            }

     
           this.ButtonDalej.Enabled = false;
           this.Label4.Text = index_seansu.ToString();
            
        }

        private RezerwacjeFacade facade;
        private Rezerwacja r;
        private List<string> ListaMiast;
        private List<Seans> ListaSeansow;
        private int index_seansu;
        private DateTime data;

        protected void DropDownListMiasta_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.DropDownListKina.DataSource = facade.AdresyKinWMiescie(this.DropDownListMiasta.SelectedItem.Text);
            this.DropDownListKina.DataBind();
            this.PokazSeanse();

        }

        protected void DataClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int i = this.PlaceHolderDaty.Controls.IndexOf(b);
            data = DateTime.Now;
            data = data.AddDays(i);
            //int id = facade.ZwrocKino(this.DropDownListMiasta.SelectedItem.Text, this.DropDownListKina.SelectedItem.Text);
            //this.ListaSeansow = facade.SeanseKinoDzien(id, d);
            this.PokazSeanse();
            this.Label4.Text = data.ToShortDateString();
            Session["data_seansu"] = data;
        }

        protected void ButtonDalej_Click(object sender, EventArgs e)
        {
           // r = facade.NowaRezerwacja();
            //this.Label4.Text = index_seansu.ToString();
            //facade.UstawSeans(r, ListaSeansow.ElementAt(index_seansu));
            //Session["rezerwacja"] = r;
            Server.Transfer("~/View/Rezerwacje/WyborMiejsca.aspx");
        }
        
        private void PokazSeanse()
        {
            int id = facade.ZwrocKino(this.DropDownListMiasta.SelectedItem.Text, this.DropDownListKina.SelectedItem.Text);
            this.ListaSeansow = facade.SeanseKinoDzien(id, data);
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


            
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            if (c.Checked == false)
                c.Checked = true;
            index_seansu = -1;
            this.ButtonDalej.Enabled = true;
            foreach (GridViewRow row in this.GridView1.Rows)
            {
                CheckBox ce = (CheckBox)row.FindControl("CheckBox1");
                if (ce != c)

                    ce.Checked = false;
                else
                {
                    index_seansu = row.RowIndex;
                }
                    
                

            }

            r = facade.NowaRezerwacja();
            int id = facade.ZwrocKino(this.DropDownListMiasta.SelectedItem.Text, this.DropDownListKina.SelectedItem.Text);
            this.ListaSeansow = facade.SeanseKinoDzien(id, data);
            facade.UstawSeans(r, ListaSeansow.ElementAt(index_seansu));
            Session["rezerwacja"] = r;
            //this.Label4.Text = index_seansu.ToString();
        }

        protected void ButtonTest_Click(object sender, EventArgs e)
        {
            this.Label4.Text +="<br />"+ index_seansu.ToString();
        }

        protected void DropDownListKina_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PokazSeanse();
        }
      


    }
}