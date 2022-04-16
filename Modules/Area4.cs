using System;
using System.Windows.Forms;
using BookMarket.Modules.Area4tab;

namespace BookMarket.Modules
{
    public partial class Area4 : Area
    {
        public Area4()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            button1.PerformClick();
        }

        UserControl temp;
        A4tab7 tab7;

        // реализация переходов между рабочими областями 
        private void clickForAllButt(object sender, EventArgs e)
        {
            switch ((sender as Button).TabIndex)
            {
                case 0:     // Контрагенты
                    A4tab1 tab1 = new A4tab1();
                    tab1.AddButton.Click += clickForAllButt;
                    temp = tab1; 
                    break;
                case 1:     // Реквизиты 
                    A4tab2 tab2 = new A4tab2();
                    temp = tab2;
                    break;
                case 2:     // Группы
                    A4tab3 tab3 = new A4tab3();
                    tab3.AddButton.Click += clickForAllButt;
                    temp = tab3;
                    break;
                case 3:     // Товар
                    A4tab4 tab4 = new A4tab4();
                    tab4.AddButton.Click += clickForAllButt;
                    temp = tab4;
                    break;
                case 4:     // Добавление контрагента
                    A4tab5 tab5 = new A4tab5();
                    tab5.ExitButton.Click += clickForAllButt;
                    temp = tab5;
                    break;
                case 5:     // Добавление группы
                    A4tab6 tab6 = new A4tab6();
                    tab6.ExitButton.Click += clickForAllButt;
                    temp = tab6;
                    break;
                case 6:     // Добавление товара
                    tab7 = new A4tab7();
                    tab7.ExitButton.Click += clickForAllButt;
                    tab7.AddGroup.Click += ApTransition;
                    temp = tab7;
                    break;
            }
            ChangeTab();
        }
        // реализация перехода с сохранением введенной информации 
        private void ApTransition(object sender, EventArgs e)
        {
            switch ((sender as Button).TabIndex)
            {
                case 5:     // Добавление группы
                    A4tab6 tab6 = new A4tab6();
                    tab6.ExitButton.TabIndex = 6;
                    tab6.ExitButton.Click += ApTransition;
                    temp = tab6;
                break;
                case 6:     // Добавление c сохранением введенных данных товара
                    tab7.LoadNewGroup();
                    temp = tab7;
                break;
            }
            ChangeTab();
        }
        private void ChangeTab()
            => AppClassEx.TabInit(temp, container);

    }
}
