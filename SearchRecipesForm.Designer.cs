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
            searchbtn.Location = new Point(911, 132);
            searchbtn.Margin = new Padding(4, 5, 4, 5);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(171, 68);
            searchbtn.TabIndex = 0;
            searchbtn.Text = "Search";
            searchbtn.UseVisualStyleBackColor = true;
            // 
            // searchtxbx
            // 
            searchtxbx.Location = new Point(69, 132);
            searchtxbx.Margin = new Padding(4, 5, 4, 5);
            searchtxbx.Multiline = true;
            searchtxbx.Name = "searchtxbx";
            searchtxbx.Size = new Size(810, 66);
            searchtxbx.TabIndex = 1;
            // 
            // resultlstbx
            // 
            resultlstbx.FormattingEnabled = true;
            resultlstbx.ItemHeight = 25;
            resultlstbx.Location = new Point(69, 255);
            resultlstbx.Margin = new Padding(4, 5, 4, 5);
            resultlstbx.Name = "resultlstbx";
            resultlstbx.Size = new Size(1013, 404);
            resultlstbx.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(366, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(342, 48);
            label1.TabIndex = 3;
            label1.Text = "Search Recipe Page";
            // 
            // SearchRecipesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1143, 750);
            Controls.Add(label1);
            Controls.Add(resultlstbx);
            Controls.Add(searchtxbx);
            Controls.Add(searchbtn);
            Margin = new Padding(4, 5, 4, 5);
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