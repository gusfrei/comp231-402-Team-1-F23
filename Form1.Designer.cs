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
            this.hpgloginbtn = new System.Windows.Forms.Button();
            this.hmpgrecipebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hpgloginbtn
            // 
            this.hpgloginbtn.BackColor = System.Drawing.Color.Honeydew;
            this.hpgloginbtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hpgloginbtn.Location = new System.Drawing.Point(125, 155);
            this.hpgloginbtn.Name = "hpgloginbtn";
            this.hpgloginbtn.Size = new System.Drawing.Size(244, 122);
            this.hpgloginbtn.TabIndex = 0;
            this.hpgloginbtn.Text = "Login";
            this.hpgloginbtn.UseVisualStyleBackColor = false;
            // 
            // hmpgrecipebtn
            // 
            this.hmpgrecipebtn.BackColor = System.Drawing.Color.Honeydew;
            this.hmpgrecipebtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hmpgrecipebtn.Location = new System.Drawing.Point(446, 155);
            this.hmpgrecipebtn.Name = "hmpgrecipebtn";
            this.hmpgrecipebtn.Size = new System.Drawing.Size(244, 122);
            this.hmpgrecipebtn.TabIndex = 1;
            this.hmpgrecipebtn.Text = "Search Recipes";
            this.hmpgrecipebtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(231, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 77);
            this.label1.TabIndex = 2;
            this.label1.Text = "Home Page";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hmpgrecipebtn);
            this.Controls.Add(this.hpgloginbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button hpgloginbtn;
        private Button hmpgrecipebtn;
        private Label label1;
    }
}