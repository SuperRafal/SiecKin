using SiecKin.Model;
using SiecKin.Service.Rezerwacje;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiecKin.View.Rezerwacje
{
    public partial class WyborMiejsca : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            facade = new RezerwacjeFacade();
            
        
            try
            {
                r = (Rezerwacja)Session["rezerwacja"];
                RysujSale(r.Seans.Sala);
            }
            catch
            {
                SiecKinEntities dc = new SiecKinEntities();
                RysujSale(dc.Sale.ToList().ElementAt(0));
            }
            //this.Label1.Text = r.id_rezerwacji.ToString() + " " + r.Seans.Film.tytul + " " + r.Seans.Sala.Kino.ulica + " " + r.id_seansu.ToString();
            // this.Label1.Text = r.id_rezerwacji.ToString();
            this.ButtonDalej.Enabled = false;
            this.Button1.BackColor = Color.Red;
            this.Button2.BackColor = Color.White;
            this.Button2.BackColor = Color.Green;
            this.Button1.Enabled = false;
            this.Button2.Enabled = false;
            this.Button3.Enabled = false;

        }

        private Rezerwacja r;
        private RezerwacjeFacade facade;

        protected void MiejsceClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            foreach (Control c in this.PlaceHolderSala.Controls)
            {
                if (c.GetType() == typeof(Button))
                {
                    Button temp = (Button)c;
                    if (temp != b && temp.BackColor == Color.Green)
                        temp.BackColor = Color.White;
                }
            }
            if (b.BackColor == Color.Green)
            {
                b.BackColor = Color.White;
                this.ButtonDalej.Enabled = false;
            }
            else
            {
                b.BackColor = Color.Green;
                int nr_miejsca = int.Parse(b.Text);
                int nr_przycisku = this.PlaceHolderSala.Controls.IndexOf(b);
                int nr_rzedu = 1;
                int licznik = 1;
                foreach (Control l in this.PlaceHolderSala.Controls)
                {
                    if (l.GetType() == typeof(Label))
                    {
                        licznik++;
                        if (this.PlaceHolderSala.Controls.IndexOf(l) < nr_przycisku)
                            nr_rzedu = licznik;
                        else
                            break;
                    }
                }
                //this.Label2.Text = nr_miejsca.ToString() + " " + nr_rzedu.ToString();
                //facade.UstawMiejsce(r, r.Seans.Sala.Rzędy.ToList().ElementAt(nr_rzedu-1), nr_miejsca);
                //this.Label2.Text += "<br />" + r.nr_miejsca.ToString() + " " + r.Rzad.id_rzedu.ToString();
                this.ButtonDalej.Enabled = true;
            }
            
            
        }

        private void RysujSale(Sala s)
        {
            foreach (Rzad rz in s.Rzędy)
            {
                Label l = new Label();
                l.Text = rz.id_rzedu.ToString() + "<br/>";

                for (int i = 1; i <= rz.liczba_miejsc; i++)
                {
                    Button b = new Button();
                    b.Text = i.ToString();
                    b.Width = 25;
                    b.Height = 25;
                    b.BackColor = Color.White;
                    this.PlaceHolderSala.Controls.Add(b);
                    b.Click += new EventHandler(MiejsceClick);
                }
                this.PlaceHolderSala.Controls.Add(l);

            }
        }
    }
}