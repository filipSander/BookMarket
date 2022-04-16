using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BookMarket.CustomControl
{
    public partial class ProdItem : UserControl
    {
        public ProdItem()
        {
            InitializeComponent();
        }


        #region Properties
        string _title;
        string _rPrice;
        string _pPrice;
        string _uMeasurement;
        string _group;


        [Category("ACustom Props")]
        public string Title 
        {
            get { return _title; }
            set { _title = value; lbName.Text = value; }
        }

        [Category("ACustom Props")]
        public string RealizationPrice
        {
            get { return _rPrice; }
            set { _rPrice = value; Rprice.Text = value; }
        }
        [Category("ACustom Props")]
        public string PurchasePrice
        {
            get { return _pPrice; }
            set { _pPrice = value; Pprice.Text = value; }
        }
        [Category("ACustom Props")]
        public string UMeasurement
        {
            get { return _uMeasurement; }
            set { _uMeasurement = value; UM.Text = value; }
        }
        [Category("ACustom Props")]
        public string Group
        {
            get { return _group; }
            set { _group = value; lbGroup.Text = value; }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            if (panel2.Visible)
                Height = 80;
            else
                Height += panel2.Height;
            panel2.Visible = !panel2.Visible;
        }

        private void lbName_MouseClick(object sender, MouseEventArgs e)
        {
            Label label = (sender as Label);
            if (label != null)
            {
                new LoadForm("Текст Скопирован").Show();
                Clipboard.SetText(label.Text, TextDataFormat.UnicodeText);
            }
        }
    }
}
