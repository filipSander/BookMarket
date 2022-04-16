using BookMarket.CustomControl;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BookMarket.Modules.Area4tab
{
    public partial class A4tab4 : AreaTab
    {
        // часть программы отвечающая за отображение и добавления  товара

        public A4tab4()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            flowContainer.AutoScrollMinSize = new Size(0, flowContainer.Height - 100);
            checkProduct();
        }

        private ProdItem[] product;
        // обращение к бд и отображенеи записей о товаре 
        private void checkProduct()
        {
            flowContainer.Controls.Clear();

            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `product`", db.GetConnection());
            DataTable table = db.RequestTable(command);

            if (table.Rows.Count > 0)
            {
                int ofset = 0;
               
                product = new ProdItem[table.Rows.Count];
                for (int i = 0; i < table.Rows.Count; i++)
                {   
                    ProdItem temp = new ProdItem();
                    int ProduuctID = table.Rows[i].Field<int>("ProductID");

                    temp.Title = table.Rows[i].Field<string>("Name");
                    temp.PurchasePrice = Convert.ToString(table.Rows[i].Field<int>("purchasePrice"));
                    temp.RealizationPrice = Convert.ToString(table.Rows[i].Field<int>("PriceRealizations"));
                    temp.UMeasurement = table.Rows[i].Field<string>("UMeasurement");

                    // получение групп продукта
                    #region -- Group --
                    #region -- ReturnGroupID --
                    MySqlCommand _returnGroupIDcomand = new MySqlCommand("SELECT `GroupID` FROM `productgroupproduct` WHERE `ProductID` = @ID", db.GetConnection());
                    _returnGroupIDcomand.Parameters.Add("@ID", MySqlDbType.Int32).Value = ProduuctID;
                    DataTable _GroupIDtable = db.RequestTable(_returnGroupIDcomand);
                    #endregion
                    #region -- ReturnGroupName --
                    for (int j = 0; j < _GroupIDtable.Rows.Count; j++)
                    {
                        MySqlCommand _returnGroupCommand = new MySqlCommand("SELECT `Name` FROM `groupproduct` WHERE `GroupID` = @ID", db.GetConnection());
                        _returnGroupCommand.Parameters.Add("@ID", MySqlDbType.Int32).Value = _GroupIDtable.Rows[j].Field<int>("GroupID"); ;
                        DataTable _returnGroupTable = db.RequestTable(_returnGroupCommand);
                        temp.Group += _returnGroupTable.Rows[0].Field<string>("Name") + " ";
                    }
                    #endregion
                    #endregion

                    temp.DeletePr.Click += DeletePr_Click;
                    temp.DeletePr.Tag = ProduuctID;

                    temp.Dock = DockStyle.Top;
                    temp.Location = new Point(0, 0 + ofset);
                    ofset += temp.Height;

                    product[i] = temp;
                }

                foreach (ProdItem i in product)
                    flowContainer.Controls.Add(i);
            }
            else
            {
                Label lbl = new Label();
                lbl.Text = "Не найдено!";
                flowContainer.Controls.Add(lbl);
            }
        }


        // удаление продукта
        private void DeletePr_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            int productID = Convert.ToInt32((sender as Button).Tag);

            if (db.СheckTableOwned("contentsdelivery", "ProductID", productID) || db.СheckTableOwned("compositionregistration", "ProductID", productID))
            {
                new ErrorForm("Этот товар нельзя удалить.\nИнформация о нем отражена в документации \n(Документах поставки или продажи)", 1).Show();
                return;
            }

            if (checkCountItems(productID) > 0)
                if (!deleteRelation(productID))
                {
                    new ErrorForm("Ошибка!.\nНе удалось выполнить запрос к базе данных.", 1).Show();
                    return;
                }
            
            MySqlCommand command = new MySqlCommand("DELETE FROM `product` WHERE `product`.`ProductID` = @id", db.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = productID;
            if (db.Request(command))
            {
                new LoadForm("Удаление продукта.").Show(); ;
                checkProduct();
            }
            else
                new ErrorForm("Ошибка!.\nНе удалось выполнить запрос к базе данных.", 1).Show();
        }

        // проверка существующих связей
        private int checkCountItems(int _groupID)
        {
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand($"SELECT COUNT(*) AS `COUNT` From `productgroupproduct` WHERE `ProductID` = @ID", db.GetConnection());
            command.Parameters.Add("@ID", MySqlDbType.Int32).Value = _groupID;
            DataTable table = db.RequestTable(command);
            return Convert.ToInt32(table.Rows[0].Field<Int64>("COUNT"));
        }

        // удаление связей
        private bool deleteRelation(int ProductID)
        {
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("DELETE FROM `productgroupproduct` WHERE `productgroupproduct`.`ProductID` = @id", db.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = ProductID;
            if (db.Request(command))
                return true;
            else
                new ErrorForm("Ошибка!.\nНе удалось выполнить запрос к базе данных.", 1).Show();
            return false;
        }

        private void A4tab4_Resize(object sender, EventArgs e)
            => flowContainer.Height = Height - 210;
    }
}
