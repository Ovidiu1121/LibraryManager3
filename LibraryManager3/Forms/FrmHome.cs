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

 
        public FrmHome()
        {
            InitializeComponent();

            this.Controls.Add(new PnlAside(this));
            this.Controls.Add(new PnlMain(this));
            this.Controls.Add(new PnlHeader(this));
            this.Controls.Add(new PnlAddBookL(this));
            this.Controls.Add(new PnlAllBooks(this));

        }
        

    }
}
