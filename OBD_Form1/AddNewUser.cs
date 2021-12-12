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
    public partial class AddNewUser : Form
    {
        DataTable dtuserName;
        bool nuser;

        public AddNewUser()
        {
            InitializeComponent();
        }
        
        private void AddNewUser_Load(object sender, EventArgs e)
        {
            dtuserName = h.myfunDT("SELECT * FROM adminlogin");
        }


        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            if (txtNameUser.Text != "")
            {
                if (txtTypeUser.Text != "")
                {
                    if (String.Equals(txtPassword1User.Text, txtPassword2User.Text))
                    {
                        string sqlcmd = "INSERT INTO adminlogin(nameUser , type , Password)" +
                            "VALUES (@P1 , @P2 , @P3)";
                        MySqlConnection con = new MySqlConnection(h.conStr);
                        MySqlCommand cmdAdd = new MySqlCommand(sqlcmd, con);
                        cmdAdd.Parameters.AddWithValue("@P1", txtNameUser.Text);
                        cmdAdd.Parameters.AddWithValue("@P2", txtTypeUser.Text);
                        cmdAdd.Parameters.AddWithValue("@P3", h.EncryptedPassword(txtPassword1User.Text));
                        con.Open();
                        cmdAdd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Нового користувача " + txtNameUser.Text + " \n успішно додано!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Паролі не співпадають! \nВиправте паролі...",
                            "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPassword1User.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Тип користувача не заповнено! \nВиправте тип доступу ... ",
                        "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTypeUser.Focus();
                }
            }
            else
            {
                MessageBox.Show("Поле Користувач не заповнено! \nВиправте будь ласка ...",
                    "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNameUser.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNameUser_Leave(object sender, EventArgs e)
        {

            nuser = true;
            if (btnExit.Focused)
            {
                this.Close();
            }
            else
            {
                for (int i = 0; i < dtuserName.Rows.Count; i++)
                {
                    if (String.Equals(txtNameUser.Text.Trim(), dtuserName.Rows[i][1].ToString())
                         || (String.Equals(txtNameUser.Text, "")))
                    {
                        nuser = false;
                        break;
                    }
                }
            }
            if (!nuser)
            {
                MessageBox.Show("Ім'я користувача не заповнено або вже існує!", "Увага",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNameUser.Focus();
            }
        }

        private void txtTypeUser_Leave(object sender, EventArgs e)
        {
            int g;
            nuser = true;
            if (btnExit.Focused)
            {
                this.Close();
            }
            else
            {
                if (!int.TryParse(txtTypeUser.Text, out g))
                {
                    nuser = false;
                }
                else if ((int.Parse(txtTypeUser.Text) < 1)
                    || (int.Parse(txtTypeUser.Text) > 3))
                {
                    nuser = false;
                }
            }
            if (!nuser)
            {
                MessageBox.Show("Невірний тип користувача!", "Увага!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTypeUser.Focus();

            }
        }
    }
}
