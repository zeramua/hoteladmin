using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelAdmin
{
    public partial class Room : Form
    {
        public Room()
        {
            InitializeComponent();
            KeyPreview = true;
            KeyDown += (s, e) => { if (e.KeyCode == Keys.F && e.Modifiers == Keys.Control) Search.PerformClick(); };
        }
        

        private void Townys_Load(object sender, EventArgs e)
        {
            h.bs1 = new BindingSource();
            h.bs1.DataSource = h.myfunDT("SELECT * FROM sqlist18_2_tor.Room;");
            dataGridView1.DataSource = h.bs1;

            //bindingNavigator1.BindingSource = h.bs1;
            //h.bs1.Sort = "BornYear";
        }

        private void Search_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            label1.Visible = true;
            label1.Text = "Search";
            textBox1.Focus();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            label1.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount-1; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                    {
                        dataGridView1.Rows[i].Selected = true;
                        break;
                    }
                }
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            h.bs1.DataSource = h.myfunDT("SELECT * FROM sqlist18_2_tor.Ski;");
            bindingNavigator1.BindingSource = h.bs1;
            dataGridView1.DataSource = h.bs1;
        }
    }
}
