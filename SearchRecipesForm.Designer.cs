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
            label1 = new Label();
            search_rcp_datagv = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)search_rcp_datagv).BeginInit();
            SuspendLayout();
            // 
            // searchbtn
            // 
            searchbtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            searchbtn.Location = new Point(622, 56);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(120, 41);
            searchbtn.TabIndex = 0;
            searchbtn.Text = "Search";
            searchbtn.UseVisualStyleBackColor = true;
            searchbtn.Click += searchbtn_Click;
            // 
            // searchtxbx
            // 
            searchtxbx.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            searchtxbx.Location = new Point(12, 56);
            searchtxbx.Multiline = true;
            searchtxbx.Name = "searchtxbx";
            searchtxbx.Size = new Size(588, 41);
            searchtxbx.TabIndex = 1;
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
            // search_rcp_datagv
            // 
            search_rcp_datagv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            search_rcp_datagv.Location = new Point(12, 124);
            search_rcp_datagv.Name = "search_rcp_datagv";
            search_rcp_datagv.RowTemplate.Height = 25;
            search_rcp_datagv.Size = new Size(730, 440);
            search_rcp_datagv.TabIndex = 4;
            // 
            // SearchRecipesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(768, 602);
            Controls.Add(search_rcp_datagv);
            Controls.Add(label1);
            Controls.Add(searchtxbx);
            Controls.Add(searchbtn);
            Name = "SearchRecipesForm";
            Text = "SearchRecipesForm";
            ((System.ComponentModel.ISupportInitialize)search_rcp_datagv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button searchbtn;
        private TextBox searchtxbx;
        private Label label1;
        private DataGridView search_rcp_datagv;
    }
}