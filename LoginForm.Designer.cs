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
            loginbtn = new Button();
            label1 = new Label();
            userIdtbx = new TextBox();
            label2 = new Label();
            pwdtxbx = new TextBox();
            label3 = new Label();
            bckbtn = new Button();
            SuspendLayout();
            // 
            // loginbtn
            // 
            loginbtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            loginbtn.Location = new Point(311, 276);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(139, 38);
            loginbtn.TabIndex = 0;
            loginbtn.Text = "Login";
            loginbtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(193, 112);
            label1.Name = "label1";
            label1.Size = new Size(169, 39);
            label1.TabIndex = 1;
            label1.Text = "User ID";
            // 
            // userIdtbx
            // 
            userIdtbx.Location = new Point(368, 112);
            userIdtbx.Multiline = true;
            userIdtbx.Name = "userIdtbx";
            userIdtbx.Size = new Size(228, 39);
            userIdtbx.TabIndex = 2;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(193, 173);
            label2.Name = "label2";
            label2.Size = new Size(169, 39);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // pwdtxbx
            // 
            pwdtxbx.Location = new Point(368, 173);
            pwdtxbx.Multiline = true;
            pwdtxbx.Name = "pwdtxbx";
            pwdtxbx.PasswordChar = '*';
            pwdtxbx.Size = new Size(228, 39);
            pwdtxbx.TabIndex = 4;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(284, 21);
            label3.Name = "label3";
            label3.Size = new Size(185, 39);
            label3.TabIndex = 5;
            label3.Text = "Login Page";
            // 
            // bckbtn
            // 
            bckbtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            bckbtn.Location = new Point(480, 276);
            bckbtn.Name = "bckbtn";
            bckbtn.Size = new Size(139, 38);
            bckbtn.TabIndex = 6;
            bckbtn.Text = "Back";
            bckbtn.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bckbtn);
            Controls.Add(label3);
            Controls.Add(pwdtxbx);
            Controls.Add(label2);
            Controls.Add(userIdtbx);
            Controls.Add(label1);
            Controls.Add(loginbtn);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
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