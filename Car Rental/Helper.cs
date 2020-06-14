using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental
{
    public class Helper
    {
        public static void setupCombo(ComboBox cmb, object source, string valueMember = null, string displayMember = null)
        {
            cmb.DataSource = source;
            cmb.ValueMember = valueMember;
            cmb.DisplayMember = displayMember;
        }
        public static T getSelected<T>(ComboBox cmb)
        {
            return (T)cmb.SelectedItem;
        }
        public static DialogResult show(
            string message, 
            MessageBoxIcon boxIcon = MessageBoxIcon.Information, 
            MessageBoxButtons boxButtons = MessageBoxButtons.OK)
        {
            return MessageBox.Show(message, boxIcon.ToString(), boxButtons, boxIcon);
        }

        public static string getServerName()
        {
            StreamReader reader = new StreamReader("serverName.txt");
            string serverName = reader.ReadLine();

            reader.Close();

            return serverName;
        }
        public static void setServerName(string newServerName)
        {
            StreamWriter writer = new StreamWriter("serverName.txt");
            writer.WriteLine(newServerName);
            writer.Close();
        }
    }
}
