using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BookMarket.CustomControl
{
    public partial class MenuItem : UserControl
    {
        public MenuItem()
        {
            InitializeComponent();
        }


        #region Properties
        string _title;
        Image _icon;
        public bool _active;
        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; lableTitle.Text = value; }
        }
        [Category("Custom Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; Img.Image = value; }
        }
        [Category("Custom Props")]
        public bool Active
        {
            get { return _active; }
            set
            {
                _active = value; ActiveTag.Visible = value;
                if (value)
                {
                    BgPanel.BackColor = ColorTranslator.FromHtml("#303841");
                }
                else
                {
                    BgPanel.BackColor = ColorTranslator.FromHtml("#283038");
                }
            }
        }
        #endregion
    }
}
