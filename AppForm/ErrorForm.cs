using System.Windows.Forms;

namespace BookMarket
{
    // форма для отображения ошибок
    public partial class ErrorForm : Form
    {
        int error = 1;
        public ErrorForm(string Description, int errortype)
        {
            InitializeComponent();
            error = errortype; 
            Desc.Text = Description;
            Init();
        }
        void Init()
        {
            if (error == 0)
            {
                label2.Visible = label3.Visible = true;
                FormClosed += ErrorForm_FormClosed;
                Application.ExitThread();
            }
        }

        private void ErrorForm_FormClosed(object sender, FormClosedEventArgs e) 
            => Application.Exit();
    }
}
