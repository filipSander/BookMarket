using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BookMarket.Modules.Area4tab
{
    public partial class A4tab5 : AreaTab
    {

        // часть программы отвечающая за регистрацию контрагента

        public A4tab5()
        {
            InitializeComponent();
            Init();
        }

        List<Control> controls;
        // инициализация 
        private void Init()
        {


            controls = new List<Control>();
            controls.AddRange(new Control[6] { nameCtagent,typeCtagent, formCtagent, contactPhoneCtagent, addresCtagent, rqCtagent });
            controls.Add(addButton);
            // использование класса расширения для привязки обработчиков (переход между элементами управления при нажатии enter)
            new AppExFocus().ForFocusChanget(controls);

            // ораничение длины
            nameCtagent.MaxLength = addresCtagent.MaxLength = rqCtagent.MaxLength = 300;
            typeCtagent.MaxLength = formCtagent.MaxLength = 40;
            contactPhoneCtagent.MaxLength = 120;

            typeCtagent.KeyPress += formCtagent_KeyPress;
            formCtagent.KeyPress += formCtagent_KeyPress;

        }

        // проверка на корректность введенных данных
        private void proof()
        {
            if (nameCtagent.Text == string.Empty) 
            { 
                lable0.ForeColor = Color.Maroon;
                nameCtagent.Select();
                addButton.Enabled = false;
                return;
            }
            addCtAgent();
        }
        // добавление контрагента
        private void addCtAgent()
        {
            DataBase db = new DataBase();
            if (ctAgentExist())
            {
                new ErrorForm("Такой контрагент уже существует", 1).Show();
                lable0.ForeColor = Color.Maroon;
                nameCtagent.Select();
                return;
            }
            MySqlCommand command = new MySqlCommand("INSERT INTO `counterparty` (`CounterpartyID`, `Type`, `Form`, `Name`, `Address`, `ContactPhone`, `Requisites`)" +
                " VALUES (@ID, @type, @form, @name, @address, @cp, @rq)", db.GetConnection());
            command.Parameters.Add("@ID", MySqlDbType.Int32).Value = db.GetID("counterparty", "CounterpartyID");
            command.Parameters.Add("@type", MySqlDbType.VarChar).Value = typeCtagent.Text;
            command.Parameters.Add("@form", MySqlDbType.VarChar).Value = formCtagent.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = nameCtagent.Text;
            command.Parameters.Add("@address", MySqlDbType.VarChar).Value = addresCtagent.Text;
            command.Parameters.Add("@cp", MySqlDbType.VarChar).Value = contactPhoneCtagent.Text;
            command.Parameters.Add("@rq", MySqlDbType.VarChar).Value = rqCtagent.Text;
            if (db.Request(command))
            {
                new LoadForm("Добавление пользователя.").Show();
                ExitButton.PerformClick();
            }else new ErrorForm("Ошибка регистрации. Пользователь не добавлен. \n Не удалось выполнить запрос к базе данных.", 1).Show();

        }
        // проверка на существование контрагента
        private bool ctAgentExist()
        {
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `counterparty` WHERE `Name` = @NM", db.GetConnection());
            command.Parameters.Add("@NM", MySqlDbType.Text).Value = nameCtagent.Text;
            DataTable table = db.RequestTable(command);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }

        // необходимые для рабочей области обработчики
        private void addButton_Click(object sender, EventArgs e)
            => proof();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lable0.ForeColor = SystemColors.ButtonShadow;
            addButton.Enabled = true;
        }
        private void A4tab5_Load(object sender, EventArgs e)
            => nameCtagent.Select();

        private void formCtagent_KeyPress(object sender, KeyPressEventArgs e)
            => e.Handled = true;
    }
}
