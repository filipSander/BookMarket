using BookMarket.CustomControl;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BookMarket.Modules.Area4tab
{
    public partial class A4tab1 : AreaTab
    {

        // рабочая область отвечающая за регистрацию контрагентов в бд приложения
        public A4tab1()
        {
            InitializeComponent();
            Init();
        }
        // массивы для работы с элементами управления
        RadioButton[] buttItem;
        RadioButton[] buttItem0;
        List<Control> controls;
        private void Init()
        {
            // инициализация массивов
            buttItem = new RadioButton[3] { radioButton1, radioButton2, radioButton3};
            buttItem0 = new RadioButton[3] { radioButton4, radioButton5, radioButton6 };
            
            // использование класса расширения для привязки обработчиков (переход между элементами управления при нажатии enter)
            controls = new List<Control>();
            controls.AddRange(buttItem);
            controls.AddRange(buttItem0);
            new AppExFocus().ForFocusChanget(controls);

            flowContainer.AutoScrollMinSize = new Size(0, flowContainer.Height - 100);
            
            ctAgentCheced();
        }

        CaItem[] ctAgent;
        string _command;    // строка хранящая модицицированный запрос к бд

        // медод получения данных о контрагентах и их отображения 
        private void ctAgentCheced()
        {
            flowContainer.Controls.Clear();
            сhangeСommandParametrs();

            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand(_command, db.GetConnection());
            DataTable table = db.RequestTable(command);

            if (table.Rows.Count > 0)
            {
                int ofset = 0;
                ctAgent = new CaItem[table.Rows.Count];
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    CaItem tempAgent = new CaItem();
                    tempAgent.CompName = table.Rows[i].Field<string>("Name");
                    tempAgent.Form = table.Rows[i].Field<string>("Form");
                    tempAgent.Type = table.Rows[i].Field<string>("Type");
                    tempAgent.Address = table.Rows[i].Field<string>("Address");
                    tempAgent.ContactPhone = table.Rows[i].Field<string>("ContactPhone");
                    tempAgent.Requisites = table.Rows[i].Field<string>("Requisites");

                    tempAgent.DeleteCA.Tag = table.Rows[i].Field<int>("CounterpartyID");
                    tempAgent.DeleteCA.Click += DeleteCA_Click;

                    tempAgent.Dock = DockStyle.Top;
                    tempAgent.Location = new Point(0, 0 + ofset);
                    ofset += tempAgent.Height;

                    ctAgent[i] = tempAgent;
                }
                
                foreach (CaItem i in ctAgent)
                    flowContainer.Controls.Add(i);
            }
            else
            {
                Label lbl = new Label();
                lbl.Text = "Не найдено!";
                flowContainer.Controls.Add(lbl);
            }
        }

        // Обработчик события / метод удаления контрагента
        private void DeleteCA_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            int _id = Convert.ToInt32((sender as Button).Tag);
            if (db.СheckTableOwned("arrivalgoods", "CounterpartyID", _id) || db.СheckTableOwned("realizationgoods", "CounterpartyID", _id))
            {
                new ErrorForm("Этого контрагента нельзя удалить\nИнформация о нем отраженна в документации \n(Документы поставки или продажи товара.)", 1).Show();
                return;
            }
            MySqlCommand command = new MySqlCommand("DELETE FROM `counterparty` WHERE `counterparty`.`counterpartyID` = @id", db.GetConnection());
            if (_id == 0)
            {
                new ErrorForm("Этого клиента нельзя удалить ", 1).Show();
                db.CloseConnection();
                return;
            }
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = _id;
            if (db.Request(command))
            {
                new LoadForm("Удаление контрагента.").Show();
                ctAgentCheced();
            }
            else new ErrorForm("Ошибка!.\nНе удалось выполнить запрос к базе данных.", 1).Show();

        }

        private bool checkDocumentOwned(int CounterpartyID)
        {
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("SELECT COUNT(*) as `COUNT` FROM `arrivalgoods` where `CounterpartyID` = @id", db.GetConnection());
            command.Parameters.Add("id", MySqlDbType.Int32).Value = CounterpartyID;
            DataTable table = db.RequestTable(command);
            if (table.Rows[0].Field<Int64>("COUNT") > 0)
                return true;
            return false;
        }

        // модификация запроса у бд
        private void сhangeСommandParametrs() 
        {
            _command = "SELECT * FROM `counterparty` ";
            bool isFirst = true;
            string _operator = "WHERE";
            foreach (RadioButton r in buttItem)
                if (r.Checked && r.Name.ToString() != "radioButton1")
                {
                    _operator = isFirst ? "WHERE" : "AND";
                    _command += _operator + " `Type` = " + $"\"{r.Text}\" ";
                    isFirst = false;
                } 

            foreach (RadioButton r in buttItem0)
                if (r.Checked && r.Name.ToString() != "radioButton4")
                {
                    _operator = isFirst ? "WHERE" : "AND";
                    _command += _operator + " `Form` = " + $"\"{r.Text}\"";
                    isFirst = false;
                }
        }

        // основной медод модификации запроса
        private void CheckedChangetForRadioButt(object sender, EventArgs e)
        {
            if( (sender as RadioButton).Name == "radioButton1" ||
                (sender as RadioButton).Name == "radioButton2" ||
                (sender as RadioButton).Name == "radioButton3" )
                foreach(RadioButton r in buttItem)
                    r.ForeColor = Color.Azure;
            else
                foreach (RadioButton r in buttItem0)
                    r.ForeColor = Color.Azure;
            (sender as RadioButton).ForeColor = Color.LightSeaGreen;

            ctAgentCheced();
        }
        
        // необходимые для рабочей области обработчики/чик
        private void A4tab1_Resize(object sender, EventArgs e)
            => flowContainer.Height = Height - 210;
    }
}
