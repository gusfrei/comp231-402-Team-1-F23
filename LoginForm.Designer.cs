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
            logn_signup_btn = new Button();
            SuspendLayout();
            // 
            // loginbtn
            // 
            loginbtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            loginbtn.Location = new Point(173, 204);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(139, 38);
            loginbtn.TabIndex = 0;
            loginbtn.Text = "Login";
            loginbtn.UseVisualStyleBackColor = true;
            loginbtn.Click += loginbtn_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(30, 80);
            label1.Name = "label1";
            label1.Size = new Size(100, 39);
            label1.TabIndex = 1;
            label1.Text = "User ID";
            // 
            // userIdtbx
            // 
            userIdtbx.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userIdtbx.Location = new Point(136, 80);
            userIdtbx.Name = "userIdtbx";
            userIdtbx.Size = new Size(228, 29);
            userIdtbx.TabIndex = 2;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(30, 141);
            label2.Name = "label2";
            label2.Size = new Size(100, 39);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // pwdtxbx
            // 
            pwdtxbx.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pwdtxbx.Location = new Point(136, 141);
            pwdtxbx.Name = "pwdtxbx";
            pwdtxbx.PasswordChar = '*';
            pwdtxbx.Size = new Size(228, 29);
            pwdtxbx.TabIndex = 4;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(136, 19);
            label3.Name = "label3";
            label3.Size = new Size(160, 39);
            label3.TabIndex = 5;
            label3.Text = "Login Page";
            // 
            // bckbtn
            // 
            bckbtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            bckbtn.Location = new Point(393, 142);
            bckbtn.Name = "bckbtn";
            bckbtn.Size = new Size(139, 38);
            bckbtn.TabIndex = 6;
            bckbtn.Text = "Back";
            bckbtn.UseVisualStyleBackColor = true;
            bckbtn.Click += bckbtn_Click;
            // 
            // logn_signup_btn
            // 
            logn_signup_btn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            logn_signup_btn.Location = new Point(393, 72);
            logn_signup_btn.Name = "logn_signup_btn";
            logn_signup_btn.Size = new Size(139, 38);
            logn_signup_btn.TabIndex = 7;
            logn_signup_btn.Text = "Sign Up";
            logn_signup_btn.UseVisualStyleBackColor = true;
            logn_signup_btn.Click += logn_signup_btn_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(554, 271);
            Controls.Add(logn_signup_btn);
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
        private Button logn_signup_btn;
    }
}