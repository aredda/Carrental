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
    public partial class FormCar 
        : FormMaster
    {
        private Car selected;

        public FormCar()
            : base()
        {
            InitializeComponent();
        }

        protected override void refreshSourceControls()
        {
            base.refreshSourceControls();

            Helper.setupCombo(cmb_model, context.Models.ToList(), "id", "info");
        }

        protected override void onLoadConfiguration()
        {
            base.onLoadConfiguration();

            // Assign the source
            source = context.Cars;
            // Assign the source control
            sourceControl = dgv_cars;

            // Events configuration
            btn_addModel.Click += btn_addModel_Click;
            btn_submit.Click += btn_submit_Click;
            btn_delete.Click += btn_delete_Click;
            dgv_cars.CellDoubleClick += dgv_cars_CellDoubleClick;
        }

        void dgv_cars_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selected = (Car) getSelectedItem();

            txt_matricule.Text = selected.matricule;
            txt_mark.Text = selected.mark;
            txt_mileage.Text = selected.mileage.ToString();
            cmb_model.SelectedItem = selected.Model1;

            btn_submit.Text = "Modifier";

            txt_matricule.Enabled = false;
        }

        void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (Helper.show("Etes-vous sure de supprimer?", MessageBoxIcon.Question, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                    return;

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
                if (txt_matricule.Text.Length * txt_mark.Text.Length * txt_mileage.Text.Length == 0)
                    throw new Exception("Completez tous les informations!");

                Car c = selected == null ? new Car() :  selected;

                c.matricule = txt_matricule.Text;
                c.mark = txt_mark.Text;
                c.mileage = int.Parse (txt_mileage.Text);
                c.model = (int)cmb_model.SelectedValue;

                if (selected == null)
                    source.Add(c);

                refreshSourceControls();

                txt_matricule.Enabled = true;

                btn_submit.Text = "Ajouter";

                selected = null;
            }
            catch (Exception x)
            {
                Helper.show(x.Message, MessageBoxIcon.Warning);
            }
        }

        void btn_addModel_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_nom.Text.Length == 0)
                    throw new Exception("Entrez le nom du model!");

                context.Models.Add(new Model { name = txt_nom.Text, date = dtp_date.Value });

                refreshSourceControls();
            }
            catch (Exception x)
            {
                Helper.show(x.Message, MessageBoxIcon.Warning);
            }
        }
    }
}
