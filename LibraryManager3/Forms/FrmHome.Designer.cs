namespace LibraryManager3
{
    partial class FrmHome
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
            this.PnlAisde = new System.Windows.Forms.Panel();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnAllBooks = new System.Windows.Forms.Button();
            this.PnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.PnlSelectedTitle = new System.Windows.Forms.Panel();
            this.lblSelectedTitle = new System.Windows.Forms.Label();
            this.PnlEmpty = new System.Windows.Forms.Panel();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.PnlAisde.SuspendLayout();
            this.PnlTitle.SuspendLayout();
            this.PnlSelectedTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlAisde
            // 
            this.PnlAisde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PnlAisde.Controls.Add(this.btnAddBook);
            this.PnlAisde.Controls.Add(this.btnSort);
            this.PnlAisde.Controls.Add(this.btnAllBooks);
            this.PnlAisde.Controls.Add(this.PnlTitle);
            this.PnlAisde.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlAisde.Location = new System.Drawing.Point(0, 0);
            this.PnlAisde.Name = "PnlAisde";
            this.PnlAisde.Size = new System.Drawing.Size(169, 450);
            this.PnlAisde.TabIndex = 0;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddBook.FlatAppearance.BorderSize = 0;
            this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBook.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddBook.Location = new System.Drawing.Point(0, 240);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(169, 71);
            this.btnAddBook.TabIndex = 3;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnSort
            // 
            this.btnSort.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSort.FlatAppearance.BorderSize = 0;
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSort.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSort.Location = new System.Drawing.Point(0, 163);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(169, 77);
            this.btnSort.TabIndex = 2;
            this.btnSort.Text = "Sortare";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnAllBooks
            // 
            this.btnAllBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAllBooks.FlatAppearance.BorderSize = 0;
            this.btnAllBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllBooks.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAllBooks.Location = new System.Drawing.Point(0, 87);
            this.btnAllBooks.Name = "btnAllBooks";
            this.btnAllBooks.Size = new System.Drawing.Size(169, 76);
            this.btnAllBooks.TabIndex = 1;
            this.btnAllBooks.Text = "All Books";
            this.btnAllBooks.UseVisualStyleBackColor = true;
            this.btnAllBooks.Click += new System.EventHandler(this.btnAllBooks_Click);
            // 
            // PnlTitle
            // 
            this.PnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PnlTitle.Controls.Add(this.lblTitle);
            this.PnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitle.Location = new System.Drawing.Point(0, 0);
            this.PnlTitle.Name = "PnlTitle";
            this.PnlTitle.Size = new System.Drawing.Size(169, 87);
            this.PnlTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(40, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(91, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Books";
            // 
            // PnlSelectedTitle
            // 
            this.PnlSelectedTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PnlSelectedTitle.Controls.Add(this.btnCloseChildForm);
            this.PnlSelectedTitle.Controls.Add(this.lblSelectedTitle);
            this.PnlSelectedTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlSelectedTitle.Location = new System.Drawing.Point(169, 0);
            this.PnlSelectedTitle.Name = "PnlSelectedTitle";
            this.PnlSelectedTitle.Size = new System.Drawing.Size(631, 87);
            this.PnlSelectedTitle.TabIndex = 1;
            // 
            // lblSelectedTitle
            // 
            this.lblSelectedTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSelectedTitle.AutoSize = true;
            this.lblSelectedTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSelectedTitle.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSelectedTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSelectedTitle.Location = new System.Drawing.Point(226, 26);
            this.lblSelectedTitle.Name = "lblSelectedTitle";
            this.lblSelectedTitle.Size = new System.Drawing.Size(170, 32);
            this.lblSelectedTitle.TabIndex = 0;
            this.lblSelectedTitle.Text = "Selected Title";
            // 
            // PnlEmpty
            // 
            this.PnlEmpty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlEmpty.Location = new System.Drawing.Point(169, 87);
            this.PnlEmpty.Name = "PnlEmpty";
            this.PnlEmpty.Size = new System.Drawing.Size(631, 363);
            this.PnlEmpty.TabIndex = 2;
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(92, 87);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.Text = "X";
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PnlEmpty);
            this.Controls.Add(this.PnlSelectedTitle);
            this.Controls.Add(this.PnlAisde);
            this.Name = "FrmHome";
            this.Text = "FrmHome";
            this.PnlAisde.ResumeLayout(false);
            this.PnlTitle.ResumeLayout(false);
            this.PnlTitle.PerformLayout();
            this.PnlSelectedTitle.ResumeLayout(false);
            this.PnlSelectedTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PnlAisde;
        private Button btnAddBook;
        private Button btnSort;
        private Button btnAllBooks;
        private Panel PnlTitle;
        private Label lblTitle;
        private Panel PnlSelectedTitle;
        private Label lblSelectedTitle;
        private Panel PnlEmpty;
        private Button btnCloseChildForm;
    }
}