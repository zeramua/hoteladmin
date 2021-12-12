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
    public partial class Type_Editing : Form
    {
        public Type_Editing()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Replace_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE sqlist18_2_tor.ReserveRecreation SET " + Set.Text + " WHERE " + Where.Text;
            if (MessageBox.Show("Ви впевненні , що хочете змінити дані?", "Заміна", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (MySqlConnection con = new MySqlConnection(h.conStr))
                {
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Редагування пройшло успішно");
                }
            }
            this.Close();
        }

        private void Type_Editing_Load(object sender, EventArgs e)
        {

        }
    }
}
