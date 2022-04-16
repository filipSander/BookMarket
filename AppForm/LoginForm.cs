using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BookMarket
{
    public partial class login : Form
    {

        // форма для регистрации 
        public login()
        {
            InitializeComponent();
            Init();
            Hide(); new MainForm(1).Show();
        }

        // Инифиализация формы
        private void Init()
        {
            loginTextBox.MaxLength = passwordTextBox.MaxLength = 13;
            label1.ForeColor = label2.ForeColor = ColorTranslator.FromHtml("#939393");
            
            loginTextBox.Select();
            question.Click += new EventHandler(question_click);
            buttonApply.Click += new EventHandler(buttonApply_Click);

            List<Control> controls = new List<Control>();
            controls.AddRange(new Control[3]{loginTextBox, passwordTextBox,buttonApply});
            new AppExFocus().ForFocusChanget(controls);
        }


       
        async private void  helpUser(int er)
        {
            switch (er)
            {
                case 1:
                    label1.ForeColor = Color.Maroon;
                    buttonApply.Enabled = false;
                    loginTextBox.Select();
                    break;
                case 2:
                   label2.ForeColor = Color.Maroon;
                    buttonApply.Enabled = false;
                    passwordTextBox.Select();
                    break;
                case 3:
                    label1.ForeColor = label2.ForeColor = Color.Maroon;
                    buttonApply.Enabled = false;
                    loginTextBox.Select();
                    break;
            }
            question.Visible = true;
            question.Image = Properties.Resources.qpng;
            await Task.Delay(150);
            question.Image = Properties.Resources.qusgif;
            await Task.Delay(4550);
            question.Image = Properties.Resources.qpng;
        }
        // проверка валидности 
        private void proof()
        {
            if (loginTextBox.Text == string.Empty) helpUser(1);
            else
            {
                if (passwordTextBox.Text == string.Empty) helpUser(2);
                else
                {
                    DataBase db = new DataBase();
                    MySqlCommand comand = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @LG AND `password` = @PS", db.GetConnection());
                    comand.Parameters.Add("@LG", MySqlDbType.Text).Value = loginTextBox.Text;
                    comand.Parameters.Add("@PS", MySqlDbType.Text).Value = Encoder.getHash(passwordTextBox.Text);
                    DataTable table = db.RequestTable(comand);
                    if (table.Rows.Count > 0)
                    {
                        MainForm main = new MainForm(table.Rows[0].Field<int>("accessLevel"));
                        Hide(); main.Show();
                    }
                    else helpUser(3);
                }
            }   
        }


        // необходимые обработчики 
        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {
            label1.ForeColor = label2.ForeColor = ColorTranslator.FromHtml("#939393");
            buttonApply.Enabled = true;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(passwordTextBox.UseSystemPasswordChar == true) { passwordTextBox.UseSystemPasswordChar = false;  pictureBox2.Image = Properties.Resources.EyeE; }
            else { passwordTextBox.UseSystemPasswordChar = true; pictureBox2.Image = Properties.Resources.Eye; }
        }
        private void buttonApply_Click(object sender, EventArgs e) => proof();
        private void question_click(object sender, EventArgs e) { QuestionForm qurst = new QuestionForm(); qurst.Show(); }
        private void buttonApply_KeyDown(object sender, KeyEventArgs e) { if (e.KeyCode == Keys.Enter) buttonApply.PerformClick(); }
    }
}
