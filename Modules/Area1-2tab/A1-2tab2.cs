using BookMarket.CustomControl;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BookMarket.Modules.Area1tab
{
    public partial class A12tab2 : Area
    {

        // модификация конструктора рабочей области для работы с вызывающей рабочей областью A12tab1
        A12tab1 main;
        public A12tab2(A12tab1 owner)
        {
            InitializeComponent();
            main = owner;
            Init();
        }

        // инициализация рабочей области
        private void Init()
            => reloadPage();


        // лист пользовательских элементов управления (далее кастомных элементов управления.) хранящий асортимент имеющихся товаров в бд
        List<ProdItemMini> productAsrt;
        // получение имеющихся товаров и их вывод 
        private void checkProductAsrt(string name)
        {
            flowContainer0.Controls.Clear();
            DataBase db = new DataBase();
            MySqlCommand command;
            
            
            string req = main.IsArea2 ? "SELECT `ProductID`, `Name` FROM `Product` where `CountStock` > 0" : "SELECT `ProductID`, `Name` FROM `Product`";
            if (name != string.Empty) req += main.IsArea2 ? $" and `Name` LIKE '{name}%'" : $" WHERE `Name` LIKE '{name}%'";
           


            command = new MySqlCommand(req, db.GetConnection());
            DataTable table = db.RequestTable(command);

            if (table.Rows.Count > 0)
            {
                int ofset = 0;
                productAsrt = new List<ProdItemMini>();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    ProdItemMini temp = new ProdItemMini();
                    int ProduuctID = table.Rows[i].Field<int>("ProductID");

                    temp.Title = table.Rows[i].Field<string>("Name");
                    temp.IcomButt.Image = Properties.Resources.add;

                    temp.IcomButt.Click += selectProduct;
                    temp.IcomButt.Tag = ProduuctID;

                    temp.Dock = DockStyle.Top;
                    temp.Location = new Point(0, 0 + ofset);
                    ofset += temp.Height;

                    if (main.ProductID.Count > 0)
                        for (int j = 0; j < main.ProductID.Count; j++)
                            if (ProduuctID == main.ProductID[j]) temp.Visible = false;
                    
                        
                    productAsrt.Add(temp);
                }

                foreach (ProdItemMini i in productAsrt)
                    flowContainer0.Controls.Add(i);
            }
            else
            {
                Label lbl = new Label();
                lbl.Text = "Не найдено!";
                flowContainer0.Controls.Add(lbl);
            }
        }

        // обработчик события выбора продукта 
        private void selectProduct(object sender, EventArgs e)
        {
            main.ProductID.Add((int)(sender as PictureBox).Tag);
            reloadPage();
        }

        // лист хранящий выбранные продукты
        List<ProdItemMini> selectedProduct;
        // получение и отображение выбранных продуктов
        private void checkSelectedProduct()
        {
            flowContainer1.Controls.Clear();
            selectedProduct = new List<ProdItemMini>();
            if(main.ProductID.Count > 0)
            { 
                int ofset = 0;
                for (int i = 0; i < main.ProductID.Count; i++)
                {
                    DataBase db = new DataBase();
                    MySqlCommand command = new MySqlCommand("SELECT * FROM `product` where `ProductID` = @ID", db.GetConnection());
                    command.Parameters.Add("@ID", MySqlDbType.Int32).Value = main.ProductID[i];
                    DataTable table = db.RequestTable(command);

                    if(table.Rows.Count > 0)
                    {
                        ProdItemMini temp = new ProdItemMini();
                        int ProduuctID = table.Rows[0].Field<int>("ProductID");

                        temp.Title = table.Rows[0].Field<string>("Name");
                        temp.IcomButt.Image = Properties.Resources.delete;

                        temp.IcomButt.Click += unSelectedproduct;
                        temp.IcomButt.Tag = ProduuctID;

                        temp.Dock = DockStyle.Top;
                        temp.Location = new Point(0, 0 + ofset);
                        ofset += temp.Height;


                        selectedProduct.Add(temp);
                    }

                }
                foreach (ProdItemMini i in selectedProduct)
                    flowContainer1.Controls.Add(i);

            }
            else
            {
                Label lbl = new Label();
                lbl.Text = "Не выбрано!";
                flowContainer1.Controls.Add(lbl);
            }
        }

        // метод модификации запроса вывода осортимента продуктов (поиск)
        private void reloadPage()
        {
            checkProductAsrt(search.Text);
            checkSelectedProduct();
            main.CheckSelected();
        }
        // медод удаления из выбранных продуктов
        private void unSelectedproduct(object sender, EventArgs e)
        {
            main.ProductID.Remove((int)(sender as PictureBox).Tag);
            reloadPage();
        }


        // необходимые рабочей области методы / обработчики событий
        private void A1tab2_Resize(object sender, EventArgs e)
        {
            flowContainer0.Height = flowContainer1.Height =  Height - 220;
            bgFlow0.Height = bgFlow1.Height = Height - 212;
        }
        private void search_TextChanged(object sender, EventArgs e)
            => checkProductAsrt(search.Text);
    }
}
