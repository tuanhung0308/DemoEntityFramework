namespace DemoEntityFramework
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
            btSearch = new Button();
            lable8 = new Label();
            tbContent = new TextBox();
            dgvSupplier = new DataGridView();
            groupBox1 = new GroupBox();
            btDelete = new Button();
            btUpdate = new Button();
            btAdd = new Button();
            btRefresh = new Button();
            tbHomePage = new TextBox();
            tbPhone = new TextBox();
            tbContactName = new TextBox();
            tbCompanyName = new TextBox();
            tbSupplierID = new TextBox();
            label7 = new Label();
            label6 = new Label();
            cbTitle = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btInsertDatabase = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSupplier).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btSearch
            // 
            btSearch.Location = new Point(999, 32);
            btSearch.Margin = new Padding(3, 4, 3, 4);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(86, 31);
            btSearch.TabIndex = 11;
            btSearch.Text = "Search";
            btSearch.UseVisualStyleBackColor = true;
            // 
            // lable8
            // 
            lable8.AutoSize = true;
            lable8.Location = new Point(669, 43);
            lable8.Name = "lable8";
            lable8.Size = new Size(53, 20);
            lable8.TabIndex = 10;
            lable8.Text = "Search";
            // 
            // tbContent
            // 
            tbContent.Location = new Point(758, 32);
            tbContent.Margin = new Padding(3, 4, 3, 4);
            tbContent.Name = "tbContent";
            tbContent.Size = new Size(203, 27);
            tbContent.TabIndex = 9;
            // 
            // dgvSupplier
            // 
            dgvSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSupplier.Location = new Point(48, 120);
            dgvSupplier.Margin = new Padding(2, 3, 2, 3);
            dgvSupplier.Name = "dgvSupplier";
            dgvSupplier.RowHeadersWidth = 51;
            dgvSupplier.RowTemplate.Height = 25;
            dgvSupplier.Size = new Size(574, 489);
            dgvSupplier.TabIndex = 8;
            dgvSupplier.CellClick += dgvSupplier_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btDelete);
            groupBox1.Controls.Add(btUpdate);
            groupBox1.Controls.Add(btAdd);
            groupBox1.Controls.Add(btRefresh);
            groupBox1.Controls.Add(tbHomePage);
            groupBox1.Controls.Add(tbPhone);
            groupBox1.Controls.Add(tbContactName);
            groupBox1.Controls.Add(tbCompanyName);
            groupBox1.Controls.Add(tbSupplierID);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cbTitle);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(647, 120);
            groupBox1.Margin = new Padding(2, 3, 2, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 3, 2, 3);
            groupBox1.Size = new Size(541, 489);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Supplier's Details";
            // 
            // btDelete
            // 
            btDelete.Location = new Point(399, 399);
            btDelete.Margin = new Padding(2, 3, 2, 3);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(81, 45);
            btDelete.TabIndex = 15;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // btUpdate
            // 
            btUpdate.Location = new Point(283, 399);
            btUpdate.Margin = new Padding(2, 3, 2, 3);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(79, 45);
            btUpdate.TabIndex = 14;
            btUpdate.Text = "Update";
            btUpdate.UseVisualStyleBackColor = true;
            btUpdate.Click += btUpdate_Click;
            // 
            // btAdd
            // 
            btAdd.Location = new Point(158, 399);
            btAdd.Margin = new Padding(2, 3, 2, 3);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(87, 45);
            btAdd.TabIndex = 13;
            btAdd.Text = "Add";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // btRefresh
            // 
            btRefresh.Location = new Point(41, 399);
            btRefresh.Margin = new Padding(2, 3, 2, 3);
            btRefresh.Name = "btRefresh";
            btRefresh.Size = new Size(89, 45);
            btRefresh.TabIndex = 12;
            btRefresh.Text = "Refresh";
            btRefresh.UseVisualStyleBackColor = true;
            // 
            // tbHomePage
            // 
            tbHomePage.Location = new Point(158, 309);
            tbHomePage.Margin = new Padding(2, 3, 2, 3);
            tbHomePage.Multiline = true;
            tbHomePage.Name = "tbHomePage";
            tbHomePage.Size = new Size(204, 44);
            tbHomePage.TabIndex = 11;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(158, 259);
            tbPhone.Margin = new Padding(2, 3, 2, 3);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(204, 27);
            tbPhone.TabIndex = 10;
            // 
            // tbContactName
            // 
            tbContactName.Location = new Point(158, 140);
            tbContactName.Margin = new Padding(2, 3, 2, 3);
            tbContactName.Name = "tbContactName";
            tbContactName.Size = new Size(204, 27);
            tbContactName.TabIndex = 9;
            // 
            // tbCompanyName
            // 
            tbCompanyName.Location = new Point(158, 85);
            tbCompanyName.Margin = new Padding(2, 3, 2, 3);
            tbCompanyName.Name = "tbCompanyName";
            tbCompanyName.Size = new Size(204, 27);
            tbCompanyName.TabIndex = 8;
            // 
            // tbSupplierID
            // 
            tbSupplierID.Location = new Point(158, 36);
            tbSupplierID.Margin = new Padding(2, 3, 2, 3);
            tbSupplierID.Name = "tbSupplierID";
            tbSupplierID.ReadOnly = true;
            tbSupplierID.Size = new Size(204, 27);
            tbSupplierID.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 312);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(86, 20);
            label7.TabIndex = 6;
            label7.Text = "Home Page";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 261);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 5;
            label6.Text = "Phone";
            // 
            // cbTitle
            // 
            cbTitle.FormattingEnabled = true;
            cbTitle.Location = new Point(158, 193);
            cbTitle.Margin = new Padding(2, 3, 2, 3);
            cbTitle.Name = "cbTitle";
            cbTitle.Size = new Size(204, 28);
            cbTitle.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 203);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 3;
            label5.Text = "Contact Title";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 149);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 2;
            label4.Text = "ContactName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 95);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 1;
            label3.Text = "Company Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 45);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 0;
            label2.Text = "SupplierID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(120, 77);
            label1.Name = "label1";
            label1.Size = new Size(254, 32);
            label1.TabIndex = 6;
            label1.Text = "Supplier Information";
            // 
            // btInsertDatabase
            // 
            btInsertDatabase.Location = new Point(69, 624);
            btInsertDatabase.Margin = new Padding(2, 3, 2, 3);
            btInsertDatabase.Name = "btInsertDatabase";
            btInsertDatabase.Size = new Size(162, 45);
            btInsertDatabase.TabIndex = 14;
            btInsertDatabase.Text = "Insert to Database";
            btInsertDatabase.UseVisualStyleBackColor = true;
            btInsertDatabase.Click += btInsertDatabase_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 681);
            Controls.Add(btInsertDatabase);
            Controls.Add(btSearch);
            Controls.Add(lable8);
            Controls.Add(tbContent);
            Controls.Add(dgvSupplier);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSupplier).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btSearch;
        private Label lable8;
        private TextBox tbContent;
        private DataGridView dgvSupplier;
        private GroupBox groupBox1;
        private Button btDelete;
        private Button btUpdate;
        private Button btAdd;
        private Button btRefresh;
        private TextBox tbHomePage;
        private TextBox tbPhone;
        private TextBox tbContactName;
        private TextBox tbCompanyName;
        private TextBox tbSupplierID;
        private Label label7;
        private Label label6;
        private ComboBox cbTitle;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btInsertDatabase;
    }
}