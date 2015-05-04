using SiecKin.Model;
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
            SiecKinEntities dc = new SiecKinEntities();
            var query = from s in dc.Sale
                        select s;
            Sala sala = query.ToList().ElementAt(2);
            foreach (Rzad rz in sala.Rzędy)
            {
                Label l = new Label();
                l.Text = rz.id_rzedu.ToString() + "<br/>";
                
                for (int i = 1; i <= rz.liczba_miejsc; i++)
                {
                    Button b = new Button();
                    b.Text = i.ToString();
                    b.Width = 30;
                    b.Height = 30;
                    b.BackColor = Color.White;
                    this.PlaceHolderSala.Controls.Add(b);
                    b.Click += new EventHandler(MiejsceClick);
                }
                this.PlaceHolderSala.Controls.Add(l);

            }

           
        }
        protected void MiejsceClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.BackColor == Color.Green)
                b.BackColor = Color.White;
            else
                b.BackColor = Color.Green;
        }
    }
}