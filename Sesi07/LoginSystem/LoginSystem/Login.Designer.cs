
namespace LoginSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Wellcoming = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LB_Regrister = new System.Windows.Forms.Button();
            this.L_password_in = new System.Windows.Forms.TextBox();
            this.L_username_in = new System.Windows.Forms.TextBox();
            this.L_passoword = new System.Windows.Forms.Label();
            this.LB_exit = new System.Windows.Forms.Button();
            this.LB_login = new System.Windows.Forms.Button();
            this.L_username = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LB_Regrister);
            this.panel1.Controls.Add(this.L_password_in);
            this.panel1.Controls.Add(this.L_username_in);
            this.panel1.Controls.Add(this.L_passoword);
            this.panel1.Controls.Add(this.LB_exit);
            this.panel1.Controls.Add(this.LB_login);
            this.panel1.Controls.Add(this.L_username);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 473);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(484, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 45);
            this.label3.TabIndex = 8;
            this.label3.Text = "LOGIN :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.Wellcoming);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(349, 473);
            this.panel2.TabIndex = 10;
            // 
            // Wellcoming
            // 
            this.Wellcoming.AutoSize = true;
            this.Wellcoming.BackColor = System.Drawing.Color.Transparent;
            this.Wellcoming.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wellcoming.ForeColor = System.Drawing.Color.Red;
            this.Wellcoming.Location = new System.Drawing.Point(89, 50);
            this.Wellcoming.Name = "Wellcoming";
            this.Wellcoming.Size = new System.Drawing.Size(174, 45);
            this.Wellcoming.TabIndex = 7;
            this.Wellcoming.Text = "OCBC SSO";
            this.Wellcoming.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Wellcoming.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(85, 171);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 232);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(477, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Create Accout With Us ? Click ";
            this.label2.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // LB_Regrister
            // 
            this.LB_Regrister.BackColor = System.Drawing.Color.Orange;
            this.LB_Regrister.Location = new System.Drawing.Point(710, 337);
            this.LB_Regrister.Name = "LB_Regrister";
            this.LB_Regrister.Size = new System.Drawing.Size(95, 35);
            this.LB_Regrister.TabIndex = 8;
            this.LB_Regrister.Text = "Regrister";
            this.LB_Regrister.UseVisualStyleBackColor = false;
            this.LB_Regrister.Click += new System.EventHandler(this.LB_Regrister_Click);
            // 
            // L_password_in
            // 
            this.L_password_in.Location = new System.Drawing.Point(607, 187);
            this.L_password_in.Name = "L_password_in";
            this.L_password_in.Size = new System.Drawing.Size(198, 26);
            this.L_password_in.TabIndex = 6;
            // 
            // L_username_in
            // 
            this.L_username_in.Location = new System.Drawing.Point(607, 139);
            this.L_username_in.Name = "L_username_in";
            this.L_username_in.Size = new System.Drawing.Size(198, 26);
            this.L_username_in.TabIndex = 5;
            this.L_username_in.TextChanged += new System.EventHandler(this.L_username_in_TextChanged);
            // 
            // L_passoword
            // 
            this.L_passoword.AutoSize = true;
            this.L_passoword.Location = new System.Drawing.Point(488, 193);
            this.L_passoword.Name = "L_passoword";
            this.L_passoword.Size = new System.Drawing.Size(90, 20);
            this.L_passoword.TabIndex = 3;
            this.L_passoword.Text = " Password :";
            this.L_passoword.Click += new System.EventHandler(this.label2_Click);
            // 
            // LB_exit
            // 
            this.LB_exit.BackColor = System.Drawing.Color.IndianRed;
            this.LB_exit.ForeColor = System.Drawing.SystemColors.Control;
            this.LB_exit.Location = new System.Drawing.Point(710, 255);
            this.LB_exit.Name = "LB_exit";
            this.LB_exit.Size = new System.Drawing.Size(95, 38);
            this.LB_exit.TabIndex = 2;
            this.LB_exit.Text = "Exit";
            this.LB_exit.UseVisualStyleBackColor = false;
            this.LB_exit.Click += new System.EventHandler(this.LB_exit_Click);
            // 
            // LB_login
            // 
            this.LB_login.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LB_login.Location = new System.Drawing.Point(607, 256);
            this.LB_login.Name = "LB_login";
            this.LB_login.Size = new System.Drawing.Size(95, 38);
            this.LB_login.TabIndex = 1;
            this.LB_login.Text = "Login";
            this.LB_login.UseVisualStyleBackColor = false;
            this.LB_login.Click += new System.EventHandler(this.LB_login_Click);
            // 
            // L_username
            // 
            this.L_username.AutoSize = true;
            this.L_username.Location = new System.Drawing.Point(488, 139);
            this.L_username.Name = "L_username";
            this.L_username.Size = new System.Drawing.Size(91, 20);
            this.L_username.TabIndex = 0;
            this.L_username.Text = "Username :";
            this.L_username.Click += new System.EventHandler(this.button3_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 472);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label L_username;
        private System.Windows.Forms.Label L_passoword;
        private System.Windows.Forms.Button LB_exit;
        private System.Windows.Forms.Button LB_login;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Wellcoming;
        private System.Windows.Forms.TextBox L_password_in;
        private System.Windows.Forms.TextBox L_username_in;
        private System.Windows.Forms.Button LB_Regrister;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
    }
}

