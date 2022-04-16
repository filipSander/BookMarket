using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BookMarket.Modules.Area7tab
{
    public partial class A7tab2 : AreaTab
    {
        // часть программы отвечающая за отображения и обновления данных для подключения к бд 
        public A7tab2()
        {
            InitializeComponent();
            Init();
        }

      
        ConnInfo sInfo;
        Label[] descItems;
        TextBox[] inputItems;

        void Init()
        {
            inputItems = new TextBox[] { serverTextBox, portTextBox, loginTextBox, passTextBox, nameDBTextBox };
            descItems = new Label[] { serverLabel, portLabel, loginLabel, passLabel, nameDBLabel };
            foreach (TextBox i in inputItems)
                i.TextChanged += new EventHandler(tcAllTextBox);
            sInfo = new ConnInfo();


            List<Control> controls = new List<Control>();
            controls.AddRange(inputItems);
            controls.Add(reloadButton);
            // использование класса расширения
            new AppExFocus().ForFocusChanget(controls);

            InitProperty();
        }
        // десериализация данных из файла info.xml (при его наличии) и их отображение
        void InitProperty()
        {
            ConnInfo _property = Serializator.loadProperty();
            if (_property == null)
                return;
            int i = 0;
            foreach (string s in _property.info)
            {
                inputItems[i].Text = s;
                i++;
            }
        }

        // сериализация данных 
        private void reloadButton_Click(object sender, EventArgs e)
        {
            foreach (TextBox i in inputItems)
                if (i.Text == string.Empty)
                {
                    descItems[Convert.ToInt32(i.Tag)].ForeColor = Color.Maroon;
                    return;
                }
            foreach (TextBox i in inputItems)
                sInfo.info.Add(i.Text);
            Serializator.saveProperty(sInfo);
            new LoadForm("Обновление данных.").Show();
        }

        // необходимые обработчики 
        private void tcAllTextBox(object sender, EventArgs e) { foreach (Label i in descItems) i.ForeColor = SystemColors.ButtonShadow; }
        private void pictureBox1_Click(object sender, EventArgs e) { if (passTextBox.UseSystemPasswordChar == true) { passTextBox.UseSystemPasswordChar = false; pictureBox1.Image = Properties.Resources.EyeE; } else { passTextBox.UseSystemPasswordChar = true; pictureBox1.Image = Properties.Resources.Eye; } }

        private void A7tab2_Load(object sender, EventArgs e) => serverTextBox.Select();
    }
}
