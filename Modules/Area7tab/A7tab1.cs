using BookMarket.CustomControl;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BookMarket.Modules.Area7tab
{
    public partial class A7tab1 : AreaTab
    {

        // часть программы отвечающая за отображение и добавления пользователей программы
        public A7tab1()
        {
            InitializeComponent();
            Init();

        }

        private void Init()
        {
            flowContainer.AutoScrollMinSize = new Size(0, flowContainer.Height -100);
            checkUser();
        }

        UserItem[] users;

        // обращение к бд и отображение записей о пользователях
        void checkUser()
        {

            DataBase db = new DataBase();
            MySqlCommand comand = new MySqlCommand("SELECT * FROM `users`", db.GetConnection());
            DataTable table = db.RequestTable(comand);

            if (table.Rows.Count > 0)
            {
                users = new UserItem[table.Rows.Count];
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    UserItem tempUser = new UserItem();
                    tempUser.Title = table.Rows[i].Field<string>("login");
                    switch (table.Rows[i].Field<int>("accessLevel"))
                    {
                        case 1: tempUser.Acc = "Администратор"; break;
                        case 2: tempUser.Acc = "Специалист"; break;
                        case 3: tempUser.Acc = "Работник"; break;
                    }
                    tempUser.DeleteUser.Tag = table.Rows[i].Field<int>("userID").ToString();
                    tempUser.DeleteUser.Click += new EventHandler(deleteUser);
                    tempUser.Dock = DockStyle.Top;
                    tempUser.Margin = new Padding(0);
                    tempUser.Padding = new Padding(0);


                    users[i] = tempUser;
                }
                flowContainer.Controls.Clear();
                foreach (UserItem i in users)
                    flowContainer.Controls.Add(i);
            }
            else
            {
                Label lbl = new Label();
                lbl.Text = "Не найдено!";
                flowContainer.Controls.Add(lbl);
            }
        }

        // метод / обработчик события предназначенный для удаления пользователя
        private void deleteUser(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("DELETE FROM `users` WHERE `users`.`userID` = @id", db.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = (sender as Button).Tag;
            if (db.Request(command))
            {
                new LoadForm("Удаление пользователя.").Show(); ;
                checkUser();
            }else new ErrorForm("Ошибка!.\nНе удалось выполнить запрос к базе данных.", 1).Show();
        }

        private void A7tab1_Resize(object sender, EventArgs e)
            => flowContainer.Height = Height - 210;
    }
}
