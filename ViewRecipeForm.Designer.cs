namespace EasyCookingApp
{
    partial class ViewRecipeForm
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
            label4 = new Label();
            viewrcp_usercommts_txb = new RichTextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            viewrcp_catrcp_txt = new TextBox();
            viewrcp_stepbstp_txb = new RichTextBox();
            viewrcp_namercp_txt = new TextBox();
            button1 = new Button();
            viewrcp_cancel_btn = new Button();
            viewrcp_export_btn = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(69, 418);
            label4.Name = "label4";
            label4.Size = new Size(157, 25);
            label4.TabIndex = 21;
            label4.Text = "User Comments:";
            // 
            // viewrcp_usercommts_txb
            // 
            viewrcp_usercommts_txb.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            viewrcp_usercommts_txb.Location = new Point(69, 446);
            viewrcp_usercommts_txb.Name = "viewrcp_usercommts_txb";
            viewrcp_usercommts_txb.Size = new Size(663, 65);
            viewrcp_usercommts_txb.TabIndex = 20;
            viewrcp_usercommts_txb.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(69, 90);
            label3.Name = "label3";
            label3.Size = new Size(313, 25);
            label3.TabIndex = 19;
            label3.Text = "Step By Step Cooking Instruction:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(562, 18);
            label2.Name = "label2";
            label2.Size = new Size(162, 25);
            label2.TabIndex = 18;
            label2.Text = "Recipe Category:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(69, 18);
            label1.Name = "label1";
            label1.Size = new Size(161, 25);
            label1.TabIndex = 17;
            label1.Text = "Name of Recipe: ";
            // 
            // viewrcp_catrcp_txt
            // 
            viewrcp_catrcp_txt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            viewrcp_catrcp_txt.Location = new Point(562, 46);
            viewrcp_catrcp_txt.Multiline = true;
            viewrcp_catrcp_txt.Name = "viewrcp_catrcp_txt";
            viewrcp_catrcp_txt.ReadOnly = true;
            viewrcp_catrcp_txt.Size = new Size(184, 32);
            viewrcp_catrcp_txt.TabIndex = 16;
            // 
            // viewrcp_stepbstp_txb
            // 
            viewrcp_stepbstp_txb.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            viewrcp_stepbstp_txb.Location = new Point(69, 118);
            viewrcp_stepbstp_txb.Name = "viewrcp_stepbstp_txb";
            viewrcp_stepbstp_txb.ReadOnly = true;
            viewrcp_stepbstp_txb.Size = new Size(663, 297);
            viewrcp_stepbstp_txb.TabIndex = 15;
            viewrcp_stepbstp_txb.Text = "";
            // 
            // viewrcp_namercp_txt
            // 
            viewrcp_namercp_txt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            viewrcp_namercp_txt.Location = new Point(69, 46);
            viewrcp_namercp_txt.Multiline = true;
            viewrcp_namercp_txt.Name = "viewrcp_namercp_txt";
            viewrcp_namercp_txt.ReadOnly = true;
            viewrcp_namercp_txt.Size = new Size(473, 32);
            viewrcp_namercp_txt.TabIndex = 14;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(444, 526);
            button1.Name = "button1";
            button1.Size = new Size(128, 41);
            button1.TabIndex = 22;
            button1.Text = "Post Comment";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // viewrcp_cancel_btn
            // 
            viewrcp_cancel_btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            viewrcp_cancel_btn.Location = new Point(596, 526);
            viewrcp_cancel_btn.Name = "viewrcp_cancel_btn";
            viewrcp_cancel_btn.Size = new Size(128, 41);
            viewrcp_cancel_btn.TabIndex = 23;
            viewrcp_cancel_btn.Text = "Cancel";
            viewrcp_cancel_btn.UseVisualStyleBackColor = true;
            viewrcp_cancel_btn.Click += viewrcp_cancel_btn_Click;
            // 
            // viewrcp_export_btn
            // 
            viewrcp_export_btn.BackColor = SystemColors.ActiveCaption;
            viewrcp_export_btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            viewrcp_export_btn.Location = new Point(69, 526);
            viewrcp_export_btn.Name = "viewrcp_export_btn";
            viewrcp_export_btn.Size = new Size(128, 41);
            viewrcp_export_btn.TabIndex = 24;
            viewrcp_export_btn.Text = "Export Recipe";
            viewrcp_export_btn.UseVisualStyleBackColor = false;
            viewrcp_export_btn.Click += viewrcp_export_btn_Click;
            // 
            // ViewRecipeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 579);
            Controls.Add(viewrcp_export_btn);
            Controls.Add(viewrcp_cancel_btn);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(viewrcp_usercommts_txb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(viewrcp_catrcp_txt);
            Controls.Add(viewrcp_stepbstp_txb);
            Controls.Add(viewrcp_namercp_txt);
            Name = "ViewRecipeForm";
            Text = "ViewRecipeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private RichTextBox viewrcp_usercommts_txb;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox viewrcp_catrcp_txt;
        private RichTextBox viewrcp_stepbstp_txb;
        private TextBox viewrcp_namercp_txt;
        private Button button1;
        private Button viewrcp_cancel_btn;
        private Button viewrcp_export_btn;
    }
}