using BookMarket.Modules;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BookMarket
{
    public partial class MainForm : Form
    {
        private int accessLevel;
        public MainForm(int acc)
        {
            InitializeComponent();
            accessLevel = acc;
            Init();
        }


        // инициализация формы 
        private void Init()
        {
            
            spData.Text = Convert.ToString(DateTime.Today.ToLongDateString());

            //добовление данных в словарь
            partMode.Add(1, "Приход товара");
            partMode.Add(2, "Продажа товара");
            partMode.Add(3, "Склад");
            partMode.Add(4, "Справочники");
            partMode.Add(5, "Статистика прихода");
            partMode.Add(6, "Статистика продаж");
            partMode.Add(7, "Администрирование");
            appInit();
        }


        CustomControl.MenuItem[] menuItems;
        UserControl[] areaItems;
        int temp = 1;
        Dictionary<int, string> partMode = new Dictionary<int, string>();

        // отображение данных соответственно уровню доступа пользователя 
        private void appInit()
        {
            switch (accessLevel)
            {
                case 1:
                    accessLvl.Text = "Admin";
                    menuItem6.Visible = true; menuItem7.Visible = true; menuItem5.Visible = true;
                    areaItems = new UserControl[7] { new Area1(), new Area2(), new Area3(), new Area4(), new Area56(), new Area56(true), new Area7() };
                    menuItems = new CustomControl.MenuItem[7] { menuItem1, menuItem2, menuItem3, menuItem4, menuItem5, menuItem6, menuItem7 };
                    break;
                case 2:
                    accessLvl.Text = "Special";
                    menuItem5.Visible = true; menuItem6.Visible = true;
                    areaItems = new UserControl[6] { new Area1(), new Area2(), new Area3(), new Area4(), new Area56(), new Area56(true) };
                    menuItems = new CustomControl.MenuItem[6] { menuItem1, menuItem2, menuItem3, menuItem4, menuItem5, menuItem6 };
                    break;
                case 3:
                    accessLvl.Text = "Worker";
                    areaItems = new UserControl[4] { new Area1(), new Area2(), new Area3(), new Area4() };
                    menuItems = new CustomControl.MenuItem[4] { menuItem1, menuItem2, menuItem3, menuItem4 };
                    break;
                default:
                    Hide(); new ErrorForm("Ошибка идентификации.", 0).Show();
                    break;
            }
            int j = 1;
            foreach(CustomControl.MenuItem i in menuItems)
            {
                i.Click += new EventHandler(menuItem_Click);
                i.BgPanel.Click += new EventHandler(menuItem_Click);
                i.Img.Click += new EventHandler(menuItem_Click);
                i.lableTitle.Click += new EventHandler(menuItem_Click);
                i.Img.Tag = $"menuItem{j}";
                i.lableTitle.Tag = $"menuItem{j}";
                j += 1;
            }
            menuFocusChanget();
        }

        // реализация переходов между рабочими областями приложения 
        private void menuItem_Click(object sender, EventArgs e)
        {
            string senderName = "";
            switch (sender.GetType().ToString())
            {
                case "System.Windows.Forms.Panel":
                    senderName = (sender as Panel).Parent.Name; break;
                case "System.Windows.Forms.Label":
                    senderName = (sender as Label).Tag.ToString(); break;
                case "System.Windows.Forms.PictureBox":
                    senderName = (sender as PictureBox).Tag.ToString(); break;
            }
            switch (senderName)
            {
                case "menuItem1": temp = 1; break;
                case "menuItem2": temp = 2; break;
                case "menuItem3": temp = 3; break;
                case "menuItem4": temp = 4; break;
                case "menuItem5": temp = 5; break;
                case "menuItem6": temp = 6; break;
                case "menuItem7": temp = 7; break;
            }
            menuFocusChanget();
        }

        // смена текущей вкладки (области приложеня)
        private void menuFocusChanget()
        {
            foreach (CustomControl.MenuItem i in menuItems)
                i.Active = false;
            menuItems[temp - 1].Active = true;
            AppClassEx.TabInit(areaItems[temp - 1], workArea);
            spPart.Text = partMode[temp];
        }
        private void mainForm_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();
    }
}
