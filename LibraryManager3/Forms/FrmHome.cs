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

        private Button currentButton;
        private Form activeForm;

        public FrmHome()
        {
            InitializeComponent();
            btnCloseChildForm.Visible=true;
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
                    this.lblSelectedTitle.Text=currentButton.Text;
                }
            }
                

        }

        private void disableButton()
        {

            foreach(Control previousBtn in PnlAisde.Controls)
            {
                if (previousBtn.GetType()==typeof(Button))
                {
                    previousBtn.Font=new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    previousBtn.ForeColor=Color.Black;
                }
            }

        }

        private void openChildForm(Form childForm, object btnSender)
        {

            if (activeForm!=null)
            {
                activeForm.Close();
            }

            activateButton(btnSender);
            activeForm=childForm;
            childForm.TopLevel=false;
            childForm.FormBorderStyle=FormBorderStyle.None; 
            childForm.Dock=DockStyle.Fill;
            this.PnlEmpty.Controls.Add(childForm);  
            this.PnlEmpty.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnAllBooks_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmAllBooks(), sender);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            activateButton(sender);
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            activateButton(sender);
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activateButton!=null)
            {
                activeForm.Close();
            }
            Reset();
        }

        private void Reset()
        {
            disableButton();
            lblSelectedTitle.Text="Home";
            currentButton=null;
            btnCloseChildForm.Visible=false;
        }

    }
}
