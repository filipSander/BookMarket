namespace BookMarket.CustomControl
{
    partial class CaItem
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.type = new System.Windows.Forms.Label();
            this.form = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.contactPhone = new System.Windows.Forms.Label();
            this.requisites = new System.Windows.Forms.Label();
            this.DeleteCA = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.address = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.type.Location = new System.Drawing.Point(0, 10);
            this.type.Margin = new System.Windows.Forms.Padding(0);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(27, 13);
            this.type.TabIndex = 0;
            this.type.Text = "Тип";
            this.type.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label_MouseClick);
            // 
            // form
            // 
            this.form.AutoSize = true;
            this.form.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.form.Location = new System.Drawing.Point(0, 54);
            this.form.Margin = new System.Windows.Forms.Padding(0);
            this.form.Name = "form";
            this.form.Size = new System.Drawing.Size(42, 13);
            this.form.TabIndex = 1;
            this.form.Text = "Форма";
            this.form.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label_MouseClick);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.name.Location = new System.Drawing.Point(0, 33);
            this.name.Margin = new System.Windows.Forms.Padding(0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(88, 13);
            this.name.TabIndex = 2;
            this.name.Text = "Наименование";
            this.name.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label_MouseClick);
            // 
            // contactPhone
            // 
            this.contactPhone.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.contactPhone.AutoSize = true;
            this.contactPhone.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.contactPhone.Location = new System.Drawing.Point(146, 33);
            this.contactPhone.Margin = new System.Windows.Forms.Padding(10);
            this.contactPhone.Name = "contactPhone";
            this.contactPhone.Size = new System.Drawing.Size(54, 13);
            this.contactPhone.TabIndex = 4;
            this.contactPhone.Text = "Телефон";
            this.contactPhone.Visible = false;
            this.contactPhone.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label_MouseClick);
            // 
            // requisites
            // 
            this.requisites.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.requisites.AutoSize = true;
            this.requisites.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.requisites.Location = new System.Drawing.Point(146, 10);
            this.requisites.Margin = new System.Windows.Forms.Padding(10);
            this.requisites.Name = "requisites";
            this.requisites.Size = new System.Drawing.Size(45, 13);
            this.requisites.TabIndex = 5;
            this.requisites.Text = "Банков";
            this.requisites.Visible = false;
            this.requisites.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label_MouseClick);
            // 
            // DeleteCA
            // 
            this.DeleteCA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DeleteCA.FlatAppearance.BorderSize = 0;
            this.DeleteCA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.DeleteCA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteCA.Location = new System.Drawing.Point(482, 40);
            this.DeleteCA.Name = "DeleteCA";
            this.DeleteCA.Size = new System.Drawing.Size(83, 31);
            this.DeleteCA.TabIndex = 6;
            this.DeleteCA.Tag = "control7";
            this.DeleteCA.Text = "Удалить";
            this.DeleteCA.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 1);
            this.panel1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(482, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 29);
            this.button1.TabIndex = 7;
            this.button1.Tag = "control7";
            this.button1.Text = "Инфо?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // address
            // 
            this.address.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(146, 54);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(38, 13);
            this.address.TabIndex = 18;
            this.address.Text = "Адрес";
            this.address.Visible = false;
            this.address.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label_MouseClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Адрес :";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Location = new System.Drawing.Point(0, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Контактный телефон :";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label3.Location = new System.Drawing.Point(0, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Банк. реквизиты :";
            this.label3.Visible = false;
            // 
            // A4agItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(65)))));
            this.Controls.Add(this.form);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.type);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.address);
            this.Controls.Add(this.contactPhone);
            this.Controls.Add(this.requisites);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DeleteCA);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Azure;
            this.Name = "A4agItem";
            this.Size = new System.Drawing.Size(575, 80);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Label form;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label contactPhone;
        private System.Windows.Forms.Label requisites;
        public System.Windows.Forms.Button DeleteCA;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
