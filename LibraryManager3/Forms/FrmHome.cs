using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager3
{
    public partial class FrmHome : Form
    {
        private Form activeForm;
        private PnlAside pnlAside;

        public FrmHome()
        {
            InitializeComponent();

            this.Controls.Add(new PnlAside(this));
            this.Controls.Add(new PnlHeader(this));
            this.Controls.Add(new PnlMain(this));

        }

        //private void openChildForm(Form childForm, object btnSender)
        //{

        //    if (activeForm!=null)
        //    {
        //        activeForm.Close();
        //    }

        //    activateButton(btnSender);
        //    activeForm=childForm;
        //    childForm.TopLevel=false;
        //    childForm.FormBorderStyle=FormBorderStyle.None; 
        //    childForm.Dock=DockStyle.Fill;
        //    this.PnlEmpty.Controls.Add(childForm);  
        //    this.PnlEmpty.Tag = childForm;
        //    childForm.BringToFront();
        //    childForm.Show();

        //}


        

    }
}
