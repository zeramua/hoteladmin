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

namespace HotelAdmin
{
    public partial class EditUserType : Form
    {
        DataTable dtuserName;
        public EditUserType()
        {
            InitializeComponent();
        }

        private void EditUserType_Load(object sender, EventArgs e)
        {
            dtuserName = h.myfunDT("SELECT * FROM adminlogin");
            for (int i = 0; i < dtuserName.Rows.Count; i++)
            {
                cmbNameUser.Items.Add(dtuserName.Rows[i][1].ToString());
            }
            cmbNameUser.Text = dtuserName.Rows[0][1].ToString();

            for (int i = 1; i <= 3; i++)
            {
                cmbTypeUser.Items.Add(i.ToString());
            }
        }

        private void btnEditTypeUser_Click(object sender, EventArgs e)
        {
            int countAdm = 0;
            for (int i = 0; i < dtuserName.Rows.Count; i++)
                if (int.Parse(dtuserName.Rows[i][2].ToString()) == 1)
                    countAdm += 1;
            if (countAdm > 1)
            {
                string sqlcmd = "UPDATE adminlogin SET type = '" + cmbTypeUser.Text +
                    "' WHERE Name  = '" + cmbNameUser.Text + "'";
                MySqlConnection con = new MySqlConnection(h.conStr);
                MySqlCommand cmdAdd = new MySqlCommand(sqlcmd, con);
                con.Open();
                cmdAdd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Тип користувача " + cmbNameUser.Text +
                    "'\n успішно змінено");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ви не можете змінити тип користувача " +
                    cmbNameUser.Text + "'!\n  Це єдиний адміністратор!", " Увага ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbTypeUser.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
