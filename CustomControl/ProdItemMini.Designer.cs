namespace BookMarket.CustomControl
{
    partial class ProdItemMini
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
            this.name = new System.Windows.Forms.Label();
            this.IcomButt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.IcomButt)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(3, 11);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(84, 15);
            this.name.TabIndex = 0;
            this.name.Text = "Нименование";
            // 
            // IcomButt
            // 
            this.IcomButt.Location = new System.Drawing.Point(215, 9);
            this.IcomButt.Name = "IcomButt";
            this.IcomButt.Size = new System.Drawing.Size(23, 23);
            this.IcomButt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IcomButt.TabIndex = 2;
            this.IcomButt.TabStop = false;
            // 
            // ProdItemMini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(65)))));
            this.Controls.Add(this.IcomButt);
            this.Controls.Add(this.name);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Azure;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProdItemMini";
            this.Size = new System.Drawing.Size(250, 40);
            ((System.ComponentModel.ISupportInitialize)(this.IcomButt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        public System.Windows.Forms.PictureBox IcomButt;
    }
}
