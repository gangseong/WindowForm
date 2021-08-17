using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;  //참조로 추가한다

namespace MySqlConnect2
{
    public partial class Signin : Form
    {
        MySqlConnection connection =
        new MySqlConnection("Server=localhost;port=3306;Database=member_manage;Uid=root;Pwd=clfdnjf313!;");
        //서버     //DB이름      // 유저이름  //비밀번호
        public Signin()
        {
            InitializeComponent();
        }

        private void Enter_Button_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string sqlmem = "SELECT * FROM member_table";
                MySqlCommand command1 = new MySqlCommand(sqlmem, connection);               
                MySqlDataReader rdr = command1.ExecuteReader();
               
                while (rdr.Read())
                {
                    string IDValue = rdr.GetString("ID");
                    string PasswdValue = rdr.GetString("Passwd");
                    if((IDBox.Text == IDValue) && (PasswdBox.Text == PasswdValue))
                    {
                        this.Visible = false;
                        Form6 showForm6 = new Form6();
                        showForm6.ShowDialog();
                    }
                    else if ((IDBox.Text == "0220chl") && (PasswdBox.Text == "clfdnjf1"))
                    {

                        MessageBox.Show("로그인 성공");
                    }
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }
        
    }
        
}
