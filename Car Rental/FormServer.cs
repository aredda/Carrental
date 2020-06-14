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
    public partial class FormServer : Form
    {
        public FormServer()
        {
            InitializeComponent();

            this.Load += FormServer_Load;
        }

        void FormServer_Load(object sender, EventArgs e)
        {
            ControlBox = MaximizeBox = false;
            MinimumSize = MaximumSize = Size;
        }

        private void btn_validate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_server.Text.Length == 0)
                    throw new Exception("Please, complete the server name!");

                //Program.context = new RentalEntities(txt_server.Text.Trim());
                Program.context.SaveChanges();
                
                Helper.show("Thank you for your cooperation, you're now ready to go.");

                this.Dispose();
            }
            catch (Exception x)
            {
                Helper.show(x.Message, MessageBoxIcon.Error);
            }
        }
    }
}
