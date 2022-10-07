using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager3
{
    internal class PnlHeader:Panel
    {

        private Label lblTitle;
        private Label lblSelectedTitle;
        private Button btnClose;
        private FrmHome form;

        public PnlHeader(FrmHome form)
        {
            this.form = form;
            this.Location = new Point(0, 0);
            this.Size = new Size(800, 101);
            this.BackColor = Color.FromArgb(192, 192, 255);
            this.Name="PnlHeader";
            this.Anchor = AnchorStyles.Right|AnchorStyles.Left|AnchorStyles.Top;

            this.lblTitle = new Label();
            this.Controls.Add(this.lblTitle);
            this.lblTitle.Location = new Point(54, 32);
            this.lblTitle.Size = new Size(80, 30);
            this.lblTitle.Text="Books";
            this.lblTitle.Font=new Font("Arial", 14, FontStyle.Bold);
            this.lblTitle.Anchor=AnchorStyles.Left|AnchorStyles.Top;

            this.lblSelectedTitle = new Label();
            this.Controls.Add(this.lblSelectedTitle);
            this.lblSelectedTitle.Location = new Point(395, 32);
            this.lblSelectedTitle.Size = new Size(170, 32);
            this.lblSelectedTitle.Text="Selected text";
            this.lblSelectedTitle.Font=new Font("Arial", 14, FontStyle.Bold);
            this.lblSelectedTitle.Anchor=AnchorStyles.None;

            this.btnClose = new Button();
            this.Controls.Add(this.btnClose);
            this.btnClose.Location = new Point(184, 12);
            this.btnClose.Size = new Size(94, 68);
            this.btnClose.Text="X";
            this.btnClose.Font=new Font("Arial", 12, FontStyle.Bold);
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle=FlatStyle.Flat;


        }


    }
}
