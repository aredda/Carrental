using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental
{
    public partial class FormReservation 
        : FormMaster
    {
        private Rental selected;

        public FormReservation() 
            : base()
        {
            InitializeComponent();
        }

        protected override void onLoadConfiguration()
        {
            base.onLoadConfiguration();

            // Assign the source
            source = context.Rentals;
            // Assign the control 
            sourceControl = dgv_rentals;
            // Refresh other controls
            Helper.setupCombo(cmb_client, context.Clients.ToList(), "cin", "full_name");
            Helper.setupCombo(cmb_voiture, context.Cars.ToList(), "matricule", "info");

            dtp_debut.Format = dtp_end.Format = DateTimePickerFormat.Short;

            // Events
            btn_submit.Click += btn_submit_Click;
            btn_delete.Click += btn_delete_Click;
            dgv_rentals.CellDoubleClick += dgv_rentals_CellDoubleClick;
        }

        void dgv_rentals_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selected = (Rental) getSelectedItem();

                dtp_debut.Value = selected.date_from.Value;
                dtp_end.Value = selected.date_to.Value;
                nud_price.Value = selected.price.Value;
                cmb_client.SelectedItem = selected.Client1;
                cmb_voiture.SelectedItem = selected.Car1;

                btn_submit.Text = "Modifier";
            }
            catch (Exception x)
            {
                Helper.show(x.Message, MessageBoxIcon.Warning);
            }
        }

        void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (Helper.show("Etes-vous sure de supprimer cette reservation?", MessageBoxIcon.Question, MessageBoxButtons.YesNo) == DialogResult.Yes)
                    removeSelected();
            }
            catch (Exception x) 
            {
                Helper.show(x.Message, MessageBoxIcon.Warning);
            }
        }

        void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                Rental r = selected == null ? new Rental() : selected;

                r.car = (string) cmb_voiture.SelectedValue;
                r.client = (string) cmb_client.SelectedValue;
                r.date_from = dtp_debut.Value;
                r.date_to = dtp_end.Value;
                r.price = nud_price.Value;

                if (selected == null)
                    source.Add(r);

                refreshSourceControls();

                btn_submit.Text = "Ajouter";

                selected = null;
            }
            catch (Exception x)
            {
                Helper.show(x.Message, MessageBoxIcon.Warning);
            }
        }
    }
}
