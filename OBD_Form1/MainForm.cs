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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            ReserveRecreation formType = new ReserveRecreation();
            formType.ShowDialog();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            ReserveRoom formCountries = new ReserveRoom();
            formCountries.ShowDialog();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Room formTownys = new Room();
            formTownys.ShowDialog();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Ski formVeksylologyUnit = new Ski();
            formVeksylologyUnit.ShowDialog();
        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            
        }


        private void typeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            //if (int.Parse(h.typeuser) > 1 )
            //{
              //  toolStripMenuItem2.Visible = false;
            //}
        }

        private void додатиКористувачаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewUser Af = new AddNewUser();
            Af.ShowDialog();
        }

        private void змінитиКористувачаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditUserPassword Epf = new EditUserPassword();
            Epf.ShowDialog();
        }

        private void змінитиТипToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditUserType Etf = new EditUserType();
            Etf.ShowDialog();
        }

        private void резервнеКопіюванняБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(h.conStr);
            MySqlCommand cmd = new MySqlCommand("copyTablesBD", con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch
            {
                MessageBox.Show("Немає з'єднання з сервером!", "Помилка ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("Резервне копіювання пройшло успішно!");
        }

        private void резервнеВідновленняБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(h.conStr);
            MySqlCommand cmd = new MySqlCommand("copyTablesBD", con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch
            {
                MessageBox.Show("Немає з'єднання з сервером!", "Помилка ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("Резервне відновлення пройшло успішно!");
        }

        private void видалитиКористувачаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteUser Df = new DeleteUser();
            Df.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void countriesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
