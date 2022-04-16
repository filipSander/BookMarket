namespace BookMarket.CustomControl
{
    partial class GroupItem
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
            this.DeleteGr = new System.Windows.Forms.Button();
            this.lableName = new System.Windows.Forms.Label();
            this.countLable = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // DeleteGr
            // 
            this.DeleteGr.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DeleteGr.FlatAppearance.BorderSize = 0;
            this.DeleteGr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.DeleteGr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteGr.Location = new System.Drawing.Point(489, 12);
            this.DeleteGr.Name = "DeleteGr";
            this.DeleteGr.Size = new System.Drawing.Size(83, 31);
            this.DeleteGr.TabIndex = 7;
            this.DeleteGr.Tag = "control7";
            this.DeleteGr.Text = "Удалить";
            this.DeleteGr.UseVisualStyleBackColor = true;
            // 
            // lableName
            // 
            this.lableName.AutoSize = true;
            this.lableName.Location = new System.Drawing.Point(13, 21);
            this.lableName.Name = "lableName";
            this.lableName.Size = new System.Drawing.Size(36, 13);
            this.lableName.TabIndex = 8;
            this.lableName.Text = "Name";
            // 
            // countLable
            // 
            this.countLable.AutoSize = true;
            this.countLable.Location = new System.Drawing.Point(388, 21);
            this.countLable.Name = "countLable";
            this.countLable.Size = new System.Drawing.Size(39, 13);
            this.countLable.TabIndex = 9;
            this.countLable.Text = "Count";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 1);
            this.panel1.TabIndex = 10;
            // 
            // GroupItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(65)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.countLable);
            this.Controls.Add(this.lableName);
            this.Controls.Add(this.DeleteGr);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Azure;
            this.Name = "GroupItem";
            this.Size = new System.Drawing.Size(575, 55);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button DeleteGr;
        private System.Windows.Forms.Label lableName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label countLable;
    }
}
