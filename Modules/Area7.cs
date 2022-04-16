using System;
using BookMarket.Modules.Area7tab;

namespace BookMarket.Modules
{
    public partial class Area7 : Area
    {
        public Area7()
        {
            InitializeComponent();
            Init();
        }


        // методы / обработчики реализующие переход между рабочими областями 
        private void button1_Click(object sender, EventArgs e)
        {
            A7tab1 a7Tab1 = new A7tab1();
            a7Tab1.AddUser.Click += new EventHandler(addUser);
            AppClassEx.TabInit(a7Tab1, container);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            A7tab2 a7Tab2 = new A7tab2();
            a7Tab2.reloadButton.Click += button2_Click;
            AppClassEx.TabInit(a7Tab2, container);
        }

        private void addUser(object sender, EventArgs e)
        {
            A7tab3 a7Tab3 = new A7tab3();
            a7Tab3.exitButton.Click += new EventHandler(button1_Click);
            AppClassEx.TabInit(a7Tab3, container);
        }

        private void Init()
        {
            button1.PerformClick();
        }
    }
}
