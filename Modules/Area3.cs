using BookMarket.CustomControl;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace BookMarket.Modules
{
    public partial class Area3 : Area
    {
        public Area3()
        {
            InitializeComponent();
            Init();
        }


        private void Init()
        {
            checkProduct(string.Empty);
        }

        private void checkProduct(string name)
        {
            flowContainer.Controls.Clear();
            DataBase db = new DataBase();
            string req = "SELECT `Name`, `CountStock`,`UMeasurement` FROM `Product` WHERE `CountStock` > 0 ";
            if(name != string.Empty) req += $" AND  `Name` LIKE '{name}%'";
            MySqlCommand command = new MySqlCommand(req, db.GetConnection());
            DataTable table = db.RequestTable(command);

            if (table.Rows.Count > 0)
            {
                for(int i = 0; i < table.Rows.Count; i++)
                {
                    GroupItem temp = new GroupItem();
                    temp.Title = table.Rows[i].Field<string>("Name");
                    temp.Count = table.Rows[i].Field<int>("CountStock").ToString();
                    temp.Count += " " + table.Rows[i].Field<string>("UMeasurement");
                    temp.DeleteGr.Visible = false;
                    temp.Width = 433;
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

        private void Area3_Resize(object sender, EventArgs e)
            => flowContainer.Height = Height - 210;

        private void search_TextChanged(object sender, EventArgs e)
            => checkProduct(search.Text);

        private void pictureBox1_Click(object sender, EventArgs e)
            => checkProduct(string.Empty);
    }
}
