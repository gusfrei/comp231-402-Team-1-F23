namespace EasyCookingApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            hpgloginbtn = new Button();
            hmpgrecipebtn = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // hpgloginbtn
            // 
            hpgloginbtn.BackColor = Color.Honeydew;
            hpgloginbtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            hpgloginbtn.Location = new Point(87, 162);
            hpgloginbtn.Name = "hpgloginbtn";
            hpgloginbtn.Size = new Size(244, 122);
            hpgloginbtn.TabIndex = 0;
            hpgloginbtn.Text = "Login";
            hpgloginbtn.UseVisualStyleBackColor = false;
            hpgloginbtn.Click += hpgloginbtn_Click;
            // 
            // hmpgrecipebtn
            // 
            hmpgrecipebtn.BackColor = Color.Honeydew;
            hmpgrecipebtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            hmpgrecipebtn.Location = new Point(408, 162);
            hmpgrecipebtn.Name = "hmpgrecipebtn";
            hmpgrecipebtn.Size = new Size(244, 122);
            hmpgrecipebtn.TabIndex = 1;
            hmpgrecipebtn.Text = "Search Recipes";
            hmpgrecipebtn.UseVisualStyleBackColor = false;
            hmpgrecipebtn.Click += hmpgrecipebtn_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.LightYellow;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(257, 330);
            label1.Name = "label1";
            label1.Size = new Size(244, 52);
            label1.TabIndex = 2;
            label1.Text = "Home Page";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.MintCream;
            label2.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(193, 45);
            label2.Name = "label2";
            label2.Size = new Size(367, 55);
            label2.TabIndex = 3;
            label2.Text = "Easy Cooking App";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(hmpgrecipebtn);
            Controls.Add(hpgloginbtn);
            Name = "Form1";
            Text = "Easy Cooking App";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button hpgloginbtn;
        private Button hmpgrecipebtn;
        private Label label1;
        private Label label2;
    }
}