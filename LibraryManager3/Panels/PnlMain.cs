using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager3
{
    internal class PnlMain:Panel
    {
        private Label lbl;
        private FrmHome form;


        public PnlMain(FrmHome form)
        {

            this.form = form;
            this.Location = new Point(185, 101);
            this.Size = new Size(615, 349);
            this.Name="PnlMain";
            this.BackColor=Color.White;
            

            this.lbl = new Label();
            this.Controls.Add(this.lbl);
            this.lbl.Location = new Point(200, 148);
            this.lbl.Size=new Size(216, 35);
            this.lbl.Text="Choose a button";
            this.lbl.Font=new Font("Arial", 15, FontStyle.Bold);
            this.lbl.Anchor = AnchorStyles.None;

        }


    }
}
