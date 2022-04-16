using System.ComponentModel;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookMarket.CustomControl
{
    public partial class CaItem : UserControl
    {
        public CaItem()
        {
            InitializeComponent();
        }

        #region -- Properties --
        string _name, _type, _form, _address, _contactPhone, _requisites;

        [Category("Custom Props")]
        public string CompName
        {
            get { return _name; }
            set { _name = value; name.Text = value; }
        }


        [Category("Custom Props")]
        public string Type
        {
            get { return _type; }
            set { _type = value; type.Text = value; }
        }


        [Category("Custom Props")]
        public string Form
        {
            get { return _form; }
            set { _form = value; form.Text = value; }
        }
        [Category("Custom Props")]
        public string Address
        {
            get { return _address; }
            set { _address = value; address.Text = value; }
        }
        [Category("Custom Props")]
        public string ContactPhone
        {
            get { return _contactPhone; }
            set { _contactPhone = value; contactPhone.Text = value; }
        }


        [Category("Custom Props")]
        public string Requisites
        {
            get { return _requisites; }
            set { _requisites = value; requisites.Text = value; }
        }
        #endregion
        
        private void label_MouseClick(object sender, MouseEventArgs e)
        {
            Label label = (sender as Label);
            if (label != null)
            {
                new LoadForm("Текст Скопирован").Show();
                Clipboard.SetText(label.Text, TextDataFormat.UnicodeText);
            }
        }
        private void button1_Click(object sender, System.EventArgs e)
        {
            if (!label1.Visible)
            {
                Height = 160;
                label1.Visible = label2.Visible = label3.Visible = contactPhone.Visible = requisites.Visible = address.Visible = true;
            }
            else
            {
                Height = 80;
                label1.Visible = label2.Visible = label3.Visible = contactPhone.Visible = requisites.Visible = address.Visible = false;
            }
        }
    }
}
