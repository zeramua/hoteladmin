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
    public partial class DeleteUser : Form
    {
        DataTable dtuserName;

        public DeleteUser()
        {
            InitializeComponent();
        }

        private void DeleteUser_Load(object sender, EventArgs e)
        {
            dtuserName = h.myfunDT("SELECT * fROM adminlogin");

            for (int i = 0; i < dtuserName.Rows.Count; i++)
            {
                cmdNameUser.Items.Add(dtuserName.Rows[i][1].ToString());
            }
            cmdNameUser.Text = dtuserName.Rows[0][1].ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int countAdm = 0;
            for (int i = 0; i < dtuserName.Rows.Count; i++)
                if (int.Parse(dtuserName.Rows[i][2].ToString()) == 1)
                    countAdm += 1;
            if (countAdm > 1)
            {
                string sqlcmd = "DELETE FROM userName " +
                    " WHERE Name = '" + cmdNameUser.Text + "'";
                MySqlConnection con = new MySqlConnection(h.conStr);
                MySqlCommand cmdAdd = new MySqlCommand(sqlcmd, con);
                con.Open();
                cmdAdd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Користувача " + cmdNameUser.Text + "\n успішно видалено!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ви не можете видалити користувача " +
                    cmdNameUser.Text + "!\n   Це єдиний адміністратор!", "Увага",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmdNameUser.Focus();

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
