namespace EasyCookingApp
{
    partial class LoginForm
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
            this.loginbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.userIdtbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pwdtxbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bckbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginbtn
            // 
            this.loginbtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginbtn.Location = new System.Drawing.Point(311, 276);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(139, 38);
            this.loginbtn.TabIndex = 0;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(193, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "User ID";
            // 
            // userIdtbx
            // 
            this.userIdtbx.Location = new System.Drawing.Point(368, 112);
            this.userIdtbx.Multiline = true;
            this.userIdtbx.Name = "userIdtbx";
            this.userIdtbx.Size = new System.Drawing.Size(228, 39);
            this.userIdtbx.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(193, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // pwdtxbx
            // 
            this.pwdtxbx.Location = new System.Drawing.Point(368, 173);
            this.pwdtxbx.Multiline = true;
            this.pwdtxbx.Name = "pwdtxbx";
            this.pwdtxbx.PasswordChar = '*';
            this.pwdtxbx.Size = new System.Drawing.Size(228, 39);
            this.pwdtxbx.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(284, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 39);
            this.label3.TabIndex = 5;
            this.label3.Text = "Login Page";
            // 
            // bckbtn
            // 
            this.bckbtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bckbtn.Location = new System.Drawing.Point(480, 276);
            this.bckbtn.Name = "bckbtn";
            this.bckbtn.Size = new System.Drawing.Size(139, 38);
            this.bckbtn.TabIndex = 6;
            this.bckbtn.Text = "Back";
            this.bckbtn.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bckbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pwdtxbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userIdtbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginbtn);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button loginbtn;
        private Label label1;
        private TextBox userIdtbx;
        private Label label2;
        private TextBox pwdtxbx;
        private Label label3;
        private Button bckbtn;
    }
}