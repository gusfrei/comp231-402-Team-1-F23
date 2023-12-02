namespace EasyCookingApp
{
    partial class AddRecipeForm
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
            addrcp_namercp_txt = new TextBox();
            addrcp_stepbstp_txb = new RichTextBox();
            addrcp_catrcp_txt = new TextBox();
            addrcp_creatercp_btn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            addrcp_cancel_btn = new Button();
            addrcp_search_btn = new Button();
            addrcp_edit_btn = new Button();
            addrcp_remove_btn = new Button();
            Menu = new GroupBox();
            addrcp_usercommts_txb = new RichTextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // addrcp_namercp_txt
            // 
            addrcp_namercp_txt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addrcp_namercp_txt.Location = new Point(245, 55);
            addrcp_namercp_txt.Multiline = true;
            addrcp_namercp_txt.Name = "addrcp_namercp_txt";
            addrcp_namercp_txt.Size = new Size(473, 32);
            addrcp_namercp_txt.TabIndex = 0;
            // 
            // addrcp_stepbstp_txb
            // 
            addrcp_stepbstp_txb.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            addrcp_stepbstp_txb.Location = new Point(245, 127);
            addrcp_stepbstp_txb.Name = "addrcp_stepbstp_txb";
            addrcp_stepbstp_txb.Size = new Size(663, 297);
            addrcp_stepbstp_txb.TabIndex = 1;
            addrcp_stepbstp_txb.Text = "";
            // 
            // addrcp_catrcp_txt
            // 
            addrcp_catrcp_txt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addrcp_catrcp_txt.Location = new Point(724, 55);
            addrcp_catrcp_txt.Multiline = true;
            addrcp_catrcp_txt.Name = "addrcp_catrcp_txt";
            addrcp_catrcp_txt.Size = new Size(184, 32);
            addrcp_catrcp_txt.TabIndex = 2;
            // 
            // addrcp_creatercp_btn
            // 
            addrcp_creatercp_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addrcp_creatercp_btn.Location = new Point(28, 67);
            addrcp_creatercp_btn.Name = "addrcp_creatercp_btn";
            addrcp_creatercp_btn.Size = new Size(164, 39);
            addrcp_creatercp_btn.TabIndex = 3;
            addrcp_creatercp_btn.Text = "Create New Recipe ";
            addrcp_creatercp_btn.UseVisualStyleBackColor = true;
            addrcp_creatercp_btn.Click += addrcp_creatercp_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(245, 27);
            label1.Name = "label1";
            label1.Size = new Size(161, 25);
            label1.TabIndex = 4;
            label1.Text = "Name of Recipe: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(724, 27);
            label2.Name = "label2";
            label2.Size = new Size(162, 25);
            label2.TabIndex = 5;
            label2.Text = "Recipe Category:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(245, 99);
            label3.Name = "label3";
            label3.Size = new Size(313, 25);
            label3.TabIndex = 6;
            label3.Text = "Step By Step Cooking Instruction:";
            // 
            // addrcp_cancel_btn
            // 
            addrcp_cancel_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addrcp_cancel_btn.Location = new Point(28, 315);
            addrcp_cancel_btn.Name = "addrcp_cancel_btn";
            addrcp_cancel_btn.Size = new Size(164, 39);
            addrcp_cancel_btn.TabIndex = 7;
            addrcp_cancel_btn.Text = "Cancel";
            addrcp_cancel_btn.UseVisualStyleBackColor = true;
            addrcp_cancel_btn.Click += addrcp_cancel_btn_Click;
            // 
            // addrcp_search_btn
            // 
            addrcp_search_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addrcp_search_btn.Location = new Point(28, 125);
            addrcp_search_btn.Name = "addrcp_search_btn";
            addrcp_search_btn.Size = new Size(164, 39);
            addrcp_search_btn.TabIndex = 8;
            addrcp_search_btn.Text = "Search Recipe";
            addrcp_search_btn.UseVisualStyleBackColor = true;
            addrcp_search_btn.Click += addrcp_search_btn_Click_1;
            // 
            // addrcp_edit_btn
            // 
            addrcp_edit_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addrcp_edit_btn.Location = new Point(28, 185);
            addrcp_edit_btn.Name = "addrcp_edit_btn";
            addrcp_edit_btn.Size = new Size(164, 39);
            addrcp_edit_btn.TabIndex = 9;
            addrcp_edit_btn.Text = "Save Edited Recipe";
            addrcp_edit_btn.UseVisualStyleBackColor = true;
            addrcp_edit_btn.Click += addrcp_edit_btn_Click;
            // 
            // addrcp_remove_btn
            // 
            addrcp_remove_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addrcp_remove_btn.Location = new Point(28, 247);
            addrcp_remove_btn.Name = "addrcp_remove_btn";
            addrcp_remove_btn.Size = new Size(164, 39);
            addrcp_remove_btn.TabIndex = 10;
            addrcp_remove_btn.Text = "Remove Recipe";
            addrcp_remove_btn.UseVisualStyleBackColor = true;
            addrcp_remove_btn.Click += addrcp_remove_btn_Click;
            // 
            // Menu
            // 
            Menu.Location = new Point(12, 34);
            Menu.Name = "Menu";
            Menu.Size = new Size(200, 343);
            Menu.TabIndex = 11;
            Menu.TabStop = false;
            Menu.Text = "Menu";
            // 
            // addrcp_usercommts_txb
            // 
            addrcp_usercommts_txb.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            addrcp_usercommts_txb.Location = new Point(245, 482);
            addrcp_usercommts_txb.Name = "addrcp_usercommts_txb";
            addrcp_usercommts_txb.Size = new Size(663, 65);
            addrcp_usercommts_txb.TabIndex = 12;
            addrcp_usercommts_txb.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(245, 444);
            label4.Name = "label4";
            label4.Size = new Size(157, 25);
            label4.TabIndex = 13;
            label4.Text = "User Comments:";
            // 
            // AddRecipeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 559);
            Controls.Add(label4);
            Controls.Add(addrcp_usercommts_txb);
            Controls.Add(addrcp_remove_btn);
            Controls.Add(addrcp_edit_btn);
            Controls.Add(addrcp_search_btn);
            Controls.Add(addrcp_cancel_btn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(addrcp_creatercp_btn);
            Controls.Add(addrcp_catrcp_txt);
            Controls.Add(addrcp_stepbstp_txb);
            Controls.Add(addrcp_namercp_txt);
            Controls.Add(Menu);
            Name = "AddRecipeForm";
            Text = "AddRecipeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox addrcp_namercp_txt;
        private RichTextBox addrcp_stepbstp_txb;
        private TextBox addrcp_catrcp_txt;
        private Button addrcp_creatercp_btn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button addrcp_cancel_btn;
        private Button addrcp_search_btn;
        private Button addrcp_edit_btn;
        private Button addrcp_remove_btn;
        private GroupBox Menu;
        private RichTextBox addrcp_usercommts_txb;
        private Label label4;
    }
}