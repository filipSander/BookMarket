namespace BookMarket.CustomControl
{
    partial class RqItem
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
            this.title = new System.Windows.Forms.Label();
            this.tbvalue = new System.Windows.Forms.TextBox();
            this.bgPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(65)))));
            this.title.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.title.Location = new System.Drawing.Point(66, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(43, 21);
            this.title.TabIndex = 52;
            this.title.Text = "Title";
            // 
            // tbvalue
            // 
            this.tbvalue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(65)))));
            this.tbvalue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbvalue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbvalue.ForeColor = System.Drawing.Color.Azure;
            this.tbvalue.Location = new System.Drawing.Point(70, 28);
            this.tbvalue.MaxLength = 120;
            this.tbvalue.Name = "tbvalue";
            this.tbvalue.Size = new System.Drawing.Size(436, 22);
            this.tbvalue.TabIndex = 54;
            this.tbvalue.Tag = "control1";
            this.tbvalue.Text = "Value";
            this.tbvalue.TextChanged += new System.EventHandler(this.tbvalue_TextChanged);
            // 
            // bgPanel
            // 
            this.bgPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.bgPanel.Location = new System.Drawing.Point(65, 23);
            this.bgPanel.Name = "bgPanel";
            this.bgPanel.Size = new System.Drawing.Size(445, 32);
            this.bgPanel.TabIndex = 53;
            // 
            // RqItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(65)))));
            this.Controls.Add(this.title);
            this.Controls.Add(this.tbvalue);
            this.Controls.Add(this.bgPanel);
            this.Name = "RqItem";
            this.Size = new System.Drawing.Size(575, 55);
            this.Enter += new System.EventHandler(this.RqItem_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox tbvalue;
        private System.Windows.Forms.Panel bgPanel;
    }
}
