using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace coopv2
{
    public partial class Sign_in : Form
    {
        public Sign_in()
        {
            InitializeComponent();
        }

        MySqlConnection connexion = new MySqlConnection("server=localhost;database=voyage;port=3306;username=root;password=");

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            
            bool vrai = true;

            if (string.IsNullOrEmpty(fnamebox.Text) && string.IsNullOrEmpty(lnamebox.Text) && string.IsNullOrEmpty(contactbox.Text) && string.IsNullOrEmpty(passbox.Text))
            {
                vrai = false;
            }

            if (string.IsNullOrEmpty(fnamebox.Text))
            {
                fnamebox.LineIdleColor = Color.Red;
                panelsession1.Visible = true;
                vrai = false;
            }

            if (string.IsNullOrEmpty(lnamebox.Text))
            {
                lnamebox.LineIdleColor = Color.Red;
                panelsession2.Visible = true;
                vrai = false;
            }

            if (string.IsNullOrEmpty(contactbox.Text))
            {
                contactbox.LineIdleColor = Color.Red;
                panelsession3.Visible = true;
                vrai = false;
            }

            if (string.IsNullOrEmpty(passbox.Text))
            {
                passbox.LineIdleColor = Color.Red;
                panelsession4.Visible = true;
                vrai = false;
            }
            if (vrai != false)
            {
              //  connexion.Open();

              //  string insert = "INSERT into user(firstname,lastname,contact,password) VALUES ( '"+this.fnamebox.Text+"', '"+this.lnamebox.Text+"', '"+this.contactbox.Text+"', '"+this.passbox.Text+"' ) ";
               // using (MySqlCommand cmd = new MySqlCommand (insert, connexion))
              //  {
            //        cmd.ExecuteReader();
              //  }
                lblsession.Visible = true;
                picsession.Visible = true;

                fnamebox.Text = "";
                lnamebox.Text = "";
                contactbox.Text = "";
                passbox.Text = "";
                    

            }
           // connexion.Close();
        }

        private void lnamebox_KeyPress(object sender, KeyPressEventArgs e)
        {
            lnamebox.LineFocusedColor = Color.LightCyan;
            lnamebox.LineIdleColor = Color.DimGray;
            lnamebox.LineMouseHoverColor = Color.CadetBlue;
            lblsession.Visible = false;
            picsession.Visible = false;
            panelsession2.Visible = false;
            lnamebox.ForeColor = Color.White;
        }

        private void contactbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }

            contactbox.LineFocusedColor = Color.LightCyan;
            contactbox.LineIdleColor = Color.DimGray;
            contactbox.LineMouseHoverColor = Color.CadetBlue;
            lblsession.Visible = false;
            picsession.Visible = false;
            panelsession3.Visible = false;
            contactbox.ForeColor = Color.White;

        }

        private void passbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            passbox.LineFocusedColor = Color.LightCyan;
            passbox.LineIdleColor = Color.DimGray;
            passbox.LineMouseHoverColor = Color.CadetBlue;
            panelsession4.Visible = false;
            lblsession.Visible = false;
            picsession.Visible = false;
            passbox.ForeColor = Color.White;
        }

        private void fnamebox_KeyPress(object sender, KeyPressEventArgs e)
        {
            fnamebox.LineFocusedColor = Color.LightCyan;
            fnamebox.LineIdleColor = Color.DimGray;
            fnamebox.LineMouseHoverColor = Color.CadetBlue;
            panelsession1.Visible = false;
            lblsession.Visible = false;
            picsession.Visible = false;
            fnamebox.ForeColor = Color.White;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
