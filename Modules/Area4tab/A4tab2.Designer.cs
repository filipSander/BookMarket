namespace BookMarket.Modules.Area4tab
{
    partial class A4tab2
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
            this.reloadButt = new System.Windows.Forms.Button();
            this.flowContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Lavender;
            this.label6.Location = new System.Drawing.Point(13, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 45;
            this.label6.Text = "Реквизиты";
            // 
            // reloadButt
            // 
            this.reloadButt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.reloadButt.FlatAppearance.BorderSize = 0;
            this.reloadButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.reloadButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reloadButt.Location = new System.Drawing.Point(516, 639);
            this.reloadButt.Name = "reloadButt";
            this.reloadButt.Size = new System.Drawing.Size(150, 60);
            this.reloadButt.TabIndex = 83;
            this.reloadButt.Tag = "control7";
            this.reloadButt.Text = "Обновить";
            this.reloadButt.UseVisualStyleBackColor = true;
            this.reloadButt.Click += new System.EventHandler(this.reloadButt_Click);
            // 
            // flowContainer
            // 
            this.flowContainer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowContainer.Location = new System.Drawing.Point(45, 56);
            this.flowContainer.Name = "flowContainer";
            this.flowContainer.Size = new System.Drawing.Size(600, 510);
            this.flowContainer.TabIndex = 84;
            // 
            // A4tab2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowContainer);
            this.Controls.Add(this.reloadButt);
            this.Controls.Add(this.label6);
            this.Name = "A4tab2";
            this.Resize += new System.EventHandler(this.A4tab2_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button reloadButt;
        private System.Windows.Forms.FlowLayoutPanel flowContainer;
    }
}
