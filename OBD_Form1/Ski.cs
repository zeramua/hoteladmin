using System;
using System.Runtime;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

//using Android.Graphics;

namespace HotelAdmin
{
    public partial class Ski : Form
    {
        public Ski()
        {
            InitializeComponent();
        }

        private void VeksylologyUnit_Load(object sender, EventArgs e)
        {
            h.bs1 = new BindingSource();
            h.bs1.DataSource = h.myfunDT("SELECT * FROM sqlist18_2_tor.Ski;");
            bindingNavigator1.BindingSource = h.bs1;
            dataGridView1.DataSource = h.bs1.DataSource;

         
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

        private void VeksylologyUnit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F && e.Modifiers == Keys.Control)
            {
                Search.PerformClick();
            }
        }

        private void btFilter_Click(object sender, EventArgs e)
        {
            if (btFilter.Checked)
            {
                textBox2.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label2.Text = "Input Filter: <ім'я поля> <логічний знак> <значення>:";
                label3.Text = "Enter";
                textBox2.Focus();
            }
            else
            {
                textBox2.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                h.bs1.Filter = "";
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                h.bs1.Filter = textBox2.Text;
                textBox2.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            h.bs1.Filter = textBox2.Text;
            textBox2.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            h.bs1.Filter = textBox2.Text;
            textBox2.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
           

            h.bs1.DataSource = h.myfunDT("SELECT * FROM sqlist18_2_tor.Ski;");
            bindingNavigator1.BindingSource = h.bs1;
            dataGridView1.DataSource = h.bs1;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
            
            h.bs1.DataSource = h.myfunDT("SELECT * FROM sqlist18_2_tor.Ski ");
            bindingNavigator1.BindingSource = h.bs1;
            dataGridView1.DataSource = h.bs1;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
          /*int rIndx = dataGridView1.CurrentCell.RowIndex;
            string imagePath = dataGridView1[3, rIndx].Value.ToString();//Поле з адресою картинки

            if (imagePath != "")
            {
                pictureBox1.Image = Image.FromFile(imagePath);
            }
            else
            {
                pictureBox1.Image = null;
            }*/


        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {

        }
    }
}
