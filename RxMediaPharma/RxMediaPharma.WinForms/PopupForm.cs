using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RxMediaPharma.WinForms
{
    public partial class PopupForm : Form
    {
        public PopupForm()
        {
            InitializeComponent();
        }

        public PopupForm(string htmlText)
        {
            InitializeComponent();
            webBrowser1.DocumentText = htmlText;
        }
    }
}
