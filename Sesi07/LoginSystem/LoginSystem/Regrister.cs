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
    public partial class Regrister : Form
    {
        Config db = new Config();
        public Regrister()
        {
            InitializeComponent();

            db.Connect("userdata");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Regrister_Load(object sender, EventArgs e)
        {

        }

        private void R_Exit_in_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void R_regrister_in_Click(object sender, EventArgs e)
        {
            string nama = R_name_in.Text;
            string username = R_username_in.Text;
            string password = R_password_in.Text;

            if (nama.Equals("") || username.Equals("") || password.Equals(""))
            {
                R_name_in.Focus();
                MessageBox.Show("Data Kosong !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string message = "Ingin Register Data ?";
            string caption = "Information";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox
            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                db.ExecuteSql("INSERT INTO user_info (NAME,USERNAME,PASSWORD) VALUES ('" + nama + "','" + username + "','" + password + "');");
                MessageBox.Show("Berhasil Register Data...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                R_name_in.Text = "";
                R_username_in.Text = "";
                R_password_in.Text = "";
                this.Close();
            }
            else
            {
                this.Close(); // close the connection setup form
            }
        }

        private void R_name_in_TextChanged(object sender, EventArgs e)
        {

        }

        private void R_username_in_TextChanged(object sender, EventArgs e)
        {

        }

        private void R_password_in_TextChanged(object sender, EventArgs e)
        {

        }

        private void R_login_in_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();

        }
    }
}
