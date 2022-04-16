using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookMarket
{
    // форма для отображения успешной операции 
    public partial class LoadForm : Form
    {
        string operation;
        public LoadForm(string opr)
        {
            InitializeComponent();
            operation = opr;
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        async void exit()
        {            
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            description.Text = operation;
            await Task.Delay(1000);
            this.Close();
        }
        private void loadForm_Load(object sender, EventArgs e) => exit();
    }
}
