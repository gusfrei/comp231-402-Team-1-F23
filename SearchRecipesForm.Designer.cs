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
            searchbtn = new Button();
            searchtxbx = new TextBox();
            resultlstbx = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // searchbtn
            // 
            searchbtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            searchbtn.Location = new Point(638, 79);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(120, 41);
            searchbtn.TabIndex = 0;
            searchbtn.Text = "Search";
            searchbtn.UseVisualStyleBackColor = true;
            // 
            // searchtxbx
            // 
            searchtxbx.Location = new Point(48, 79);
            searchtxbx.Multiline = true;
            searchtxbx.Name = "searchtxbx";
            searchtxbx.Size = new Size(568, 41);
            searchtxbx.TabIndex = 1;
            // 
            // resultlstbx
            // 
            resultlstbx.FormattingEnabled = true;
            resultlstbx.ItemHeight = 15;
            resultlstbx.Location = new Point(48, 153);
            resultlstbx.Name = "resultlstbx";
            resultlstbx.Size = new Size(710, 244);
            resultlstbx.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(256, 9);
            label1.Name = "label1";
            label1.Size = new Size(233, 32);
            label1.TabIndex = 3;
            label1.Text = "Search Recipe Page";
            // 
            // SearchRecipesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(resultlstbx);
            Controls.Add(searchtxbx);
            Controls.Add(searchbtn);
            Name = "SearchRecipesForm";
            Text = "SearchRecipesForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button searchbtn;
        private TextBox searchtxbx;
        private ListBox resultlstbx;
        private Label label1;
    }
}