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
    public partial class ReserveRecreation : Form
    {
        public ReserveRecreation()
        {
            InitializeComponent();
            KeyPreview = true;
            KeyDown += (s, e) => { if (e.KeyCode == Keys.F && e.Modifiers == Keys.Control) Search.PerformClick(); };
        }

        public void Type_Load(object sender, EventArgs e)
        {

            if (int.Parse(h.typeuser) == 3)
            {
                bindingNavigatorAddNewItem.Visible = false;
                bindingNavigatorDeleteItem.Visible = false;
                Edit.Visible = false;
                dataGridView1.ReadOnly = false;
            }

            h.bs1 = new BindingSource();
            h.bs1.DataSource = h.myfunDT("SELECT * FROM sqlist18_2_tor.ReserveRecreation;");
            bindingNavigator1.BindingSource = h.bs1;
            dataGridView1.DataSource = h.bs1;

            //h.bs1.Sort = "Name";
            //h.bs1.Sort = dataGridView1.Columns[0].Name;
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

        public void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Type_Insert Tf = new Type_Insert(dataGridView1);
            Tf.ShowDialog();

            h.bs1.DataSource = h.myfunDT("SELECT * FROM sqlist18_2_tor.ReserveRecreation;");
            bindingNavigator1.BindingSource = h.bs1;
            dataGridView1.DataSource = h.bs1;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            h.curVal0 = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            h.keyName = dataGridView1.Columns[0].Name;

            Type_Delete Tf = new Type_Delete();
            Tf.ShowDialog();


            h.bs1.DataSource = h.myfunDT("SELECT * FROM sqlist18_2_tor.ReserveRecreation;");
            bindingNavigator1.BindingSource = h.bs1;
            dataGridView1.DataSource = h.bs1;
        }

        private void dataGridView1_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            int curColidx = dataGridView1.CurrentCellAddress.X;
            int curRowidx = dataGridView1.CurrentCellAddress.Y;

            string curColName0 = dataGridView1.Columns[0].Name;
            string curColName = dataGridView1.Columns[curColidx].Name;

            h.curVal0 = dataGridView1[0, curRowidx].Value.ToString();

            string newCurCellVal = e.Value.ToString();

            if (curColName == "idV" || curColName == "Name")
            {
                newCurCellVal = "'" + newCurCellVal + "'";
            }

            string sql = "UPDATE sqlist18_2_tor.ReserveRecreation SET " + curColName + " = " + newCurCellVal +
                "WHERE " + curColName0 + " = " + h.curVal0;

            using (MySqlConnection con = new MySqlConnection(h.conStr))
            {
                MySqlCommand cmd = new MySqlCommand(sql, con);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Type_Editing Tf = new Type_Editing();
            Tf.ShowDialog();
            h.bs1.DataSource = h.myfunDT("SELECT * FROM sqlist18_2_tor.ReserveRecreation");
            bindingNavigator1.BindingSource = h.bs1;
            dataGridView1.DataSource = h.bs1;
        }
    }
}
