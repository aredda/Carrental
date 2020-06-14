using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace Car_Rental
{
    public partial class FormClient 
        : FormMaster
    {
        private Client selected;

        public FormClient()
            : base()
        {
            InitializeComponent();
        }

        protected override void onLoadConfiguration()
        {
            base.onLoadConfiguration();

            // Assign the source
            source = context.Clients;
            // Assign the source control
            sourceControl = dgv_clients;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            Client c = selected;

            if (selected == null)
                c = new Client();

            c.cin = txt_cin.Text;
            c.first_name = txt_prenom.Text;
            c.last_name = txt_nom.Text;
            c.email = txt_mail.Text;
            c.telephone = txt_mobile.Text;
            c.adresse = txt_adresse.Text;

            if (selected == null)
                source.Add(c);

            refreshSourceControls();

            txt_cin.Enabled = true;

            btn_submit.Text = "Ajouter";

            selected = null;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            removeSelected();
        }

        private void dgv_clients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Client c = (Client) getSelectedItem();

            txt_cin.Text = c.cin;
            txt_nom.Text = c.last_name;
            txt_prenom.Text = c.first_name;
            txt_mail.Text = c.email;
            txt_mobile.Text = c.telephone;
            txt_adresse.Text = c.adresse;

            txt_cin.Enabled = false;

            btn_submit.Text = "Modifier";

            selected = c;
        }
    }
}
