using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using CoolSms;

using MySql.Data.MySqlClient;


namespace MySqlConnect2
{
    public partial class Signup : Form
    {
        MySqlConnection connection =
            new MySqlConnection("Server=localhost;port=3306;Database=member_manage;Uid=root;Pwd=clfdnjf313!;");
        //서버     //DB이름      // 유저이름  //비밀번호
        
        public Signup()
        {
            InitializeComponent();
        }

        public static Random rnd = new Random();
        public static int serial = rnd.Next(10000, 50001);
        
        SmsApi smsapi = new SmsApi(new SmsApiOptions
        {
            ApiKey = "NCSQKYBJGXJMMJHD",
            ApiSecret = "BFMMEOJTNGXCU96IIDDE2LHVDF6RXM6W",
            DefaultSenderId ="010-4511-9543"
        });

        private void finishbtn_Click(object sender, EventArgs e)
        {
            try//예외 처리
            {
                string insertQuery = "INSERT INTO member_table(Phonenumber, Name, ID, Passwd, Birthday) VALUES('" + phonebox.Text + "','" + namebox.Text +
                    "','" + idbox.Text + "','" + pwdbox.Text + "','" + birthbox.Text + "')";
                connection.Open();
                MySqlCommand command = new MySqlCommand(insertQuery, connection);

                // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻이다
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("회원가입 완료");

                    Thread.Sleep(1000);

                    Close();
                }
                else
                {
                    MessageBox.Show("오류");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();

        }

        private void pwdcheckbtn_Click(object sender, EventArgs e)
        {
            try//예외 처리
            {
                string passwd1 = pwdbox.Text;
                string passwd2 = pwdcheckbox.Text;


                if (pwdbox.Text == pwdcheckbox.Text)
                {
                    MessageBox.Show("일치합니다.");
                }
                else
                {
                    MessageBox.Show("불일치합니다");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void phonecheckbtn_Click(object sender, EventArgs e)
        {
            var body = smsapi.SendMessageAsync(phonebox.Text, "[" + serial.ToString() + "] 테스트 인증번호 문자 입니다.");
        }

        private void pcheckbtn_Click(object sender, EventArgs e)
        {
            if (phonecheckbox.Text == serial.ToString())
            {
                MessageBox.Show("일치합니다.");
            }
            else
            {
                MessageBox.Show("불일치.");
            }

        }
    }
}
