using BookMarket.CustomControl;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BookMarket.Modules.Area4tab
{
    public partial class A4tab2 : AreaTab
    {
        // часть программы отвечающая за отображение и модификаци реквизитов 

        public A4tab2()
        {
            InitializeComponent();
            Init();
        }

        // инициализация рабочей области
        private void Init()
        {
            flowContainer.AutoScrollMinSize = new Size(0, flowContainer.Height - 100);
            loadReq();
        }

        // метод обновления реквизитов
        private void updateReq()
        {
            if (req.Length > 0)
            {
                for (int i = 0; i < req.Length; i++)
                {
                    DataBase db = new DataBase();
                    MySqlCommand command = new MySqlCommand("UPDATE `props` SET `Value` = @VALUE WHERE `props`.`PropsID` = @ID", db.GetConnection());
                    command.Parameters.Add("@VALUE", MySqlDbType.VarChar).Value = req[i].Value;
                    command.Parameters.Add("@ID", MySqlDbType.Int32).Value = req[i].Tag;
                    if (!db.Request(command))
                    {
                        new ErrorForm("Ошибка!.\nНе удалось выполнить запрос к базе данных.", 1).Show();
                        return;
                    }
                }
            }
            else
            {
                new ErrorForm("Данных для обновленяи не найденно.", 1).Show();
                return ;
            }
            new LoadForm("Обновление данных.").Show();
        }

        RqItem[] req = new RqItem[0];
        // отображение реквизитов
        private void loadReq()
        {
            DataBase db = new DataBase();
            MySqlCommand comand = new MySqlCommand("SELECT * FROM `props`", db.GetConnection());
            DataTable table = db.RequestTable(comand);
            if (table.Rows.Count > 0)
            {
                req = new RqItem[table.Rows.Count];
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    RqItem temp = new RqItem();
                    temp.Title = table.Rows[i].Field<string>("Name");
                    temp.Value = table.Rows[i].Field<string>("Value");
                    temp.Tag = table.Rows[i].Field<int>("PropsID");
                    req[i] = temp;
                }
                foreach (RqItem i in req)
                    flowContainer.Controls.Add(i);
            }
            else
            {
                Label lbl = new Label();
                lbl.Text = "Не найдено!";
                flowContainer.Controls.Add(lbl);
            }
        }
        // необходимые для рабочей области обработчики/чик
        private void reloadButt_Click(object sender, EventArgs e)
            => updateReq();
        private void A4tab2_Resize(object sender, EventArgs e)
            => flowContainer.Height = Height - 210;
    }
}
