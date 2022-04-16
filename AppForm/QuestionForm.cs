using System;
using System.Windows.Forms;


namespace BookMarket
{

    // форма для отображения информации 
    public partial class QuestionForm : Form
    {
        public QuestionForm()
        {
            InitializeComponent();
            label1.Select();
        }
        private void buttonApply_Click(object sender, EventArgs e) => this.Close();
    }
}
