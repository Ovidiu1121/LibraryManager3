using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager3
{
    internal class PnlAside:Panel
    {
        private Button btnAllBooks;
        private Button btnSortare;
        private Button btnAddBook;
        private Button currentButton;
        private PnlHeader pnlHeader;

        private Form form;

        public PnlAside(FrmHome form)
        {
            
            this.form = form;
            this.Location = new Point(0, 101);
            this.Size = new Size(185, 349);
            this.BackColor = Color.DarkGray;
            this.Name="PnlAside";
            this.Anchor = AnchorStyles.Left|AnchorStyles.Top|AnchorStyles.Bottom;

            this.btnAllBooks = new Button();
            this.Controls.Add(this.btnAllBooks);
            this.btnAllBooks.Text="All Books";
            this.btnAllBooks.Location = new Point(0, 0);
            this.btnAllBooks.Size = new Size(185, 80);
            this.btnAllBooks.Font=new Font("Arial",12,FontStyle.Bold);
            this.btnAllBooks.FlatAppearance.BorderSize = 0;
            this.btnAllBooks.FlatStyle = FlatStyle.Flat;
            this.btnAllBooks.Click+=new EventHandler(this.btnAllBooks_Click);

            this.btnSortare = new Button();
            this.btnSortare.Text="Sortare";
            this.Controls.Add(this.btnSortare);
            this.btnSortare.Location = new Point(0, 80);
            this.btnSortare.Size = new Size(185, 80);
            this.btnSortare.Font=new Font("Arial", 12, FontStyle.Bold);
            this.btnSortare.FlatAppearance.BorderSize = 0;
            this.btnSortare.FlatStyle = FlatStyle.Flat;
            this.btnSortare.Click+=new EventHandler(this.btnSortare_Click);

            this.btnAddBook=new Button();
            this.Controls.Add(this.btnAddBook);
            this.btnAddBook.Text="Add Book";
            this.btnAddBook.Location = new Point(0, 160);
            this.btnAddBook.Size = new Size(185, 80);
            this.btnAddBook.Font=new Font("Arial", 12, FontStyle.Bold);
            this.btnAddBook.FlatAppearance.BorderSize = 0;
            this.btnAddBook.FlatStyle = FlatStyle.Flat;
            this.btnAddBook.Click+=new EventHandler(this.btnAddBook_Click);


        }

        private void activateButton(object btnSender)
        {
            if (btnSender!=null)
            {
                if (currentButton!=(Button)btnSender)
                {
                    disableButton();
                    currentButton=(Button)btnSender;
                    currentButton.Font=new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    currentButton.ForeColor=Color.White;
                    //this.lblSelectedTitle.Text=currentButton.Text;
                }
            }


        }

        private void disableButton()
        {

            foreach (Control previousBtn in this.Controls)
            {
                if (previousBtn.GetType()==typeof(Button))
                {
                    previousBtn.Font=new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    previousBtn.ForeColor=Color.Black;
                }
            }

        }

        private void btnAllBooks_Click(object sender, EventArgs e)
        {
            activateButton(sender);
        }

        private void btnSortare_Click(object sender, EventArgs e)
        {
            activateButton(sender);
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            activateButton(sender);
        }

    }
}
