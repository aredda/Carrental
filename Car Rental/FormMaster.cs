using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental
{
    public partial class FormMaster
        : Form
    {
        protected RentalEntities context;

        protected DataGridView sourceControl;
        protected DbSet source;

        public FormMaster()
        {
            InitializeComponent();
        }

        void FormMaster_Load(object sender, EventArgs e)
        {
            CenterToScreen();

            MaximizeBox = false;
            MaximumSize = MinimumSize = Size;

            // Complete the configuration
            onLoadConfiguration();
            // Refresh all
            refreshSourceControls();
        }

        /// <summary>
        /// This method shall be overwritten in children, you need to specify the source
        /// </summary>
        protected virtual void onLoadConfiguration()
        {
            context = Program.context;
        }

        protected object getSelectedItem()
        {
            if (sourceControl == null)
                throw new Exception("sourceControl (DataGridView) is not assigned!");

            if (source == null)
                throw new Exception("source (DbSet) is not assigned!");

            return getItems()[sourceControl.CurrentRow.Index];
        }

        protected List<object> getItems()
        {
            List<object> items = new List<object>();

            foreach (object i in source)
                items.Add(i);

            return items;
        }

        protected virtual void refreshSourceControls()
        {
            // Save
            context.SaveChanges();

            if (sourceControl == null)
                throw new Exception("DGV IS NULL");

            // Referesh controls
            sourceControl.DataSource = getItems();
        }

        protected virtual void insert(object entity)
        {
            // Add entity
            source.Add(entity);
            // Reload
            refreshSourceControls();
        }

        protected virtual void removeSelected()
        {
            // Remove the selected row
            source.Remove(getSelectedItem());
            // Reload 
            refreshSourceControls();
        }
    }
}
