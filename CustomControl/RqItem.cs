using System.ComponentModel;
using System.Windows.Forms;

namespace BookMarket.CustomControl
{
    public partial class RqItem : UserControl
    {
        public RqItem()
        {
            InitializeComponent();
        }

        #region -- Properties --
        string _title;
        string _value;

        [Category("ACustom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; title.Text = value; }
        }


        [Category("ACustom Props")]
        public string Value
        {
            get { return _value; }
            set { _value = value; tbvalue.Text = value; }
        }
        #endregion

        private void tbvalue_TextChanged(object sender, System.EventArgs e)
        {
            _value = tbvalue.Text;
        }

        private void RqItem_Enter(object sender, System.EventArgs e)
        {
            tbvalue.Select();
        }
    }
}
