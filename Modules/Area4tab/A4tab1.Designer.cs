namespace BookMarket.Modules.Area4tab
{
    partial class A4tab1
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
            this.label6 = new System.Windows.Forms.Label();
            this.flowContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.levelLable = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Lavender;
            this.label6.Location = new System.Drawing.Point(13, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 21);
            this.label6.TabIndex = 45;
            this.label6.Text = "Контрагенты";
            // 
            // flowContainer
            // 
            this.flowContainer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowContainer.Location = new System.Drawing.Point(45, 56);
            this.flowContainer.Name = "flowContainer";
            this.flowContainer.Size = new System.Drawing.Size(600, 510);
            this.flowContainer.TabIndex = 46;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(45, 602);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 85);
            this.panel2.TabIndex = 55;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(65)))));
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton5);
            this.panel1.Controls.Add(this.radioButton6);
            this.panel1.Location = new System.Drawing.Point(116, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 75);
            this.panel1.TabIndex = 39;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.FlatAppearance.BorderSize = 0;
            this.radioButton4.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkSlateGray;
            this.radioButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.radioButton4.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.radioButton4.Location = new System.Drawing.Point(3, 3);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(42, 17);
            this.radioButton4.TabIndex = 29;
            this.radioButton4.TabStop = true;
            this.radioButton4.Tag = "4";
            this.radioButton4.Text = "Все";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.CheckedChangetForRadioButt);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.FlatAppearance.BorderSize = 0;
            this.radioButton5.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkSlateGray;
            this.radioButton5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.radioButton5.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.radioButton5.Location = new System.Drawing.Point(3, 26);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(130, 17);
            this.radioButton5.TabIndex = 30;
            this.radioButton5.Tag = "5";
            this.radioButton5.Text = "Юридическое лицо";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.CheckedChangetForRadioButt);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.FlatAppearance.BorderSize = 0;
            this.radioButton6.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkSlateGray;
            this.radioButton6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.radioButton6.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.radioButton6.Location = new System.Drawing.Point(3, 49);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(118, 17);
            this.radioButton6.TabIndex = 31;
            this.radioButton6.Tag = "6";
            this.radioButton6.Text = "Физическое лицо";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.CheckedChangetForRadioButt);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(65)))));
            this.panel3.Controls.Add(this.radioButton1);
            this.panel3.Controls.Add(this.radioButton2);
            this.panel3.Controls.Add(this.radioButton3);
            this.panel3.Location = new System.Drawing.Point(5, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(105, 75);
            this.panel3.TabIndex = 38;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.FlatAppearance.BorderSize = 0;
            this.radioButton1.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkSlateGray;
            this.radioButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.radioButton1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.radioButton1.Location = new System.Drawing.Point(3, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(42, 17);
            this.radioButton1.TabIndex = 29;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "1";
            this.radioButton1.Text = "Все";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.CheckedChangetForRadioButt);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.FlatAppearance.BorderSize = 0;
            this.radioButton2.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkSlateGray;
            this.radioButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.radioButton2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.radioButton2.Location = new System.Drawing.Point(3, 26);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(84, 17);
            this.radioButton2.TabIndex = 30;
            this.radioButton2.Tag = "2";
            this.radioButton2.Text = "Поставщик";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.CheckedChangetForRadioButt);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.FlatAppearance.BorderSize = 0;
            this.radioButton3.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkSlateGray;
            this.radioButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.radioButton3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.radioButton3.Location = new System.Drawing.Point(3, 49);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(62, 17);
            this.radioButton3.TabIndex = 31;
            this.radioButton3.Tag = "3";
            this.radioButton3.Text = "Клиент";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.CheckedChangetForRadioButt);
            // 
            // levelLable
            // 
            this.levelLable.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.levelLable.AutoSize = true;
            this.levelLable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(65)))));
            this.levelLable.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.levelLable.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.levelLable.Location = new System.Drawing.Point(46, 572);
            this.levelLable.Name = "levelLable";
            this.levelLable.Size = new System.Drawing.Size(71, 21);
            this.levelLable.TabIndex = 56;
            this.levelLable.Text = "Отбор :";
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Location = new System.Drawing.Point(516, 639);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(150, 60);
            this.AddButton.TabIndex = 4;
            this.AddButton.Tag = "control7";
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // A4tab1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.levelLable);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowContainer);
            this.Controls.Add(this.label6);
            this.Name = "A4tab1";
            this.Resize += new System.EventHandler(this.A4tab1_Resize);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flowContainer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.Label levelLable;
        public System.Windows.Forms.Button AddButton;
    }
}
