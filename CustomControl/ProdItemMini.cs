using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BookMarket.CustomControl
{
    public partial class ProdItemMini : UserControl
    {
        public ProdItemMini()
        {
            InitializeComponent();
        }

        #region -- Properties -- 
        string _title;
        Image _icon;

        [Category("ACustom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; name.Text = value; }
        }

        [Category("ACustom Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; _icon = value; }
        }

        #endregion

    }
}
