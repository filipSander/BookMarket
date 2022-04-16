using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BookMarket.Modules.Area4tab
{
    public partial class A4tab6 : AreaTab
    {
        // часть программы отвечающая за регистрацию группы товара

        public A4tab6()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            List<Control> controls = new List<Control>();
            controls.AddRange(new Control[]{nameTextBox, descRichBox,addButton });
            new AppExFocus().ForFocusChanget(controls);
        }
        // добавление группы 
        private void addButton_Click(object sender, System.EventArgs e)
        {
            if (nameTextBox.Text != string.Empty)
            {
                DataBase db = new DataBase();
                if (groupExists())
                {
                    new ErrorForm("Такая группа уже существует", 1).Show();
                    nameTextBox.Text = string.Empty; nameLable.ForeColor = Color.Maroon; nameTextBox.Select();
                    return;
                }
                MySqlCommand command = new MySqlCommand("INSERT INTO `groupproduct` (`GroupID`, `Name` , `Description` ) VALUES(@id, @name, @desc);", db.GetConnection());
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = db.GetID("groupproduct", "GroupID");
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = nameTextBox.Text;
                command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = descRichBox.Text;
                if (db.Request(command))
                {
                    new LoadForm("Добавление группы.").Show();
                    ExitButton.PerformClick();
                }else new ErrorForm("Ошибка регистрации группы. Группа не добавлена. \n Не удалось выполнить запрос к базе данных.", 1).Show();

            }
            else
            {
                nameLable.ForeColor = Color.Maroon;
                addButton.Enabled = false;
                nameTextBox.Select();
            }
        }

        // проверка на совпадение названия с существующими группами
        private bool groupExists()
        {
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `groupproduct` WHERE `Name` = @NM", db.GetConnection());
            command.Parameters.Add("@NM", MySqlDbType.VarChar).Value = nameTextBox.Text;
            DataTable table = db.RequestTable(command);
            db.CloseConnection();
            if (table.Rows.Count > 0)
                return true;
            else 
                return false;
        }


        // необходимые для рабочей области обработчики 

        private void nameTextBox_TextChanged(object sender, System.EventArgs e)
        {
            nameLable.ForeColor = SystemColors.ButtonShadow;
            addButton.Enabled = true;
            
        }

        private void A4tab6_Load(object sender, System.EventArgs e)
            => nameTextBox.Select();
    }
}
