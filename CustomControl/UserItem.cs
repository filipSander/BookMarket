using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BookMarket.CustomControl
{
    public partial class UserItem : UserControl
    {
        public UserItem()
        {
            InitializeComponent();
        }


        #region Properties
        string _title;
        string _acc;


        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; login.Text = value; }
        }


        [Category("Custom Props")]
        public string Acc
        {
            get { return _acc; }
            set { _acc = value; acclevel.Text = value; }
        }
        #endregion

        private void acclevel_MouseEnter(object sender, EventArgs e) => this.BackColor = ColorTranslator.FromHtml("#424D59");
        private void bg_MouseLeave(object sender, EventArgs e) => this.BackColor = ColorTranslator.FromHtml("#303841");
    }
}
