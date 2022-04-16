using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BookMarket.Modules.Area7tab
{
    public partial class A7tab3 : AreaTab
    {
        // часть программы отвечающая за регистрацию новых пользователей 
         
        public A7tab3()
        {
            InitializeComponent();
            Init();
        }
        // необходимые обработчики
        private void addbutton_Click(object sender, EventArgs e) => Proof();
        private void A7tab3_Load(object sender, EventArgs e) => loginTextBox.Select();
        private void radioButton1_Leave(object sender, EventArgs e) { 
            foreach (RadioButton i in buttItem) 
                i.ForeColor = Color.Azure; 
        }
        private void repeatPasswordTextBox_TextChanged(object sender, EventArgs e) { 
            foreach (Label i in descItem) 
                i.ForeColor = SystemColors.ButtonShadow; 
            addButton.Enabled = true; 
        }
        private void radioButton1_MouseClick(object sender, MouseEventArgs e) { 
            foreach (RadioButton i in buttItem) 
                i.Checked = false; 
            (sender as RadioButton).Checked = true; 
            addButton.Enabled = true; 
        }
        private void radioButton1_Enter(object sender, EventArgs e) { 
            foreach (RadioButton i in buttItem) 
                i.ForeColor = Color.Azure; 
            (sender as RadioButton).ForeColor = Color.LightSeaGreen; 
        }
        private void checkedChange(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space && (sender as RadioButton).Checked == false)
            {
                foreach (RadioButton i in buttItem)
                    i.Checked = false;
                addButton.Enabled = true;
                (sender as RadioButton).Checked = true;
                levelLable.ForeColor = SystemColors.ButtonShadow;
            }
        }
        Label[] descItem;
        TextBox[] inputItem;
        RadioButton[] buttItem;
        int acclevel;


        private void Init()
        {
            radioButton1.KeyDown += new KeyEventHandler(checkedChange);
            radioButton2.KeyDown += new KeyEventHandler(checkedChange);
            radioButton3.KeyDown += new KeyEventHandler(checkedChange);
            loginTextBox.MaxLength = passwordTextBox.MaxLength = repeatPasswordTextBox.MaxLength = 13;

            descItem = new Label[3] { loginLabel, passLabel, repeatPassLabel };
            buttItem = new RadioButton[3] { radioButton1, radioButton2, radioButton3 };
            inputItem = new TextBox[3] { loginTextBox, passwordTextBox, repeatPasswordTextBox };

            List<Control> controls = new List<Control>();
            controls.AddRange(inputItem);
            controls.AddRange(buttItem);
            controls.Add(addButton);
            new AppExFocus().ForFocusChanget(controls);

        }
        // проверка валидности данных
        private bool helpUser()
        {
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                if (inputItem[i].Text == string.Empty) { descItem[i].ForeColor = Color.Maroon; inputItem[i].Select(); break; }
                if (i == 2)
                {
                    count += 1;
                    foreach (RadioButton j in buttItem)
                    {
                        if (j.Checked == true)
                        {
                            count += 1; levelLable.ForeColor = SystemColors.ButtonShadow;
                            if (inputItem[1].Text == inputItem[2].Text) count += 1;
                            else { descItem[1].ForeColor = descItem[2].ForeColor = Color.Maroon; inputItem[1].Select(); }
                            break;
                        }
                        else { levelLable.ForeColor = Color.Maroon; radioButton1.Select(); }
                    }
                }
            }
            if (count == 3) return true;
            else { addButton.Enabled = false; return false; }
        }
        // общая проверка и регистрация пользователя
        private void Proof()
        {
            if (helpUser())
            {
                DataBase db = new DataBase();
                if (userExists())
                {
                    new ErrorForm("Такой пользователь уже существует", 1).Show();
                    loginTextBox.Text = string.Empty; descItem[0].ForeColor = Color.Maroon;
                    return;
                }
                MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `accessLevel`) VALUES (@login, @pass, @accessLevel);", db.GetConnection());
                command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginTextBox.Text;
                command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = Encoder.getHash(passwordTextBox.Text);
                command.Parameters.Add("@accessLevel", MySqlDbType.Int32).Value = acclevel;
                if (db.Request(command))
                {
                    new LoadForm("Добавление пользователя.").Show();
                    exitButton.PerformClick();
                }
                else new ErrorForm("Ошибка регистрации. Пользователь не добавлен. \n Не удалось выполнить запрос к базе данных.", 1).Show();
            }
        }

        // поиск совпадений 
        private bool userExists()
        {
            DataBase db = new DataBase();
            MySqlCommand comand = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @LG", db.GetConnection());
            comand.Parameters.Add("@LG", MySqlDbType.Text).Value = loginTextBox.Text;
            DataTable table = db.RequestTable(comand);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }

        private void showIconClick(object sender, EventArgs e)
        {
            if ((sender as PictureBox).Name == "pictureBox1")
            {
                if (passwordTextBox.UseSystemPasswordChar == true) { passwordTextBox.UseSystemPasswordChar = false; pictureBox1.Image = Properties.Resources.EyeE; }
                else { passwordTextBox.UseSystemPasswordChar = true; pictureBox1.Image = Properties.Resources.Eye; }
            }
            else
            {
                if (repeatPasswordTextBox.UseSystemPasswordChar == true) { repeatPasswordTextBox.UseSystemPasswordChar = false; pictureBox2.Image = Properties.Resources.EyeE; }
                else { pictureBox2.Image = Properties.Resources.Eye; repeatPasswordTextBox.UseSystemPasswordChar = true; }
            }
        }
        // получения выбранного пользователоем при регистрации уровня доступа нового (регистрируюмого пользователя)
        private void checedChangetForAllradioButton(object sender, EventArgs e)
        {
            switch ((sender as RadioButton).TabIndex)
            {
                case 90: acclevel = 3; break;
                case 91: acclevel = 2; break;
                case 92: acclevel = 1; break;
            }
        }

        private void A7tab3_Load_1(object sender, EventArgs e) => loginTextBox.Select();
    }
}
