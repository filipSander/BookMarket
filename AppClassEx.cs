using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace BookMarket
{
    // классы расширения приложения
    static class AppClassEx
    {
        // статичный метод для разворачивания пользовательского элемента управления (исполняемой части программы по типу Area)
        public static void TabInit(UserControl tab, Panel container)
        {
            tab.Dock = DockStyle.Fill;
            container.Controls.Clear();
            container.Controls.Add(tab);
            tab.BringToFront();
        }
    }

    #region -- Смена фокуса контролов --
    class AppExFocus
    {
        private  List<Control> ctr;
        public  void ForFocusChanget(List<Control> controls)
        {
            int i = 0;
            foreach (Control control in controls)
            {
                control.KeyDown += Control_KeyDown;
                control.KeyPress += Control_KeyPress;
                control.Tag = i.ToString();
                i++;
            }
            ctr = controls;
            if (ctr[ctr.Count - 1].GetType().ToString() == "System.Windows.Forms.Button")
            {
                ctr[ctr.Count - 1].Enter += lastButtEnter;
                ctr[ctr.Count - 1].Leave += AppClassEx_Leave;
            }


        }
        private  void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int _sender = 0;
                switch (sender.GetType().ToString())
                {
                    case "System.Windows.Forms.RadioButton":
                        _sender = Convert.ToInt32((sender as RadioButton).Tag);
                        break;
                    case "System.Windows.Forms.TextBox":
                        _sender = Convert.ToInt32((sender as TextBox).Tag);
                        break;
                    case "System.Windows.Forms.Button":
                        _sender = Convert.ToInt32((sender as Button).Tag);
                        break;
                    case "System.Windows.Forms.ComboBox":
                        _sender = Convert.ToInt32((sender as ComboBox).Tag);
                        break;
                    case "System.Windows.Forms.RichTextBox":
                        _sender = Convert.ToInt32((sender as RichTextBox).Tag);
                        break;
                }
                if (_sender < ctr.Count - 1)
                    ctr[_sender + 1].Select();
            }
        }
        private  void AppClassEx_Leave(object sender, EventArgs e)
            =>  (sender as Button).BackColor = Color.FromArgb(48, 56, 65);
        private  void lastButtEnter(object sender, EventArgs e)
            =>  (sender as Button).BackColor = Color.DarkSlateGray;
        private void Control_KeyPress(object sender, KeyPressEventArgs e) 
            =>  e.Handled = e.KeyChar == 13;
    }
    #endregion

    #region -- Хэш кодировщик --
    public static class Encoder
    {
        private static byte[] hash(string input)
        {
            var sha1 = SHA1.Create();
            var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
            return hash;
        }
        public static string getHash(string ipt)
        {
            return Convert.ToBase64String(hash(ipt));
        }
    }
    #endregion

    #region -- Объект сериализации --
    [Serializable]
    public class ConnInfo
    {
        public List<string> info = new List<string>();
    }
    #endregion
    
    #region -- Сериализатор --
    static class Serializator
    {
        private static string saveFileName = "info.xml";
        private static ConnInfo _load()
        {
            if (File.Exists(saveFileName))
            {
                XmlSerializer xml = new XmlSerializer(typeof(ConnInfo));
                using (FileStream fs = new FileStream(saveFileName, FileMode.Open))
                    return (ConnInfo)xml.Deserialize(fs);
            }
            else return null;
        }

        private static void _save(ConnInfo info)
        {
            if (File.Exists(saveFileName))
                File.Delete(saveFileName);
            XmlSerializer xml = new XmlSerializer(typeof(ConnInfo));
            using (FileStream fs = new FileStream(saveFileName, FileMode.Create))
                xml.Serialize(fs, info);
        }

        public static ConnInfo loadProperty()
        {
            return _load();
        }
        public static void saveProperty(ConnInfo info)
            => _save(info);
    }
    #endregion 
}