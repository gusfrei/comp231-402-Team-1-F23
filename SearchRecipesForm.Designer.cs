namespace EasyCookingApp
{
    partial class SearchRecipesForm
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
            this.searchbtn = new System.Windows.Forms.Button();
            this.searchtxbx = new System.Windows.Forms.TextBox();
            this.resultlstbx = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchbtn
            // 
            this.searchbtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchbtn.Location = new System.Drawing.Point(638, 79);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(120, 41);
            this.searchbtn.TabIndex = 0;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            // 
            // searchtxbx
            // 
            this.searchtxbx.Location = new System.Drawing.Point(48, 79);
            this.searchtxbx.Multiline = true;
            this.searchtxbx.Name = "searchtxbx";
            this.searchtxbx.Size = new System.Drawing.Size(568, 41);
            this.searchtxbx.TabIndex = 1;
            // 
            // resultlstbx
            // 
            this.resultlstbx.FormattingEnabled = true;
            this.resultlstbx.ItemHeight = 15;
            this.resultlstbx.Location = new System.Drawing.Point(48, 153);
            this.resultlstbx.Name = "resultlstbx";
            this.resultlstbx.Size = new System.Drawing.Size(710, 244);
            this.resultlstbx.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(256, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search Recipe Page";
            // 
            // SearchRecipesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultlstbx);
            this.Controls.Add(this.searchtxbx);
            this.Controls.Add(this.searchbtn);
            this.Name = "SearchRecipesForm";
            this.Text = "SearchRecipesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button searchbtn;
        private TextBox searchtxbx;
        private ListBox resultlstbx;
        private Label label1;
    }
}