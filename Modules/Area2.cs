using BookMarket.Modules.Area1tab;
using System;
using System.Windows.Forms;

namespace BookMarket.Modules
{
    public partial class Area2 : Area
    {
        public Area2()
        {
            InitializeComponent();
            Init();
        }

        UserControl temp;
        A12tab1 tab1;
        private void Init()
        {
            tab1 = new A12tab1(true);
            tab1.AddButton.Click += clickForAllButt;
            tab1.AddButton.TabIndex = 1;
            temp = tab1;
            ChangeTab();
        }

        // реализация переходов междк рабочими областями 
        private void clickForAllButt(object sender, EventArgs e)
        {
            switch ((sender as Button).TabIndex)
            {
                case 0:     // Главное окно продажи товара
                    temp = tab1;
                    break;
                case 1:     // Выбор товара для продажи
                    A12tab2 tab2 = new A12tab2(tab1);
                    tab2.ExitButton.Click += clickForAllButt;
                    tab2.ExitButton.TabIndex = 0;
                    temp = tab2;
                    break;
            }
            ChangeTab();
        }

        private void ChangeTab()
            => AppClassEx.TabInit(temp, container);
    }
}
