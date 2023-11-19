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
            SuspendLayout();
            // 
            // hpgloginbtn
            // 
            hpgloginbtn.BackColor = Color.Honeydew;
            hpgloginbtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            hpgloginbtn.Location = new Point(179, 258);
            hpgloginbtn.Margin = new Padding(4, 5, 4, 5);
            hpgloginbtn.Name = "hpgloginbtn";
            hpgloginbtn.Size = new Size(349, 203);
            hpgloginbtn.TabIndex = 0;
            hpgloginbtn.Text = "Login";
            hpgloginbtn.UseVisualStyleBackColor = false;
            hpgloginbtn.Click += hpgloginbtn_Click;
            // 
            // hmpgrecipebtn
            // 
            hmpgrecipebtn.BackColor = Color.Honeydew;
            hmpgrecipebtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            hmpgrecipebtn.Location = new Point(637, 258);
            hmpgrecipebtn.Margin = new Padding(4, 5, 4, 5);
            hmpgrecipebtn.Name = "hmpgrecipebtn";
            hmpgrecipebtn.Size = new Size(349, 203);
            hmpgrecipebtn.TabIndex = 1;
            hmpgrecipebtn.Text = "Search Recipes";
            hmpgrecipebtn.UseVisualStyleBackColor = false;
            hmpgrecipebtn.Click += hmpgrecipebtn_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(330, 58);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(426, 128);
            label1.TabIndex = 2;
            label1.Text = "Home Page";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1143, 750);
            Controls.Add(label1);
            Controls.Add(hmpgrecipebtn);
            Controls.Add(hpgloginbtn);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button hpgloginbtn;
        private Button hmpgrecipebtn;
        private Label label1;
    }
}