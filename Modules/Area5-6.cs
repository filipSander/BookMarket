using BookMarket.CustomControl;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace BookMarket.Modules
{
    public partial class Area56 : Area
    {
        public Area56()
        {
            InitializeComponent();
            Init();
        }

        public bool IsArea6;
        public Area56(bool isArea6)
        {
            InitializeComponent();
            IsArea6 = true;
            Init();
        }

        private void Init()
        {
            if (IsArea6)
            {
                lblTitle.Text = "Статистика продаж";
            }
            checkDoc(string.Empty);
        }

        private int getContropartyID(string name)
        {
            int id = 0;

            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand($"Select `CounterpartyID` from `counterparty` where `Name` = @name", db.GetConnection());
            command.Parameters.Add("name", MySqlDbType.VarChar).Value = name;
            DataTable table = db.RequestTable(command);
            if (table.Rows.Count > 0)
                id = table.Rows[0].Field<int>("CounterpartyID");
            return id;
        }

        private void checkDoc(string req)
        {
            flowContainer.Controls.Clear();
            DataBase db = new DataBase();
            if (IsArea6)
            {
                if (req == string.Empty) req = "Select * from `realizationgoods`";
                else req = $"Select * from `realizationgoods` where `Date` like '{req}%' or `CounterpartyID` = {getContropartyID(req)}";
            }
            else
            {
                if (req == string.Empty) req = "Select * from `arrivalgoods`";
                else req = $"Select * from `arrivalgoods` where `Date` like '{req}%' or `CounterpartyID` = {getContropartyID(req)}";
            }
            MySqlCommand command = new MySqlCommand(req, db.GetConnection());
            DataTable table = db.RequestTable(command);

            if (table.Rows.Count > 0)
            {
                for(int i = 0; i < table.Rows.Count; i++)
                {
                    DocItem temp = new DocItem();
                    temp.Date = table.Rows[i].Field<string>("Date");
                    temp.Summ = table.Rows[i].Field<string>("Sum");
                    temp.Ca = getRowName("counterparty", "CounterpartyID", table.Rows[i].Field<int>("CounterpartyID"));
                    temp.Content = IsArea6 ? getDocContent(table.Rows[i].Field<int>("RealizationID")) : getDocContent(table.Rows[i].Field<int>("ArrivalID"));
                    temp.DeleteDoc.Click += deleteDoc;
                    temp.DeleteDoc.Tag = IsArea6 ? table.Rows[i].Field<int>("RealizationID") : table.Rows[i].Field<int>("ArrivalID");
                    flowContainer.Controls.Add(temp);
                }
            }
            else
            {
                Label lbl = new Label();
                lbl.Text = "Не найдено!";
                flowContainer.Controls.Add(lbl);
            }
        }

        private void deleteDoc(object sender, EventArgs e)
        {
            if(deleteRelation( (int)(sender as Button).Tag ))
            {
                DataBase db = new DataBase();
                MySqlCommand command = null;
                if (IsArea6)
                    command = new MySqlCommand("Delete From `realizationgoods` where `RealizationID` = @id", db.GetConnection());
                else
                    command = new MySqlCommand("Delete From `arrivalgoods` where `ArrivalID` = @id", db.GetConnection());

                command.Parameters.Add("id", MySqlDbType.Int32).Value = (int)(sender as Button).Tag;
                if (db.Request(command))
                {
                    new LoadForm("Удаление").Show();
                    checkDoc(string.Empty);
                    return;
                }
            }
            new ErrorForm("Ошибка. Не удалось выполнить запрос к бд.", 1).Show();
        }

        private bool deleteRelation(int DocID)
        {
            DataBase db = new DataBase();
            MySqlCommand command = null;
            if(IsArea6) command = new MySqlCommand("Delete From `compositionregistration` where `RealizationID` = @id", db.GetConnection()); 
            else command = new MySqlCommand("Delete From `contentsdelivery` where `ArrivalID` = @id", db.GetConnection());
            command.Parameters.Add("id",MySqlDbType.Int32).Value = DocID;
            if (db.Request(command))
                return true;
            return false;
        }

        private string getDocContent(int docID)
        {
            string content = "Содержание операции не найдено.";

            DataBase db = new DataBase();
            MySqlCommand command = null;
            if(IsArea6) command = new MySqlCommand("Select * from `compositionregistration` where `RealizationID` = @id", db.GetConnection());
            else command = new MySqlCommand("Select * from `contentsdelivery` where `ArrivalID` = @id", db.GetConnection());
            command.Parameters.Add("id", MySqlDbType.Int32).Value = docID;
            DataTable table = db.RequestTable(command);
            if(table.Rows.Count > 0)
            {
                content = "-- Состав операции -- \n\nНаименование:\t\tКоличество:\t\tСумма, (руб):\n\n";
                for ( int i = 0; i < table.Rows.Count; i++)
                {
                    content +=   getRowName("product", "ProductID", table.Rows[i].Field<int>("ProductID")) + "\t\t\t";
                    content +=   table.Rows[i].Field<int>("Count").ToString() + "\t\t\t";
                    content +=   table.Rows[i].Field<string>("Summ") + "\n\n";
                }
            }

            return content;
        }

        private string getRowName(string _table, string _parametr, int _id)
        {
            string name = "Не удалось найти запись.";

            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand($"Select `Name` from `{_table}` where `{_parametr}` = @id", db.GetConnection());
            command.Parameters.Add("id", MySqlDbType.Int32).Value = _id;
            DataTable table = db.RequestTable(command);
            if (table.Rows.Count > 0)
                name = table.Rows[0].Field<string>("Name");
            return name;
        }

        private void Area5_Resize(object sender, EventArgs e)
            => flowContainer.Height = Height - 150;

        private void search_TextChanged(object sender, EventArgs e)
            => checkDoc(search.Text);

        private void pictureBox1_Click(object sender, EventArgs e)
            => checkDoc(string.Empty);
    }
}
