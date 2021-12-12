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
using System.Security.Cryptography;

namespace HotelAdmin
{


    public partial class login : Form
    {

        public string[,] matrix;

        public login()
        {
            InitializeComponent();
            textBox1.UseSystemPasswordChar = true;
            
            h.conStr = "server = 193.93.216.145; CharacterSet = cp1251;" + "user = sqlist18_2_tor; database = sqlist18_2_tor; password = sqlist18_tor;";

            DataTable dt = h.myfunDT("select * from adminlogin");

            int count = dt.Rows.Count;

            matrix = new string[count, 4];

            for (int i = 0; i < count; i++)
            {
                matrix[i, 0] = dt.Rows[i].Field<int>("idusers").ToString();
                matrix[i, 1] = dt.Rows[i].Field<string>("nameUser");
                matrix[i, 2] = dt.Rows[i].Field<int>("type").ToString();
                matrix[i, 3] = dt.Rows[i].Field<string>("Password");

                comboBox1.Items.Add(matrix[i, 1]);
            }
            //label3.Text = matrix[0, 1];
            comboBox1.Text = matrix[0, 1];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox2.Text = h.EncryptedPassword(textBox1.Text);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (String.Equals(comboBox1.Text, matrix[i, 1]))
                {
                  //int x = 0;
                 // if (x==0)
                      if (String.Equals(h.EncryptedPassword(textBox1.Text), matrix[i, 3]))
                    {
                        h.typeuser = matrix[i, 2];
                        this.Hide();
                        mainForm f0 = new mainForm();
                        f0.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Введіть правильний пароль"); 
                    }

                }

            }
        }

        private void LogIn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }

    static class h
    {
        public static string conStr { get; set; }
        public static string typeuser { get; set; }
        public static BindingSource bs1 { get; set; }

        public static string curVal0 { get; set; }
        public static string keyName { get; set; }

        public static string pathToFoto { get; set; }

        public static string EncryptedPassword (string s )
        {
            if (string.Compare(s, "null", true) == 0)
            {
                return "NULL";
            }
            byte[] bytes = Encoding.Unicode.GetBytes(s);

            MD5CryptoServiceProvider CSP = new MD5CryptoServiceProvider();

            byte[] byteHash = CSP.ComputeHash(bytes);

            string hash = string.Empty;

            foreach (byte b in byteHash)
            {
                hash += string.Format("{0:x2}", b);
            }

            return hash;
        }

        public static DataTable myfunDT(string sqlStr)
        {
            DataTable dt = new DataTable();

            using (MySqlConnection con = new MySqlConnection(h.conStr))
            {
                MySqlCommand com = new MySqlCommand(sqlStr, con);
                try
                {
                    con.Open();
                    using (MySqlDataReader dr = com.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            dt.Load(dr);
                        }
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return dt;
        }

    }
}
