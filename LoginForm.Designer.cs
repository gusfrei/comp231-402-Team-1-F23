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
            loginbtn.Location = new Point(444, 460);
            loginbtn.Margin = new Padding(4, 5, 4, 5);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(199, 63);
            loginbtn.TabIndex = 0;
            loginbtn.Text = "Login";
            loginbtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(276, 187);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(241, 65);
            label1.TabIndex = 1;
            label1.Text = "User ID";
            // 
            // userIdtbx
            // 
            userIdtbx.Location = new Point(526, 187);
            userIdtbx.Margin = new Padding(4, 5, 4, 5);
            userIdtbx.Multiline = true;
            userIdtbx.Name = "userIdtbx";
            userIdtbx.Size = new Size(324, 62);
            userIdtbx.TabIndex = 2;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(276, 288);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(241, 65);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // pwdtxbx
            // 
            pwdtxbx.Location = new Point(526, 288);
            pwdtxbx.Margin = new Padding(4, 5, 4, 5);
            pwdtxbx.Multiline = true;
            pwdtxbx.Name = "pwdtxbx";
            pwdtxbx.PasswordChar = '*';
            pwdtxbx.Size = new Size(324, 62);
            pwdtxbx.TabIndex = 4;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(406, 35);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(264, 65);
            label3.TabIndex = 5;
            label3.Text = "Login Page";
            // 
            // bckbtn
            // 
            bckbtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            bckbtn.Location = new Point(686, 460);
            bckbtn.Margin = new Padding(4, 5, 4, 5);
            bckbtn.Name = "bckbtn";
            bckbtn.Size = new Size(199, 63);
            bckbtn.TabIndex = 6;
            bckbtn.Text = "Back";
            bckbtn.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1143, 750);
            Controls.Add(bckbtn);
            Controls.Add(label3);
            Controls.Add(pwdtxbx);
            Controls.Add(label2);
            Controls.Add(userIdtbx);
            Controls.Add(label1);
            Controls.Add(loginbtn);
            Margin = new Padding(4, 5, 4, 5);
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