namespace EasyCookingApp
{
    partial class UserAddForm
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
            useradd_create_btn = new Button();
            usadd_username_txt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            usadd_password_txt = new TextBox();
            label3 = new Label();
            usadd_passwrd2_txt = new TextBox();
            useradd_cancel_btn = new Button();
            useradd_remove_btn = new Button();
            useradd_search_btn = new Button();
            SuspendLayout();
            // 
            // useradd_create_btn
            // 
            useradd_create_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            useradd_create_btn.Location = new Point(103, 263);
            useradd_create_btn.Name = "useradd_create_btn";
            useradd_create_btn.Size = new Size(117, 44);
            useradd_create_btn.TabIndex = 0;
            useradd_create_btn.Text = "Save";
            useradd_create_btn.UseVisualStyleBackColor = true;
            useradd_create_btn.Click += useradd_create_btn_Click;
            // 
            // usadd_username_txt
            // 
            usadd_username_txt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            usadd_username_txt.Location = new Point(183, 68);
            usadd_username_txt.Multiline = true;
            usadd_username_txt.Name = "usadd_username_txt";
            usadd_username_txt.Size = new Size(204, 32);
            usadd_username_txt.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(18, 68);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 2;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(18, 123);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // usadd_password_txt
            // 
            usadd_password_txt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            usadd_password_txt.Location = new Point(183, 123);
            usadd_password_txt.Multiline = true;
            usadd_password_txt.Name = "usadd_password_txt";
            usadd_password_txt.PasswordChar = '*';
            usadd_password_txt.Size = new Size(204, 32);
            usadd_password_txt.TabIndex = 3;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(18, 177);
            label3.Name = "label3";
            label3.Size = new Size(155, 23);
            label3.TabIndex = 6;
            label3.Text = "Re-Type Password";
            // 
            // usadd_passwrd2_txt
            // 
            usadd_passwrd2_txt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            usadd_passwrd2_txt.Location = new Point(183, 177);
            usadd_passwrd2_txt.Multiline = true;
            usadd_passwrd2_txt.Name = "usadd_passwrd2_txt";
            usadd_passwrd2_txt.PasswordChar = '*';
            usadd_passwrd2_txt.Size = new Size(204, 32);
            usadd_passwrd2_txt.TabIndex = 5;
            // 
            // useradd_cancel_btn
            // 
            useradd_cancel_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            useradd_cancel_btn.Location = new Point(270, 263);
            useradd_cancel_btn.Name = "useradd_cancel_btn";
            useradd_cancel_btn.Size = new Size(117, 44);
            useradd_cancel_btn.TabIndex = 7;
            useradd_cancel_btn.Text = "Cancel";
            useradd_cancel_btn.UseVisualStyleBackColor = true;
            useradd_cancel_btn.Click += useradd_cancel_btn_Click;
            // 
            // useradd_remove_btn
            // 
            useradd_remove_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            useradd_remove_btn.Location = new Point(459, 168);
            useradd_remove_btn.Name = "useradd_remove_btn";
            useradd_remove_btn.Size = new Size(117, 44);
            useradd_remove_btn.TabIndex = 8;
            useradd_remove_btn.Text = "Remove";
            useradd_remove_btn.UseVisualStyleBackColor = true;
            useradd_remove_btn.Click += useradd_remove_btn_Click;
            // 
            // useradd_search_btn
            // 
            useradd_search_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            useradd_search_btn.Location = new Point(459, 68);
            useradd_search_btn.Name = "useradd_search_btn";
            useradd_search_btn.Size = new Size(117, 44);
            useradd_search_btn.TabIndex = 9;
            useradd_search_btn.Text = "Search";
            useradd_search_btn.UseVisualStyleBackColor = true;
            useradd_search_btn.Click += useradd_search_btn_Click;
            // 
            // UserAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 391);
            Controls.Add(useradd_search_btn);
            Controls.Add(useradd_remove_btn);
            Controls.Add(useradd_cancel_btn);
            Controls.Add(label3);
            Controls.Add(usadd_passwrd2_txt);
            Controls.Add(label2);
            Controls.Add(usadd_password_txt);
            Controls.Add(label1);
            Controls.Add(usadd_username_txt);
            Controls.Add(useradd_create_btn);
            Name = "UserAddForm";
            Text = "UserAddForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button useradd_create_btn;
        private TextBox usadd_username_txt;
        private Label label1;
        private Label label2;
        private TextBox usadd_password_txt;
        private Label label3;
        private TextBox usadd_passwrd2_txt;
        private Button useradd_cancel_btn;
        private Button useradd_remove_btn;
        private Button useradd_search_btn;
    }
}