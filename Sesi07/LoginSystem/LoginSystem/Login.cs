using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginSystem
{
    public partial class Login : Form
    {

        Config db = new Config();
        public Login()
        {
            InitializeComponent();

            db.Connect("userdata");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Logo1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void LB_login_Click(object sender, EventArgs e)
        {
            db.ExecuteSelect("Select * FROM user_info where username ='" + L_username_in.Text + "' and password ='"+ L_password_in.Text+"'");

            if (db.Count() == 1)
            {
                MessageBox.Show("Success You Login As " + db.Result(0, "NAME"));
            }
        }

        private void L_username_in_TextChanged(object sender, EventArgs e)
        {

        }

        private void LB_Regrister_Click(object sender, EventArgs e)
        {
            Regrister regrister = new Regrister();
            regrister.Show();
        }

        private void LB_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
