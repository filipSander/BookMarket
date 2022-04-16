using System.ComponentModel;
using System.Windows.Forms;

namespace BookMarket.CustomControl
{
    public partial class ProdItemReg : UserControl
    {
        public ProdItemReg()
        {
            InitializeComponent();
        }
        public int TotalPrice;

        #region -- Properties -- 

        string _title;
        int _price = 0;
        
        int _count = 1;
        string _units;
        

        [Category("ACustom Props")]

        public string Title
        {
            get { return _title; }
            set { _title = value; lblName.Text = value; }
        }        
        
        [Category("ACustom Props")]
        public string Units
        {
            get { return _units; }
            set { _units = value; lblUnits.Text = value; }
        }        
        [Category("ACustom Props")]
        public int Count
        {
            get { return _count; }
            set { _count = value; NumUpDownCount.Value = value; CountTotalPrice(); }
        }

        [Category("ACustom Props")]
        public int Price
        {
            get { return _price; }
            set { _price = value; lblPrice.Text = value.ToString(); CountTotalPrice(); }
        }

        #endregion

        public void CountTotalPrice()
        {
            TotalPrice = _price * _count; 
            lblTotalPrice.Text = TotalPrice.ToString();
        }


    }
}
