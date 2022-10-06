namespace LibraryManager3
{
    partial class FrmAllBooks
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
            this.lstAllBooks = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lstAllBooks
            // 
            this.lstAllBooks.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.lstAllBooks.GridLines = true;
            this.lstAllBooks.Location = new System.Drawing.Point(96, 58);
            this.lstAllBooks.Name = "lstAllBooks";
            this.lstAllBooks.Size = new System.Drawing.Size(597, 342);
            this.lstAllBooks.TabIndex = 0;
            this.lstAllBooks.UseCompatibleStateImageBehavior = false;
            this.lstAllBooks.View = System.Windows.Forms.View.Details;
            // 
            // FrmAllBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstAllBooks);
            this.Name = "FrmAllBooks";
            this.Text = "FrmAllBooks";
            this.ResumeLayout(false);

        }

        #endregion

        private ListView lstAllBooks;
    }
}