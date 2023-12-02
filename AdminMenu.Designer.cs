namespace EasyCookingApp
{
    partial class AdminMenu
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
            adm_useradd_btn = new Button();
            admn_userrem_btn = new Button();
            admin_recadd_btn = new Button();
            admn_recprm_btn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // adm_useradd_btn
            // 
            adm_useradd_btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            adm_useradd_btn.Location = new Point(144, 87);
            adm_useradd_btn.Name = "adm_useradd_btn";
            adm_useradd_btn.Size = new Size(164, 85);
            adm_useradd_btn.TabIndex = 0;
            adm_useradd_btn.Text = "User Add";
            adm_useradd_btn.UseVisualStyleBackColor = true;
            adm_useradd_btn.Click += adm_useradd_btn_Click;
            // 
            // admn_userrem_btn
            // 
            admn_userrem_btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            admn_userrem_btn.Location = new Point(144, 242);
            admn_userrem_btn.Name = "admn_userrem_btn";
            admn_userrem_btn.Size = new Size(164, 85);
            admn_userrem_btn.TabIndex = 1;
            admn_userrem_btn.Text = "User Remove";
            admn_userrem_btn.UseVisualStyleBackColor = true;
            admn_userrem_btn.Click += admn_userrem_btn_Click;
            // 
            // admin_recadd_btn
            // 
            admin_recadd_btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            admin_recadd_btn.Location = new Point(445, 87);
            admin_recadd_btn.Name = "admin_recadd_btn";
            admin_recadd_btn.Size = new Size(164, 85);
            admin_recadd_btn.TabIndex = 2;
            admin_recadd_btn.Text = "Recipe Add";
            admin_recadd_btn.UseVisualStyleBackColor = true;
            admin_recadd_btn.Click += admin_recadd_btn_Click;
            // 
            // admn_recprm_btn
            // 
            admn_recprm_btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            admn_recprm_btn.Location = new Point(445, 242);
            admn_recprm_btn.Name = "admn_recprm_btn";
            admn_recprm_btn.Size = new Size(164, 85);
            admn_recprm_btn.TabIndex = 3;
            admn_recprm_btn.Text = "Recipe Edit / Remove";
            admn_recprm_btn.UseVisualStyleBackColor = true;
            admn_recprm_btn.Click += admn_recprm_btn_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(320, 9);
            label1.Name = "label1";
            label1.Size = new Size(128, 39);
            label1.TabIndex = 4;
            label1.Text = "Admin Menu";
            // 
            // AdminMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(admn_recprm_btn);
            Controls.Add(admin_recadd_btn);
            Controls.Add(admn_userrem_btn);
            Controls.Add(adm_useradd_btn);
            Name = "AdminMenu";
            Text = "AdminMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button adm_useradd_btn;
        private Button admn_userrem_btn;
        private Button admin_recadd_btn;
        private Button admn_recprm_btn;
        private Label label1;
    }
}