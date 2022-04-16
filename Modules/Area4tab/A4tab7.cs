using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BookMarket.Modules.Area4tab
{
    public partial class A4tab7 : AreaTab
    {
        // часть программы отвечающая за регистрацию товара

        public A4tab7()
        {
            InitializeComponent();
            Init();
        }

        List<Control> controls;
        CheckBox[] groups;
        private void Init()
        {
            groups = new CheckBox[0];
            CheckGroup();
            controls = new List<Control>();
            controls.AddRange(new Control[4] { nameProduct, pPrice, rPrice, uMeasurement });
            controls.Add(addButton);
            // применения класса расширения
            new AppExFocus().ForFocusChanget(controls);

            pPrice.KeyPress += Price_KeyPress;
            rPrice.KeyPress += Price_KeyPress;
            // Создание пустого списка групп
            
        }
        // запрет на ввод некоректных данных 
        private void Price_KeyPress(object sender, KeyPressEventArgs e)
            => e.Handled = !(e.KeyChar >= 48 && e.KeyChar <= 57);


        // отображенеи существующих групп
        private void CheckGroup()
        {
            flowContainer.Controls.Clear();
            // Запрос
            DataBase db = new DataBase();
            MySqlCommand comand = new MySqlCommand("SELECT * FROM `groupproduct`", db.GetConnection());
            DataTable table = db.RequestTable(comand);

            if (table.Rows.Count > 0)
            {
                groups = new CheckBox[table.Rows.Count];
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    CheckBox temp = new CheckBox();
                    temp.Text = table.Rows[i].Field<string>("Name");
                    temp.Tag = table.Rows[i].Field<int>("GroupID");

                    temp.Dock = DockStyle.Top;
                    temp.Margin = new Padding(0);
                    temp.Padding = new Padding(0);


                    groups[i] = temp;
                }
                foreach (CheckBox i in groups)
                    flowContainer.Controls.Add(i);
            }
            else
            {
                Label lbl = new Label();
                lbl.Text = "Не найдено!";
                flowContainer.Controls.Add(lbl);
            }

        }

        // пометка контролов с некоректной информацией
        private bool markInvalid(TextBox tb, Label label)
        {
            if (tb.Text == string.Empty)
            {
                label.ForeColor = Color.Maroon;
                tb.Select();
                addButton.Enabled = false;
                return true;
            }
            return false;
        }

        // проверка даннх на валидност 
        private void proof()
        {

            if (markInvalid(nameProduct, lblName))
                return;
            if (markInvalid(pPrice, lblPprice))
                return;
            if (markInvalid(rPrice, lblRprice))
                return;

            addProduct();
        }

        int tempProductID;      // ID создаваемой записи о продукте 

        private void addProduct()
        {
            DataBase db = new DataBase();

            if (productExist())
            {
                new ErrorForm("Такой продукт уже существует", 1).Show();
                lblName.ForeColor = Color.Maroon;
                nameProduct.Select();
                addButton.Enabled = false;
                return;
            }
            tempProductID = db.GetID("product", "ProductID");
            MySqlCommand command = new MySqlCommand("INSERT INTO `product` (`ProductID`, `Name`, `PurchasePrice`, `PriceRealizations`, `UMeasurement`)" + 
                " VALUES (@id, @name, @pPrice, @rPrice, @uM)", db.GetConnection());
            command.Parameters.Add("@ID", MySqlDbType.Int32).Value = tempProductID;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = nameProduct.Text;
            command.Parameters.Add("@pPrice", MySqlDbType.Int32).Value = Convert.ToInt32(pPrice.Text);
            command.Parameters.Add("@rPrice", MySqlDbType.Int32).Value = Convert.ToInt32(rPrice.Text);
            command.Parameters.Add("@uM", MySqlDbType.VarChar).Value = uMeasurement.Text;

            if (db.Request(command) && relationGroup())
            {
                new LoadForm("Добавление продукта.").Show();
                ExitButton.PerformClick();
            }
            else new ErrorForm("Ошибка регистрации. Продукт не добавлен. \nНе удалось выполнить запрос к базе данных.", 1).Show();

        }

        // создание связей товара с выбранными группами товара
        private bool relationGroup()
        {
            foreach (CheckBox c in groups)
            {
                if (c.Checked)
                {   
                    DataBase db = new DataBase();
                    MySqlCommand command = new MySqlCommand("INSERT INTO `productgroupproduct` (`GroupID`, `ProductID`, `СonnID`)" +
                        " VALUES (@groupID, @productID, @conID)", db.GetConnection());
                    command.Parameters.Add("@groupID", MySqlDbType.Int32).Value = Convert.ToInt32(c.Tag);
                    command.Parameters.Add("@productID", MySqlDbType.Int32).Value = tempProductID;
                    command.Parameters.Add("@conID", MySqlDbType.Int32).Value = db.GetID("productgroupproduct", "СonnID");
                    if (!db.Request(command)) return false;
                }
            }
            return true;
        }
        // проверка на совпадение названия с существующими товарами
        private bool productExist()
        {
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `product` WHERE `Name` = @NM", db.GetConnection());
            command.Parameters.Add("@NM", MySqlDbType.Text).Value = nameProduct.Text;
            DataTable table = db.RequestTable(command);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }

        public void LoadNewGroup()
            => CheckGroup();

        private void addButton_Click(object sender, System.EventArgs e)
            =>proof();

        private void nameProduct_TextChanged(object sender, System.EventArgs e)
        {
            lblName.ForeColor = lblPprice.ForeColor = lblRprice.ForeColor = SystemColors.ButtonShadow;
            addButton.Enabled = true;
        }

        private void A4tab7_Load(object sender, EventArgs e)
            => nameProduct.Select();

    }
}
