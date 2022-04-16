namespace BookMarket.CustomControl
{
    partial class ProdItem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Pprice = new System.Windows.Forms.Label();
            this.Rprice = new System.Windows.Forms.Label();
            this.UM = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DeletePr = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbGroup = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 1);
            this.panel1.TabIndex = 11;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName.Location = new System.Drawing.Point(6, 29);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(43, 17);
            this.lbName.TabIndex = 12;
            this.lbName.Text = "Name";
            this.lbName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbName_MouseClick);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, -15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Цена закупки :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Цена реализации :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ед. измерения :";
            // 
            // Pprice
            // 
            this.Pprice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Pprice.AutoSize = true;
            this.Pprice.Location = new System.Drawing.Point(128, -15);
            this.Pprice.Name = "Pprice";
            this.Pprice.Size = new System.Drawing.Size(79, 13);
            this.Pprice.TabIndex = 16;
            this.Pprice.Text = "Цена закупки";
            this.Pprice.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbName_MouseClick);
            // 
            // Rprice
            // 
            this.Rprice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Rprice.AutoSize = true;
            this.Rprice.Location = new System.Drawing.Point(128, 7);
            this.Rprice.Name = "Rprice";
            this.Rprice.Size = new System.Drawing.Size(101, 13);
            this.Rprice.TabIndex = 17;
            this.Rprice.Text = "Цена реализации";
            this.Rprice.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbName_MouseClick);
            // 
            // UM
            // 
            this.UM.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UM.AutoSize = true;
            this.UM.Location = new System.Drawing.Point(128, 31);
            this.UM.Name = "UM";
            this.UM.Size = new System.Drawing.Size(84, 13);
            this.UM.TabIndex = 18;
            this.UM.Text = "Ед. измерения";
            this.UM.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbName_MouseClick);
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
            this.button1.TabIndex = 20;
            this.button1.Tag = "control7";
            this.button1.Text = "Инфо?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeletePr
            // 
            this.DeletePr.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DeletePr.FlatAppearance.BorderSize = 0;
            this.DeletePr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.DeletePr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeletePr.Location = new System.Drawing.Point(482, 40);
            this.DeletePr.Name = "DeletePr";
            this.DeletePr.Size = new System.Drawing.Size(83, 31);
            this.DeletePr.TabIndex = 19;
            this.DeletePr.Tag = "control7";
            this.DeletePr.Text = "Удалить";
            this.DeletePr.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbGroup);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Rprice);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.UM);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Pprice);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(575, 79);
            this.panel2.TabIndex = 21;
            this.panel2.Visible = false;
            // 
            // lbGroup
            // 
            this.lbGroup.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbGroup.AutoSize = true;
            this.lbGroup.Location = new System.Drawing.Point(128, 55);
            this.lbGroup.Name = "lbGroup";
            this.lbGroup.Size = new System.Drawing.Size(160, 13);
            this.lbGroup.TabIndex = 20;
            this.lbGroup.Text = "Не принадлежит ни к одной";
            this.lbGroup.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbName_MouseClick);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Группы :";
            // 
            // ProdItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(65)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DeletePr);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Azure;
            this.Name = "ProdItem";
            this.Size = new System.Drawing.Size(575, 80);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Pprice;
        private System.Windows.Forms.Label Rprice;
        private System.Windows.Forms.Label UM;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button DeletePr;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbGroup;
        private System.Windows.Forms.Label label5;
    }
}
