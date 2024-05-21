
namespace BookManagement
{
    partial class BookManagerMainUI
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
            lblHeader = new Label();
            grbSearchCiteria = new GroupBox();
            btnSearch = new Button();
            txtBookDescription = new TextBox();
            txtBookName = new TextBox();
            lblBookDescription = new Label();
            lblBookName = new Label();
            lblBookList = new Label();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            dgvBookList = new DataGridView();
            grbSearchCiteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.Yellow;
            lblHeader.Location = new Point(12, 9);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(431, 81);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "BookManager";
            // 
            // grbSearchCiteria
            // 
            grbSearchCiteria.Controls.Add(btnSearch);
            grbSearchCiteria.Controls.Add(txtBookDescription);
            grbSearchCiteria.Controls.Add(txtBookName);
            grbSearchCiteria.Controls.Add(lblBookDescription);
            grbSearchCiteria.Controls.Add(lblBookName);
            grbSearchCiteria.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbSearchCiteria.ForeColor = Color.Yellow;
            grbSearchCiteria.Location = new Point(22, 93);
            grbSearchCiteria.Name = "grbSearchCiteria";
            grbSearchCiteria.Size = new Size(860, 127);
            grbSearchCiteria.TabIndex = 0;
            grbSearchCiteria.TabStop = false;
            grbSearchCiteria.Text = "Search Citeria";
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(736, 55);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(96, 42);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.TextAlign = ContentAlignment.TopCenter;
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtBookDescription
            // 
            txtBookDescription.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBookDescription.Location = new Point(520, 57);
            txtBookDescription.Name = "txtBookDescription";
            txtBookDescription.Size = new Size(186, 34);
            txtBookDescription.TabIndex = 1;
            // 
            // txtBookName
            // 
            txtBookName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBookName.Location = new Point(147, 57);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(186, 34);
            txtBookName.TabIndex = 0;
            // 
            // lblBookDescription
            // 
            lblBookDescription.AutoSize = true;
            lblBookDescription.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookDescription.ForeColor = Color.Yellow;
            lblBookDescription.Location = new Point(339, 60);
            lblBookDescription.Name = "lblBookDescription";
            lblBookDescription.Size = new Size(175, 28);
            lblBookDescription.TabIndex = 4;
            lblBookDescription.Text = "Book Description";
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookName.ForeColor = Color.Yellow;
            lblBookName.Location = new Point(19, 60);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(122, 28);
            lblBookName.TabIndex = 3;
            lblBookName.Text = "Book Name";
            // 
            // lblBookList
            // 
            lblBookList.AutoSize = true;
            lblBookList.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBookList.ForeColor = Color.Yellow;
            lblBookList.Location = new Point(22, 223);
            lblBookList.Name = "lblBookList";
            lblBookList.Size = new Size(99, 28);
            lblBookList.TabIndex = 2;
            lblBookList.Text = "Book List";
            // 
            // btnCreate
            // 
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCreate.ForeColor = Color.Yellow;
            btnCreate.Location = new Point(715, 249);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(167, 38);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Create a book";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.Yellow;
            btnUpdate.Location = new Point(715, 314);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(167, 38);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update a book";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDelete.ForeColor = Color.Yellow;
            btnDelete.Location = new Point(715, 382);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(167, 38);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete a book";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnExit.ForeColor = Color.Yellow;
            btnExit.Location = new Point(715, 446);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(167, 38);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // dgvBookList
            // 
            dgvBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookList.Location = new Point(22, 254);
            dgvBookList.Name = "dgvBookList";
            dgvBookList.RowHeadersWidth = 51;
            dgvBookList.Size = new Size(670, 242);
            dgvBookList.TabIndex = 1;
            // 
            // BookManagerMainUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(904, 508);
            Controls.Add(dgvBookList);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(lblBookList);
            Controls.Add(grbSearchCiteria);
            Controls.Add(lblHeader);
            Name = "BookManagerMainUI";
            RightToLeftLayout = true;
            Text = "Book Manager";
            Load += BookManagerMainUI_Load;
            grbSearchCiteria.ResumeLayout(false);
            grbSearchCiteria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private GroupBox grbSearchCiteria;
        private Label lblBookList;
        private Label lblBookName;
        private Label lblBookDescription;
        private TextBox txtBookDescription;
        private TextBox txtBookName;
        private Button btnSearch;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnExit;
        private DataGridView dgvBookList;
    }
}
