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
    public partial class Form1 
        : Form
    {
        private Dictionary<Button, Form> binding;

        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
        }

        void Form1_Load(object sender, EventArgs e)
        {
            CenterToScreen();

            MaximizeBox = false;
            MaximumSize = MinimumSize = Size;

            // Effect
            foreach (Button btn in pnl_menuItems.Controls)
            {
                btn.MouseHover += btn_MouseHover;
                btn.MouseLeave += btn_MouseLeave;
                btn.Click += btn_Click;
            }

            // Binding
            binding = new Dictionary<Button, Form>();
            binding.Add(button1, new FormClient());
            binding.Add(button2, new FormCar());
            binding.Add(button3, new FormReservation());
        }

        void btn_Click(object sender, EventArgs e)
        {
            binding[(Button)sender].ShowDialog();
        }

        void btn_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Color.LightSkyBlue;
        }

        void btn_MouseHover(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Color.FromArgb(38, 38, 38);
        }
    }
}
