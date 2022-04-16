using BookMarket.CustomControl;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BookMarket.Modules.Area1tab
{
    public partial class A12tab1 : Area
    {
        public A12tab1()
        {
            InitializeComponent();
            Init();
        }

        public bool IsArea2;
        public A12tab1(bool _isArea2)
        {
            InitializeComponent();
            IsArea2 = true;
            Init();
        }



        public List<int> ProductID; // публичный лист хранящий ID выбраных продуктов
        private void Init()
        {
            tbDate.Text = Convert.ToString(DateTime.Today.ToLongDateString());
            
            tbDate.KeyPress += notUsingTbKeyPress;
            tbFullPrice.KeyPress += notUsingTbKeyPress;
            ctagent.KeyPress += notUsingTbKeyPress;
            ctagent.Text = String.Empty;
            ProductID = new List<int>();
            if (IsArea2)
            {
                lblTitle.Text = "Продажа товара";
                lblDesc.Text = AddButton.Text = "Состав продажи";
                lblCa.Text = "Покупатель";
            }

            CheckSelected();
            checkCtagent();
        }

        private bool onProofError(string errorDesc)
        {
            new ErrorForm(errorDesc, 1).Show();
            return false;
        }

        private bool proof()
        {
            if(ctagent.Items.Count == 0)
                return onProofError("Не найдено ни одного контрагента");

            if (ctagent.Text == String.Empty)
                return onProofError("Не выбран контрагент");

            if (ProductID.Count == 0)
                return onProofError("Не выбран товар");

            return true;
        }
        private void save()
        {
            if (proof())
            {
                DataBase db = new DataBase();
                MySqlCommand command = null;
                int rowID = 0;
                if (IsArea2)
                {
                    rowID = db.GetID("realizationgoods", "RealizationID");
                    command = new MySqlCommand("INSERT INTO `realizationgoods` (`RealizationID`, `Date`, `Sum`, `CounterpartyID`)" +
                        " VALUES (@id, @date, @summ, @counterpartyID);", db.GetConnection());
                }
                else
                {
                    rowID = db.GetID("arrivalgoods", "ArrivalID");
                    command = new MySqlCommand("INSERT INTO `arrivalgoods` (`ArrivalID`, `Date`, `Sum`, `CounterpartyID`)" +
                        " VALUES (@id, @date, @summ, @counterpartyID);", db.GetConnection());
                }

                command.Parameters.Add("@id", MySqlDbType.Int32).Value = rowID;
                command.Parameters.Add("@date",MySqlDbType.VarChar).Value = tbDate.Text;
                command.Parameters.Add("@summ", MySqlDbType.Int32).Value = fullPrice;
                command.Parameters.Add("@counterpartyID", MySqlDbType.Int32).Value = getContrapartyID(ctagent.Text);
                if (db.Request(command))
                {
                    foreach (ProdItemReg i in selectedProduct)
                        if (createContentsdelivery(rowID, (int)i.Tag, i.Count, i.TotalPrice))
                            inStockTranzaction((int)i.Tag, i.Count);
                    new LoadForm("Запись добавленна.").Show();
                }
                else new ErrorForm("Произошла ошибка", 1).Show();
                Init();
            }
        }

        private void inStockTranzaction(int productID, int count)
        {
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("UPDATE `product` SET `CountStock` = @count WHERE `product`.`ProductID` = @id;", db.GetConnection());
            command.Parameters.Add("@count", MySqlDbType.Int32).Value = IsArea2 ? returnCountInStock(productID) - count : returnCountInStock(productID) + count;
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = productID;
            db.Request(command);
        }

        private int returnCountInStock(int productID)
        {
            int count = 0;
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("SELECT `CountStock` FROM `product` WHERE `product`.`ProductID` = @id;", db.GetConnection());
            command.Parameters.Add("id",MySqlDbType.Int32).Value = productID;
            DataTable table = db.RequestTable(command);
            if(table.Rows.Count > 0)
            {
                count += table.Rows[0].Field<int>("CountStock");
            }
            return count;
        }

        private bool createContentsdelivery(int arrivalID, int productID, int count, int summ)
        {
            DataBase db = new DataBase();
            MySqlCommand command = null;

            if (IsArea2)
            {
                command = new MySqlCommand("INSERT INTO `compositionregistration` (`RelationID`, `RealizationID`, `ProductID`, `Count`, `Summ`)" +
                    " VALUES (@id, @arricalID, @productID, @count, @summ);", db.GetConnection());
            }
            else
            {
                command = new MySqlCommand("INSERT INTO `contentsdelivery` (`RelationID`, `ArrivalID`, `ProductID`, `Count`, `Summ`)" +
                    " VALUES (@id, @arricalID, @productID, @count, @summ);", db.GetConnection());
            }

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = IsArea2 ? db.GetID("compositionregistration", "RelationID") : db.GetID("contentsdelivery", "RelationID");
            command.Parameters.Add("@arricalID", MySqlDbType.Int32).Value = arrivalID;
            command.Parameters.Add("@productID", MySqlDbType.Int32).Value = productID;
            command.Parameters.Add("@count", MySqlDbType.Int32).Value = count;
            command.Parameters.Add("@summ", MySqlDbType.Int32).Value = summ;
            return db.Request(command);
        }

        private int getContrapartyID(string name)
        {
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("SELECT `CounterpartyID` from `counterparty` WHERE `Name` = @name", db.GetConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            DataTable table = db.RequestTable(command);
            return table.Rows[0].Field<int>("CounterpartyID");
        }

        private void checkCtagent() 
        {
            ctagent.Text = String.Empty;
            ctagent.Items.Clear();
            ctagent.ForeColor = Color.Azure;

            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `counterparty` where `Type` = @type", db.GetConnection());
            command.Parameters.Add("@type", MySqlDbType.VarChar).Value = IsArea2 ? "Клиент" : "Поставщик";
            DataTable table = db.RequestTable(command);

            if(table.Rows.Count > 0)
                for(int i = 0; i < table.Rows.Count; i++)
                    ctagent.Items.Add( table.Rows[i].Field<string>("Name"));
            else
            {
                ctagent.Text = "Не найденно";
                ctagent.ForeColor  = Color.Red;
            }
        }

        public void CheckSelected()
        {
            checkSelectedProduct();
            countFullPrice();
        }

        List<ProdItemReg> selectedProduct; // лист храняший ID выбранных товаров
        private void checkSelectedProduct()
        {
            
            flowContainer.Controls.Clear();
            selectedProduct = new List<ProdItemReg>();                    
            int ofset = 0;

            if (ProductID.Count > 0)
            {
                for (int i = 0; i < ProductID.Count; i++)
                {
                    DataBase db = new DataBase();
                    MySqlCommand command = new MySqlCommand("SELECT * FROM `product` where `ProductID` = @ID", db.GetConnection());
                    command.Parameters.Add("@ID", MySqlDbType.Int32).Value = ProductID[i];
                    DataTable table = db.RequestTable(command);
                    if (table.Rows.Count > 0)
                    {
                        ProdItemReg temp = new ProdItemReg();
                        int ProduuctID = table.Rows[0].Field<int>("ProductID");

                        temp.Title = table.Rows[0].Field<string>("Name");
                        temp.Units = table.Rows[0].Field<string>("UMeasurement");
                        temp.Price = IsArea2 ? table.Rows[0].Field<int>("PriceRealizations") : table.Rows[0].Field<int>("purchasePrice");

                        if (IsArea2) temp.NumUpDownCount.Maximum = returnCountInStock(ProduuctID);
                        temp.NumUpDownCount.Tag = i;
                        temp.Tag = ProduuctID;
                        

                        temp.Dock = DockStyle.Top;
                        temp.Location = new Point(0, 0 + ofset);
                        ofset += temp.Height;

                        temp.NumUpDownCount.ValueChanged += numUpDownCount_ValueChanged;
                        selectedProduct.Add(temp);
                        
                        temp.Count = 1;
                    }
                }
                foreach (ProdItemReg i in selectedProduct)
                    flowContainer.Controls.Add(i);
            }
            else
            {
                Label lbl = new Label();
                lbl.Text = "Не выбрано!";
                flowContainer.Controls.Add(lbl);
            }
        }

        int fullPrice;  // цена всех выбранных товаров
        private void countFullPrice()
        {
            fullPrice = 0;
            for (int i = 0; i < selectedProduct.Count; i++)
                fullPrice += selectedProduct[i].TotalPrice;
            tbFullPrice.Text = fullPrice.ToString();
        }

        private void numUpDownCount_ValueChanged(object sender, EventArgs e)
        {
            int senderID = (int)(sender as NumericUpDown).Tag;
            selectedProduct[senderID].Count = (int)(sender as NumericUpDown).Value;
            selectedProduct[senderID].CountTotalPrice();
            countFullPrice();
        }

       private void A1tab1_Resize(object sender, EventArgs e)
       {
            flowContainer.Height = Height - 310;
            bgFlow.Height = Height - 302;
       }

        private void notUsingTbKeyPress(object sender, KeyPressEventArgs e)
            => e.Handled = true;

        private void ctagent_Click(object sender, EventArgs e)
            => checkCtagent();

        private void saveButton_Click(object sender, EventArgs e)
            => save();
    }
}