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
    public partial class Type_Insert : Form
    {
        DataGridView dataGridView1;
        public Type_Insert(DataGridView grid)
        {
            InitializeComponent();
            dataGridView1 = grid;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(h.conStr))
            {
                int id, max_id = Int32.Parse(dataGridView1.Rows[0].Cells[0].Value.ToString());
                string unit;


                for (int i = 0; i < dataGridView1.RowCount - 2; i++)
                {

                    string str = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    int temp = Convert.ToInt32(str);

                    if (temp > max_id)
                    {
                        max_id = temp;
                    }
                   
                }

                if (idV.Text == "")
                {
                    id = max_id + 1;
                }
                else if (Int32.Parse(idV.Text) <= max_id)
                {
                    id = max_id + 1;
                }
                else
                {
                    id = Int32.Parse(idV.Text);
                }

                if (VeksylUnit.Text == "") unit = "something"; else unit = VeksylUnit.Text;

                string sql = "INSERT INTO sqlist18_2_tor.ReserveRecreation" +
                    " (idV, Name) VALUES (@V1,@V2)";

                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@V1", id);
                cmd.Parameters.AddWithValue("@V2", unit);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();


                MessageBox.Show("Додавання запису пройшло вдало");

            }
            this.Close();

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Type_Insert_Load(object sender, EventArgs e)
        {

        }
    }
}
