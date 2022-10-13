using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager3
{
    internal class PnlAddBookL:Panel
    {

        private Label lblTitle;
        private Label lblAuhtor;
        private Label lblGenre;
        private Label lblYear;
        private TextBox txtTitle;
        private TextBox txtAuhtor;
        private TextBox txtGenre;
        private TextBox txtYear;
        private Button btnAdd;
        private Button btnCancel;
        private FrmHome form;
        private ControlBooks control=new ControlBooks();

        public PnlAddBookL(FrmHome form)
        {

            this.form = form;
            this.Location = new Point(185, 101);
            this.Size = new Size(615, 349);
            this.Name="PnlAddBook";
            this.BackColor=Color.LightPink;
            this.Anchor=AnchorStyles.Right|AnchorStyles.Bottom|AnchorStyles.Left|AnchorStyles.Top;

            this.lblTitle=new Label();
            this.Controls.Add(this.lblTitle);
            this.lblTitle.Location=new Point(88, 85);
            this.lblTitle.Text="Title";
            this.lblTitle.Font=new Font("Arial", 11, FontStyle.Bold);
            this.lblTitle.Anchor=AnchorStyles.Left|AnchorStyles.Top;

            this.lblAuhtor=new Label();
            this.Controls.Add(this.lblAuhtor);
            this.lblAuhtor.Location=new Point(88, 148);
            this.lblAuhtor.Text="Author";
            this.lblAuhtor.Font=new Font("Arial", 11, FontStyle.Bold);
            this.lblAuhtor.Anchor=AnchorStyles.Left|AnchorStyles.Top;

            this.lblGenre=new Label();
            this.Controls.Add(this.lblGenre);
            this.lblGenre.Location=new Point(88, 210);
            this.lblGenre.Text="Genre";
            this.lblGenre.Font=new Font("Arial", 11, FontStyle.Bold);
            this.lblGenre.Anchor=AnchorStyles.Left|AnchorStyles.Top;

            this.lblYear=new Label();
            this.Controls.Add(this.lblYear);
            this.lblYear.Location=new Point(88, 270);
            this.lblYear.Text="Year";
            this.lblYear.Font=new Font("Arial", 11, FontStyle.Bold);
            this.lblYear.Anchor=AnchorStyles.Left|AnchorStyles.Top;

            this.txtTitle=new TextBox();
            this.Controls.Add(this.txtTitle);
            this.txtTitle.Location=new Point(185, 82);
            this.txtTitle.Size=new Size(125, 27);
            this.txtTitle.Anchor=AnchorStyles.Left|AnchorStyles.Top;

            this.txtAuhtor=new TextBox();
            this.Controls.Add(this.txtAuhtor);
            this.txtAuhtor.Location=new Point(185, 145);
            this.txtAuhtor.Size=new Size(125, 27);
            this.txtAuhtor.Anchor=AnchorStyles.Left|AnchorStyles.Top;

            this.txtGenre=new TextBox();
            this.Controls.Add(this.txtGenre);
            this.txtGenre.Location=new Point(185, 203);
            this.txtGenre.Size=new Size(125, 27);
            this.txtGenre.Anchor=AnchorStyles.Left|AnchorStyles.Top;

            this.txtYear=new TextBox();
            this.Controls.Add(this.txtYear);
            this.txtYear.Location=new Point(185, 267);
            this.txtYear.Size=new Size(125, 27);
            this.txtYear.Anchor=AnchorStyles.Left|AnchorStyles.Top;

            this.btnAdd=new Button();
            this.Controls.Add(this.btnAdd);
            this.btnAdd.Location=new Point(401, 139);
            this.btnAdd.Size=new Size(94, 29);
            this.btnAdd.FlatAppearance.BorderSize=0;
            this.btnAdd.FlatStyle=FlatStyle.Flat;
            this.btnAdd.Text="Add";
            this.btnAdd.Font=new Font("Arial", 13, FontStyle.Bold);
            this.btnAdd.Click+=new EventHandler(this.add_Click);

            this.btnCancel=new Button();
            this.Controls.Add(this.btnCancel);
            this.btnCancel.Location=new Point(401, 190);
            this.btnCancel.Size=new Size(94, 29);
            this.btnCancel.FlatAppearance.BorderSize=0;
            this.btnCancel.FlatStyle=FlatStyle.Flat;
            this.btnCancel.Text="Delete";
            this.btnCancel.Font=new Font("Arial", 13, FontStyle.Bold);

        }

        private void add_Click(object sender, EventArgs e)
        {

            if (this.txtTitle.Equals("")==false&&this.txtAuhtor.Equals("")==false&&this.txtGenre.Text.Equals("")==false&&this.txtYear.Equals("")==false)
            {

                Book book = new Book(this.txtTitle.Text, this.txtAuhtor.Text, this.txtGenre.Text, int.Parse(this.txtYear.Text));

                this.control.add(book);
                this.control.save();


            }
            else if (this.txtTitle.Equals("")==true||this.txtAuhtor.Equals("")==true||this.txtGenre.Text.Equals("")==true||this.txtYear.Equals("")==true)
            {
                MessageBox.Show("Exista minim un camp necompletat.");
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            

        }

    }
}
