
namespace BookMarket.CustomControl
{
    partial class MenuItem
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
            this.Img = new System.Windows.Forms.PictureBox();
            this.lableTitle = new System.Windows.Forms.Label();
            this.ActiveTag = new System.Windows.Forms.Panel();
            this.BgPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Img)).BeginInit();
            this.BgPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Img
            // 
            this.Img.Location = new System.Drawing.Point(268, 9);
            this.Img.Name = "Img";
            this.Img.Size = new System.Drawing.Size(40, 40);
            this.Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Img.TabIndex = 0;
            this.Img.TabStop = false;
            this.Img.Tag = "menuItem";
            // 
            // lableTitle
            // 
            this.lableTitle.AutoSize = true;
            this.lableTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableTitle.ForeColor = System.Drawing.Color.Azure;
            this.lableTitle.Location = new System.Drawing.Point(19, 20);
            this.lableTitle.Name = "lableTitle";
            this.lableTitle.Size = new System.Drawing.Size(52, 21);
            this.lableTitle.TabIndex = 1;
            this.lableTitle.Tag = "menuItem";
            this.lableTitle.Text = "label1";
            // 
            // ActiveTag
            // 
            this.ActiveTag.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ActiveTag.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ActiveTag.Location = new System.Drawing.Point(7, 5);
            this.ActiveTag.Name = "ActiveTag";
            this.ActiveTag.Size = new System.Drawing.Size(3, 50);
            this.ActiveTag.TabIndex = 2;
            this.ActiveTag.Visible = false;
            // 
            // BgPanel
            // 
            this.BgPanel.Controls.Add(this.lableTitle);
            this.BgPanel.Controls.Add(this.Img);
            this.BgPanel.Controls.Add(this.ActiveTag);
            this.BgPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BgPanel.Location = new System.Drawing.Point(0, 0);
            this.BgPanel.Name = "BgPanel";
            this.BgPanel.Size = new System.Drawing.Size(318, 60);
            this.BgPanel.TabIndex = 3;
            this.BgPanel.Tag = "menuItem";
            // 
            // menuItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(56)))));
            this.Controls.Add(this.BgPanel);
            this.Name = "menuItem";
            this.Size = new System.Drawing.Size(318, 60);
            ((System.ComponentModel.ISupportInitialize)(this.Img)).EndInit();
            this.BgPanel.ResumeLayout(false);
            this.BgPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox Img;
        public System.Windows.Forms.Label lableTitle;
        private System.Windows.Forms.Panel ActiveTag;
        public System.Windows.Forms.Panel BgPanel;
    }
}
