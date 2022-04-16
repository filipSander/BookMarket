using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BookMarket.CustomControl
{
    public partial class DocItem : UserControl
    {
        public DocItem()
        {
            InitializeComponent();
        }

        #region -- Properties --
        string _date, _ctagent, _sostav;
        string _summ;

        [Category("ACustom Props")]
        public string Date
        {
            get { return _date; }
            set { _date = value; lblDate.Text = value; }
        }


        [Category("ACustom Props")]
        public string Ca
        {
            get { return _ctagent; }
            set { _ctagent = value; lblCa.Text = value; }
        }



        [Category("ACustom Props")]
        public string Summ
        {
            get { return _summ; }
            set { _summ = value; lblSumm.Text = value; }
        }

        [Category("ACustom Props")]
        public string Content
        {
            get { return _sostav; }
            set { _sostav = value; richTextBox1.Text = value; }
        }

        #endregion

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
            => e.Handled = true;
        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Visible)
            {
                richTextBox1.Visible = false;
                Height -= richTextBox1.Height;
            }
            else
            {
                richTextBox1.Visible = true;
                Height += richTextBox1.Height;
            }
        }

    }
}
