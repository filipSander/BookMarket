namespace BookMarket.Modules.Area4tab
{
    partial class A4tab7
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
            this.ExitButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRprice = new System.Windows.Forms.Label();
            this.rPrice = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblPprice = new System.Windows.Forms.Label();
            this.pPrice = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.nameProduct = new System.Windows.Forms.TextBox();
            this.bgPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.uMeasurement = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddGroup = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Location = new System.Drawing.Point(404, 639);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(93, 60);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Отмена";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(516, 639);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(150, 60);
            this.addButton.TabIndex = 57;
            this.addButton.Tag = "control7";
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Lavender;
            this.label6.Location = new System.Drawing.Point(13, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 21);
            this.label6.TabIndex = 63;
            this.label6.Text = "Регистрация товара";
            // 
            // lblRprice
            // 
            this.lblRprice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRprice.AutoSize = true;
            this.lblRprice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(65)))));
            this.lblRprice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRprice.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblRprice.Location = new System.Drawing.Point(73, 288);
            this.lblRprice.Name = "lblRprice";
            this.lblRprice.Size = new System.Drawing.Size(140, 21);
            this.lblRprice.TabIndex = 83;
            this.lblRprice.Text = "Цена реализации";
            // 
            // rPrice
            // 
            this.rPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(65)))));
            this.rPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rPrice.ForeColor = System.Drawing.Color.Azure;
            this.rPrice.Location = new System.Drawing.Point(77, 316);
            this.rPrice.MaxLength = 20;
            this.rPrice.Name = "rPrice";
            this.rPrice.Size = new System.Drawing.Size(167, 22);
            this.rPrice.TabIndex = 85;
            this.rPrice.Tag = "control1";
            this.rPrice.TextChanged += new System.EventHandler(this.nameProduct_TextChanged);
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.panel5.Location = new System.Drawing.Point(72, 311);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(176, 32);
            this.panel5.TabIndex = 84;
            // 
            // lblPprice
            // 
            this.lblPprice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPprice.AutoSize = true;
            this.lblPprice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(65)))));
            this.lblPprice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPprice.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblPprice.Location = new System.Drawing.Point(73, 208);
            this.lblPprice.Name = "lblPprice";
            this.lblPprice.Size = new System.Drawing.Size(114, 21);
            this.lblPprice.TabIndex = 80;
            this.lblPprice.Text = "Цена закупки ";
            // 
            // pPrice
            // 
            this.pPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(65)))));
            this.pPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pPrice.ForeColor = System.Drawing.Color.Azure;
            this.pPrice.Location = new System.Drawing.Point(77, 244);
            this.pPrice.MaxLength = 20;
            this.pPrice.Name = "pPrice";
            this.pPrice.Size = new System.Drawing.Size(167, 22);
            this.pPrice.TabIndex = 82;
            this.pPrice.Tag = "control1";
            this.pPrice.TextChanged += new System.EventHandler(this.nameProduct_TextChanged);
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.panel4.Location = new System.Drawing.Point(72, 239);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(176, 32);
            this.panel4.TabIndex = 81;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(65)))));
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblName.Location = new System.Drawing.Point(73, 107);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(183, 21);
            this.lblName.TabIndex = 70;
            this.lblName.Text = "Наименование товара";
            // 
            // nameProduct
            // 
            this.nameProduct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nameProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(65)))));
            this.nameProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameProduct.ForeColor = System.Drawing.Color.Azure;
            this.nameProduct.Location = new System.Drawing.Point(77, 140);
            this.nameProduct.MaxLength = 300;
            this.nameProduct.Name = "nameProduct";
            this.nameProduct.Size = new System.Drawing.Size(544, 22);
            this.nameProduct.TabIndex = 72;
            this.nameProduct.Tag = "control1";
            this.nameProduct.TextChanged += new System.EventHandler(this.nameProduct_TextChanged);
            // 
            // bgPanel
            // 
            this.bgPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bgPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.bgPanel.Location = new System.Drawing.Point(72, 135);
            this.bgPanel.Name = "bgPanel";
            this.bgPanel.Size = new System.Drawing.Size(553, 32);
            this.bgPanel.TabIndex = 71;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(65)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(73, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 21);
            this.label3.TabIndex = 86;
            this.label3.Text = "Ед. измерения";
            // 
            // uMeasurement
            // 
            this.uMeasurement.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uMeasurement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(65)))));
            this.uMeasurement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uMeasurement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uMeasurement.ForeColor = System.Drawing.Color.Azure;
            this.uMeasurement.Location = new System.Drawing.Point(77, 395);
            this.uMeasurement.MaxLength = 20;
            this.uMeasurement.Name = "uMeasurement";
            this.uMeasurement.Size = new System.Drawing.Size(167, 22);
            this.uMeasurement.TabIndex = 88;
            this.uMeasurement.Tag = "control1";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.panel3.Location = new System.Drawing.Point(72, 390);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(176, 32);
            this.panel3.TabIndex = 87;
            // 
            // flowContainer
            // 
            this.flowContainer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(65)))));
            this.flowContainer.Location = new System.Drawing.Point(3, 5);
            this.flowContainer.Name = "flowContainer";
            this.flowContainer.Size = new System.Drawing.Size(325, 173);
            this.flowContainer.TabIndex = 89;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(65)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(300, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 90;
            this.label1.Text = "Группа/ы";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.flowContainer);
            this.panel1.Location = new System.Drawing.Point(293, 239);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 183);
            this.panel1.TabIndex = 82;
            // 
            // AddGroup
            // 
            this.AddGroup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AddGroup.FlatAppearance.BorderSize = 0;
            this.AddGroup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.AddGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddGroup.Location = new System.Drawing.Point(505, 442);
            this.AddGroup.Name = "AddGroup";
            this.AddGroup.Size = new System.Drawing.Size(120, 41);
            this.AddGroup.TabIndex = 5;
            this.AddGroup.Tag = "control7";
            this.AddGroup.Text = "Добавить группу";
            this.AddGroup.UseVisualStyleBackColor = true;
            // 
            // A4tab7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddGroup);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uMeasurement);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblRprice);
            this.Controls.Add(this.rPrice);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.lblPprice);
            this.Controls.Add(this.pPrice);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.nameProduct);
            this.Controls.Add(this.bgPanel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.ExitButton);
            this.Name = "A4tab7";
            this.Load += new System.EventHandler(this.A4tab7_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRprice;
        private System.Windows.Forms.TextBox rPrice;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblPprice;
        private System.Windows.Forms.TextBox pPrice;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox nameProduct;
        private System.Windows.Forms.Panel bgPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uMeasurement;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button AddGroup;
    }
}
