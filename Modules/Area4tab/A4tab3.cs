using BookMarket.CustomControl;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BookMarket.Modules.Area4tab
{
    public partial class A4tab3 : AreaTab
    {
        // часть программы отвечающая за отображение и добавления групп товара

        public A4tab3()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            flowContainer.AutoScrollMinSize = new Size(0, flowContainer.Height - 100);
            checkGroup();
        }
        GroupItem[] groups;
        private void checkGroup()
        {
            flowContainer.Controls.Clear();
            // Запрос
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `groupproduct`", db.GetConnection());
            DataTable table = db.RequestTable(command);

            if (table.Rows.Count > 0)
            {
                groups = new GroupItem[table.Rows.Count];
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    GroupItem temp = new GroupItem();
                    int groupID = table.Rows[i].Field<int>("GroupID");
                    temp.Title = table.Rows[i].Field<string>("Name");
                    temp.DeleteGr.Tag = groupID;

                    //Количество товаров?
                    temp.Count = checkCountItems(groupID).ToString();

                    temp.DeleteGr.Click += DeleteGr_Click;
                    temp.Dock = DockStyle.Top;
                    temp.Margin = new Padding(0);
                    temp.Padding = new Padding(0);


                    groups[i] = temp;
                }
                foreach (GroupItem i in groups)
                    flowContainer.Controls.Add(i);
            }
            else
            {
                Label lbl = new Label();
                lbl.Text = "Не найдено!";
                flowContainer.Controls.Add(lbl);
            }
        }
        // получение количества товаров в группе
        private int checkCountItems(int _groupID)
        {
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand($"SELECT COUNT(*) AS `COUNT` From `productgroupproduct` WHERE `GroupID` = @ID", db.GetConnection());
            command.Parameters.Add("@ID", MySqlDbType.Int32).Value = _groupID;
            DataTable table = db.RequestTable(command);
            return Convert.ToInt32(table.Rows[0].Field<Int64>("COUNT"));
        }


        // удаление группы 
        private void DeleteGr_Click(object sender, EventArgs e)
        {
            int groupID = Convert.ToInt32((sender as Button).Tag);
            if(checkCountItems(groupID) > 0)
                if (!deleteRelation(groupID))
                {
                    new ErrorForm("Ошибка!.\nНе удалось выполнить запрос к базе данных.", 1).Show();
                    return;
                }

            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("DELETE FROM `groupproduct` WHERE `groupproduct`.`GroupID` = @id", db.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = groupID;
            if (db.Request(command))
            {
                new LoadForm("Удаление группы.").Show(); ;
                checkGroup();
            }
            else
                new ErrorForm("Ошибка!.\nНе удалось выполнить запрос к базе данных.", 1).Show();
        }

        // удаления связей группы товара и товаров 
        private bool deleteRelation(int groupID)
        {
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("DELETE FROM `productgroupproduct` WHERE `productgroupproduct`.`GroupID` = @id", db.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = groupID;
            if (db.Request(command))
                return true;
            else
                new ErrorForm("Ошибка!.\nНе удалось выполнить запрос к базе данных.", 1).Show();
            return false;
        }

        // необходимые методы
        private void A4tab3_Resize(object sender, EventArgs e)
            => flowContainer.Height = Height - 210;
    }
}
