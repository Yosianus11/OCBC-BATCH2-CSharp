
namespace LoginSystem
{
    partial class Regrister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Regrister));
            this.R_name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.R_login_in = new System.Windows.Forms.Button();
            this.R_Exit_in = new System.Windows.Forms.Button();
            this.R_regrister_in = new System.Windows.Forms.Button();
            this.R_password_in = new System.Windows.Forms.TextBox();
            this.R_username_in = new System.Windows.Forms.TextBox();
            this.R_name_in = new System.Windows.Forms.TextBox();
            this.R_Password = new System.Windows.Forms.Label();
            this.R_username = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // R_name
            // 
            this.R_name.AutoSize = true;
            this.R_name.Location = new System.Drawing.Point(119, 99);
            this.R_name.Name = "R_name";
            this.R_name.Size = new System.Drawing.Size(59, 20);
            this.R_name.TabIndex = 0;
            this.R_name.Text = "Name :";
            this.R_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.R_login_in);
            this.panel1.Controls.Add(this.R_Exit_in);
            this.panel1.Controls.Add(this.R_regrister_in);
            this.panel1.Controls.Add(this.R_password_in);
            this.panel1.Controls.Add(this.R_username_in);
            this.panel1.Controls.Add(this.R_name_in);
            this.panel1.Controls.Add(this.R_Password);
            this.panel1.Controls.Add(this.R_name);
            this.panel1.Controls.Add(this.R_username);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 419);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Do You Have Account ? Click";
            // 
            // R_login_in
            // 
            this.R_login_in.Location = new System.Drawing.Point(373, 337);
            this.R_login_in.Name = "R_login_in";
            this.R_login_in.Size = new System.Drawing.Size(89, 35);
            this.R_login_in.TabIndex = 9;
            this.R_login_in.Text = "Login";
            this.R_login_in.UseVisualStyleBackColor = true;
            this.R_login_in.Click += new System.EventHandler(this.R_login_in_Click);
            // 
            // R_Exit_in
            // 
            this.R_Exit_in.Location = new System.Drawing.Point(373, 273);
            this.R_Exit_in.Name = "R_Exit_in";
            this.R_Exit_in.Size = new System.Drawing.Size(89, 39);
            this.R_Exit_in.TabIndex = 8;
            this.R_Exit_in.Text = "Exit";
            this.R_Exit_in.UseVisualStyleBackColor = true;
            this.R_Exit_in.Click += new System.EventHandler(this.R_Exit_in_Click);
            // 
            // R_regrister_in
            // 
            this.R_regrister_in.Location = new System.Drawing.Point(235, 273);
            this.R_regrister_in.Name = "R_regrister_in";
            this.R_regrister_in.Size = new System.Drawing.Size(95, 39);
            this.R_regrister_in.TabIndex = 7;
            this.R_regrister_in.Text = "Regrister";
            this.R_regrister_in.UseVisualStyleBackColor = true;
            this.R_regrister_in.Click += new System.EventHandler(this.R_regrister_in_Click);
            // 
            // R_password_in
            // 
            this.R_password_in.Location = new System.Drawing.Point(235, 219);
            this.R_password_in.Name = "R_password_in";
            this.R_password_in.Size = new System.Drawing.Size(227, 26);
            this.R_password_in.TabIndex = 6;
            this.R_password_in.TextChanged += new System.EventHandler(this.R_password_in_TextChanged);
            // 
            // R_username_in
            // 
            this.R_username_in.Location = new System.Drawing.Point(235, 155);
            this.R_username_in.Name = "R_username_in";
            this.R_username_in.Size = new System.Drawing.Size(227, 26);
            this.R_username_in.TabIndex = 5;
            this.R_username_in.TextChanged += new System.EventHandler(this.R_username_in_TextChanged);
            // 
            // R_name_in
            // 
            this.R_name_in.Location = new System.Drawing.Point(235, 95);
            this.R_name_in.Name = "R_name_in";
            this.R_name_in.Size = new System.Drawing.Size(227, 26);
            this.R_name_in.TabIndex = 4;
            this.R_name_in.TextChanged += new System.EventHandler(this.R_name_in_TextChanged);
            // 
            // R_Password
            // 
            this.R_Password.AutoSize = true;
            this.R_Password.Location = new System.Drawing.Point(119, 222);
            this.R_Password.Name = "R_Password";
            this.R_Password.Size = new System.Drawing.Size(86, 20);
            this.R_Password.TabIndex = 3;
            this.R_Password.Text = "Password :";
            // 
            // R_username
            // 
            this.R_username.AutoSize = true;
            this.R_username.Location = new System.Drawing.Point(119, 155);
            this.R_username.Name = "R_username";
            this.R_username.Size = new System.Drawing.Size(91, 20);
            this.R_username.TabIndex = 1;
            this.R_username.Text = "Username :";
            this.R_username.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(115, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Regrister";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Regrister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 422);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Regrister";
            this.Text = "Regrister";
            this.Load += new System.EventHandler(this.Regrister_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label R_name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label R_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox R_password_in;
        private System.Windows.Forms.TextBox R_username_in;
        private System.Windows.Forms.TextBox R_name_in;
        private System.Windows.Forms.Button R_login_in;
        private System.Windows.Forms.Button R_Exit_in;
        private System.Windows.Forms.Button R_regrister_in;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label R_Password;
    }
}