using System.ComponentModel;
using System.Windows.Forms;

namespace BookMarket.CustomControl
{
    public partial class GroupItem : UserControl
    {
        public GroupItem()
        {
            InitializeComponent();
        }


        #region Properties
        string _title;
        string _count;

        [Category("ACustom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; lableName.Text = value; }
        }


        [Category("ACustom Props")]
        public string Count
        {
            get { return _count; }
            set { _count = value; countLable.Text = value; }
        }
        #endregion
    }
}
